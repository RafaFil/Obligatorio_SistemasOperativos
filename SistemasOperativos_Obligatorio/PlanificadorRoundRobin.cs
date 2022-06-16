using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using Extensiones;

namespace SistemasOperativos_Obligatorio
{
    public class PlanificadorRoundRobin : PlanificadorBase {

        private PriorityQueue<Proceso, BCP> colaListos;
        private PriorityQueue<Proceso, BCP> colaBloqueados;
        private PriorityQueue<Proceso, BCP> colaFinalizados;
        private Dictionary<Proceso, BCP> bloquesDeControl;

        private List<Proceso> procesos;
        private List<CPU> cpus;
        private TimeSpan frecuenciaActualizacion;
        private readonly TimeSpan TIEMPO_MAXIMO_CPU = new TimeSpan(0, 0, 5);

        private Timer siguienteActualizacion;

        /// <summary>
        /// Crea un nuevo planificador usando un algoritmo de Round Robin.
        /// </summary>
        /// <param name="procesos">los procesos a ejecutar</param>
        /// <param name="cpus">los CPU disponibles</param>
        /// <param name="frecuenciaActualizacion">cada cuántos segundos se actualizará y notificará
        /// el estado de los procesos</param>
        public PlanificadorRoundRobin(List<Proceso> procesos, List<CPU> cpus, double frecuenciaActualizacion)
            : base()
        {
            this.frecuenciaActualizacion = new TimeSpan(0, 0, 0, frecuenciaActualizacion.ParteEntera(),
                frecuenciaActualizacion.ParteDecimal(3));

            this.procesos = procesos;
            this.bloquesDeControl = new Dictionary<Proceso, BCP>();
            procesos.ForEach(p => bloquesDeControl.Add(p, new BCP(p)));
            Comparer<BCP> comparadorPrioridades = Comparer<BCP>.Create((a, b) =>
                (a.Prioridad - a.Envejecimiento).CompareTo(b.Prioridad - b.Envejecimiento));

            this.colaListos = new PriorityQueue<Proceso, BCP>(
                from p in procesos select (p, bloquesDeControl[p]),
                Comparer<BCP>.Create((a, b) =>
                (a.Prioridad - a.Envejecimiento).CompareTo(b.Prioridad - b.Envejecimiento)));

            this.colaBloqueados = new PriorityQueue<Proceso, BCP>(
                Comparer<BCP>.Create((a, b) => a.Proceso.PorcentajeESCompletado.CompareTo(b.Proceso.PorcentajeESCompletado)));
            
            this.colaFinalizados = new PriorityQueue<Proceso, BCP>(
                Comparer<BCP>.Create((a, b) => a.Proceso.id.CompareTo(b.Proceso.id)));

            this.cpus = cpus;
            foreach (CPU cpu in cpus)
            {
                cpu.ProcesoActivo = MoverLaCola();
            }

            Notificar();

            siguienteActualizacion = new Timer(DuracionSiguienteTimer.TotalMilliseconds);
            siguienteActualizacion.Elapsed += ActualizarEstado;
            siguienteActualizacion.AutoReset = false;
        }

        public override void Iniciar()
        {
            siguienteActualizacion.Start();
        }

        public override void Pausar()
        {

        }

        /// <summary>
        /// Si hay un siguiente proceso en la cola de prioridad, lo quita y lo devuelve.
        /// </summary>
        /// <returns>el proceso de menor prioridad</returns>
        public Proceso? MoverLaCola()
        {
            Proceso? siguiente = null;
            bool haySiguiente = colaListos.TryPeek(out siguiente, out _);
            if (haySiguiente && siguiente?.estado == Proceso.Estado.listo)
            {
                siguiente = colaListos.Dequeue();
                AsignarQuantum(siguiente);

                procesos.ForEach(p =>
                {
                    if (bloquesDeControl[p].Estado == Proceso.Estado.listo)
                    {
                        bloquesDeControl[p].Envejecimiento--;
                    }
                });
                bloquesDeControl[siguiente].Envejecimiento = 0;
                bloquesDeControl[siguiente].Estado = Proceso.Estado.enEjecucion;
                return siguiente;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Asigna un quantum adecuado al BCP correspondiente al proceso recibido.
        /// </summary>
        /// <param name="p">el proceso cuyo BCP será modificado</param>
        private void AsignarQuantum(Proceso p)
        {
            TimeSpan quantum;
            // Si no tiene operaciones E/S, o basándome en el intervalo de E/S veo que no realizará
            // ninguna más antes de terminar
            if (p.intervaloES == TimeSpan.Zero
                || p.tiempoCPUTranscurrido - p.tiempoCPUTranscurrido.Mod(p.intervaloES) + p.intervaloES > p.duracionCPU)
            {
                quantum = new [] { TIEMPO_MAXIMO_CPU, p.duracionCPU - p.tiempoCPUTranscurrido }.Min();
            }
            else
            {
                quantum = new[] { TIEMPO_MAXIMO_CPU,
                    p.intervaloES - p.tiempoCPUTranscurrido.Mod(p.intervaloES) }.Min();
            }

            bloquesDeControl[p].Quantum = quantum;
        }

        /// <summary>
        /// El tiempo que debe transcurrir hasta que suceda el siguiente evento en alguno de los
        /// procesos, o hasta que transcurra el intervalo de actualización.
        /// </summary>
        private TimeSpan DuracionSiguienteTimer
        {
            get
            {
                TimeSpan tiempoMinimoHastaES = TimeSpan.MaxValue;
                TimeSpan tiempoMinimoHastaFinalizacion = TimeSpan.MaxValue;
                TimeSpan tiempoMinimoHastaDesbloqueo = TimeSpan.MaxValue;

                IEnumerable<Proceso> procesosEnEjecucion = procesos
                    .Where(p => p.estado == Proceso.Estado.enEjecucion);
                IEnumerable<Proceso> procesosBloqueadosPorES = procesos
                    .Where(p => p.estado == Proceso.Estado.bloqueado);

                if (procesosEnEjecucion.Count() > 0)
                {
                    tiempoMinimoHastaES = procesosEnEjecucion
                        .Select(p => p.intervaloES == TimeSpan.Zero
                            ? TimeSpan.MaxValue
                            : p.intervaloES - p.tiempoCPUTranscurrido.Mod(p.intervaloES))
                        .Min();
                    tiempoMinimoHastaFinalizacion = procesosEnEjecucion
                        .Select(p => p.duracionCPU - p.tiempoCPUTranscurrido)
                        .Min();
                }

                if (procesosBloqueadosPorES.Count() > 0)
                {
                    tiempoMinimoHastaDesbloqueo = procesosBloqueadosPorES
                        .Select(p => p.duracionEs - p.tiempoESTranscurrido)
                        .Min();
                }

                return new TimeSpan[] { tiempoMinimoHastaES,
                    tiempoMinimoHastaFinalizacion,
                    tiempoMinimoHastaDesbloqueo,
                    frecuenciaActualizacion }.Min();
            }
        }

        /// <summary>
        /// Actualiza el estado de los procesos luego de transcurrido un intervalo de actualización.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActualizarEstado(object? sender, ElapsedEventArgs e)
        {
            TimeSpan deltaT = TimeSpan.FromMilliseconds(siguienteActualizacion.Interval);
            IEnumerable<Proceso> procesosActivos = from cpu in cpus
                                                   where cpu.ProcesoActivo != null
                                                   select cpu.ProcesoActivo;

            IEnumerable<Proceso> procesosBloqueados = from bcp in bloquesDeControl.Values
                                                      where bcp.Proceso.EstaBloqueado
                                                      select bcp.Proceso;
            
            

            foreach (Proceso p in procesosBloqueados)
            {
                p.tiempoESTranscurrido += deltaT;
            }

            (Proceso?, BCP?) primerPar = new (null, null);
            while (colaBloqueados.TryPeek(out primerPar.Item1, out primerPar.Item2)
                && primerPar.Item1.tiempoESTranscurrido == primerPar.Item1.duracionEs)
            {
                Proceso p = colaBloqueados.Dequeue();
                p.estado = Proceso.Estado.listo;
                p.tiempoESTranscurrido = TimeSpan.Zero;
                colaListos.Enqueue(p, bloquesDeControl[p]);
            }

            foreach (CPU cpu in cpus)
            {
                if (cpu.ProcesoActivo == null)
                {
                    ReasignarCPU(cpu, Proceso.Estado.listo);
                }
                else
                {
                    Proceso p = cpu.ProcesoActivo;

                    p.tiempoCPUTranscurrido += deltaT;
                    bloquesDeControl[p].Quantum -= deltaT;

                    // Si transcurrió todo el tiempo que el proceso indica que ocupa la CPU
                    if (p.tiempoCPUTranscurrido == p.duracionCPU)
                    {
                        ReasignarCPU(cpu, Proceso.Estado.finalizado);
                    }

                    // Si el proceso tiene operaciones E/S (intervalo != 0)
                    // y el tiempo de CPU transcurrido es múltiplo del intervalo
                    else if (p.intervaloES != TimeSpan.Zero
                        && p.tiempoCPUTranscurrido.Mod(p.intervaloES) == TimeSpan.Zero)
                    {
                        ReasignarCPU(cpu, Proceso.Estado.bloqueado);
                    }

                    // Si se le acabó el quantum y al proceso le va a ser expropiado el CPU
                    else if (bloquesDeControl[p].Quantum == TimeSpan.Zero)
                    {
                        ReasignarCPU(cpu, Proceso.Estado.listo);
                    }
                }
            }

            Notificar();

            if (colaListos.UnorderedItems.Any()
                || colaBloqueados.UnorderedItems.Any()
                || procesosActivos.Any())
            {
                siguienteActualizacion.Interval = DuracionSiguienteTimer.TotalMilliseconds;
                siguienteActualizacion.Start();
            }
        }

        /// <summary>
        /// Dado un CPU y un estado de proceso, asigna ese estado al proceso que ese CPU está ejecutando
        /// actualmente, lo coloca en la cola de prioridad de procesos, y coloca el proceso de menor
        /// prioridad en este CPU
        /// </summary>
        /// <param name="cpu">el CPU al que se le asignará un nuevo proceso</param>
        /// <param name="nuevoEstado">el estado asignado al proceso que deja el CPU</param>
        private void ReasignarCPU(CPU cpu, Proceso.Estado nuevoEstado)
        {
            if (cpu.ProcesoActivo != null)
            {
                cpu.ProcesoActivo.cpu = null;
                cpu.ProcesoActivo.estado = nuevoEstado;
                bloquesDeControl[cpu.ProcesoActivo].Quantum = TimeSpan.Zero;
                switch (nuevoEstado)
                {
                    case Proceso.Estado.listo:
                        colaListos.Enqueue(cpu.ProcesoActivo, bloquesDeControl[cpu.ProcesoActivo]);
                        break;

                    case Proceso.Estado.bloqueado:
                        colaBloqueados.Enqueue(cpu.ProcesoActivo, bloquesDeControl[cpu.ProcesoActivo]);
                        break;

                    case Proceso.Estado.finalizado:
                        colaFinalizados.Enqueue(cpu.ProcesoActivo, bloquesDeControl[cpu.ProcesoActivo]);
                        break;
                }
            }
            cpu.ProcesoActivo = MoverLaCola();
        }

        protected override void Notificar()
        {
            Estado estado = GenerarEstado();

            foreach (IObservador<Estado> observador in observadores)
            {
                observador.Notificar(estado);
            }
        }

        protected override void Notificar(IObservador<Estado> observador)
        {
            Estado estado = GenerarEstado();

            observador.Notificar(estado);
        }

        protected override Estado GenerarEstado()
        {
            return new Estado(
                colaListos.UnorderedItems.ToList().Select(par => par.Element)
                    .OrderBy(p => bloquesDeControl[p], colaListos.Comparer),
                colaBloqueados.UnorderedItems.ToList().Select(par => par.Element)
                    .OrderBy(p => bloquesDeControl[p], colaBloqueados.Comparer),
                colaFinalizados.UnorderedItems.ToList().Select(par => par.Element)
                    .OrderBy(p => bloquesDeControl[p], colaFinalizados.Comparer),
                cpus);
        }
    }
}