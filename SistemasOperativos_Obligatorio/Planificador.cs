using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using Extensiones;

namespace SistemasOperativos_Obligatorio
{

    public class Planificador : PlanificadorBase {

        private PriorityQueue<Proceso, BCP> cola;
        private Dictionary<Proceso, BCP> bloquesDeControl;

        private List<Proceso> procesos;
        private List<CPU> cpus;
        private TimeSpan frecuenciaActualizacion;
        private readonly TimeSpan TIEMPO_MAXIMO_CPU = new TimeSpan(0, 0, 5);

        private Timer siguienteActualizacion;

        public Planificador(List<Proceso> procesos, List<CPU> cpus, double frecuenciaActualizacion)
            : base()
        {
            this.frecuenciaActualizacion = new TimeSpan(0, 0, 0, frecuenciaActualizacion.ParteEntera(),
                frecuenciaActualizacion.ParteDecimal(3));

            this.procesos = procesos;
            this.bloquesDeControl = new Dictionary<Proceso, BCP>();
            procesos.ForEach(p => bloquesDeControl.Add(p, new BCP(p)));

            this.cola = new PriorityQueue<Proceso, BCP>(from p in procesos select (p, bloquesDeControl[p]),
                Comparer<BCP>.Create((a, b) =>
                {
                    if (a.Estado == Proceso.Estado.listo)
                    {
                        if (b.Estado == Proceso.Estado.listo)
                        {
                            return -(a.Prioridad - a.Envejecimiento)
                            .CompareTo(b.Prioridad - b.Envejecimiento);
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else
                    {
                        return a.PorcentajeCompletado - b.PorcentajeCompletado;
                    }
                    /*
                    if (a.estado == Proceso.Estado.enEjecucion)
                    {
                        if (b.estado == Proceso.Estado.enEjecucion)
                        {
                            return (a.prioridad - envejecimientos[a]).CompareTo(b.prioridad - envejecimientos[b]);
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else if (a.estado == Proceso.Estado.finalizado && b.estado != Proceso.Estado.finalizado)
                    {
                        return 1;
                    }
                    else
                    {
                        return (a.prioridad - envejecimientos[a]).CompareTo(b.prioridad - envejecimientos[b]);
                    }
                    */
                }));

            this.cpus = cpus;
            foreach (CPU cpu in cpus)
            {
                cpu.ProcesoActivo = MoverLaCola();
            }

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

        public override Proceso? MoverLaCola()
        {
            Proceso? siguiente = null;
            bool haySiguiente = cola.TryPeek(out siguiente, out _);
            if (haySiguiente && siguiente?.estado == Proceso.Estado.listo)
            {
                siguiente = cola.Dequeue();
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

        private void AsignarQuantum(Proceso p)
        {
            TimeSpan quantum;
            // Si no tiene operaciones E/S, o basándome en el intervalo de E/S veo que no realizará
            // ninguna más antes de terminar
            if (p.intervaloES == TimeSpan.Zero
                || p.tiempoTranscurrido - p.tiempoTranscurrido.Mod(p.intervaloES) + p.intervaloES > p.duracionCPU)
            {
                quantum = new [] { TIEMPO_MAXIMO_CPU, p.duracionCPU - p.tiempoTranscurrido }.Min();
            }
            else
            {
                quantum = new[] { TIEMPO_MAXIMO_CPU,
                    p.intervaloES - p.tiempoTranscurrido.Mod(p.intervaloES) }.Min();
            }

            bloquesDeControl[p].Quantum = quantum;
        }

        private TimeSpan DuracionSiguienteTimer
        {
            get
            {
                TimeSpan tiempoMinimoHastaES = procesos.Where(p => p.estado == Proceso.Estado.enEjecucion)
                    .Select(p => p.intervaloES == TimeSpan.Zero
                        ? TimeSpan.MaxValue
                        : p.intervaloES - p.tiempoTranscurrido.Mod(p.intervaloES))
                    .Min();
                TimeSpan tiempoMinimoHastaFinalizacion = procesos
                    .Where(p => p.estado == Proceso.Estado.enEjecucion)
                    .Select(p => p.duracionCPU - p.tiempoTranscurrido)
                    .Min();
                // Considerar también los procesos que terminen bloqueo por E/S
                return new TimeSpan[] { tiempoMinimoHastaES,
                    tiempoMinimoHastaFinalizacion,
                    frecuenciaActualizacion }.Min();
            }
        }

        private void ActualizarEstado(object? sender, ElapsedEventArgs e)
        {
            TimeSpan deltaT = TimeSpan.FromMilliseconds(siguienteActualizacion.Interval);
            IEnumerable<Proceso> procesosActivos = from cpu in cpus
                                                   where cpu.ProcesoActivo != null
                                                   select cpu.ProcesoActivo;

            foreach (Proceso p in procesosActivos)
            {
                p.tiempoTranscurrido += deltaT;
                bloquesDeControl[p].Quantum -= deltaT;
                if (p.intervaloES != TimeSpan.Zero
                    && p.tiempoTranscurrido.Mod(p.intervaloES) == TimeSpan.Zero)
                {
                    ReasignarCPU(p.cpu, Proceso.Estado.bloqueado);
                }
                else if (p.tiempoTranscurrido == p.duracionCPU)
                {
                    ReasignarCPU(p.cpu, Proceso.Estado.finalizado);
                }
                else if (bloquesDeControl[p].Quantum == TimeSpan.Zero)
                {
                    ReasignarCPU(p.cpu, Proceso.Estado.listo);
                }
            }
            // TODO: también puede ser necesario hacer algo cuando el proceso termina de estar bloqueado
            Notificar();

            if (procesos.Any(p => p.estado != Proceso.Estado.finalizado))
            {
                siguienteActualizacion.Interval = DuracionSiguienteTimer.TotalMilliseconds;
                siguienteActualizacion.Start();
            }
        }

        private void ReasignarCPU(CPU cpu, Proceso.Estado nuevoEstado)
        {
            cpu.ProcesoActivo.cpu = null;
            cpu.ProcesoActivo.estado = nuevoEstado;
            bloquesDeControl[cpu.ProcesoActivo].Quantum = TimeSpan.Zero;
            cola.Enqueue(cpu.ProcesoActivo, bloquesDeControl[cpu.ProcesoActivo]);
            cpu.ProcesoActivo = MoverLaCola();
        }

        public void Notificar()
        {
            Estado estado = new Estado(
                bloquesDeControl.Keys.OrderBy(p => bloquesDeControl[p], cola.Comparer),
                bloquesDeControl.Keys.Where(p => 
                        new [] {Proceso.Estado.bloqueado, Proceso.Estado.bloqueadoPorUsuario }
                        .Contains(bloquesDeControl[p].Estado))
                    .OrderBy(p => p.estado),
                cpus);
            foreach (IObservador<Estado> observador in observadores)
            {
                observador.Notificar(estado);
            }
        }
    }
}