using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using Extensiones;

namespace SistemasOperativos_Obligatorio
{

    public class Planificador : PlanificadorBase {

        private PriorityQueue<Proceso, Proceso> cola;
        private Dictionary<Proceso, TimeSpan> quantums;
        private List<Proceso> procesos;
        private List<CPU> cpus;
        private TimeSpan frecuenciaActualizacion;
        private readonly TimeSpan TIEMPO_MAXIMO_CPU = new TimeSpan(0, 0, 5);

        private DateTime ultimaActualizacion;
        private Timer siguienteActualizacion;

        public Planificador(List<Proceso> procesos, List<CPU> cpus, double frecuenciaActualizacion)
            : base()
        {
            this.frecuenciaActualizacion = new TimeSpan(0, 0, 0, frecuenciaActualizacion.ParteEntera(),
                frecuenciaActualizacion.ParteDecimal(3));
            this.procesos = procesos;
            this.cola = new PriorityQueue<Proceso, Proceso>(from p in procesos select (p, p),
                Comparer<Proceso>.Create((a, b) =>
                {
                    if (a.estado == Proceso.Estado.enEjecucion)
                    {
                        if (b.estado == Proceso.Estado.enEjecucion)
                        {
                            return a.prioridad.CompareTo(b.prioridad);
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else if (a.estado == Proceso.Estado.finalizado)
                    {
                        return 1;
                    }
                    else
                    {
                        return a.prioridad.CompareTo(b.prioridad);
                    }
                }));
            this.cpus = cpus;

            siguienteActualizacion = new Timer(DuracionSiguienteTimer.TotalMilliseconds);
            siguienteActualizacion.Elapsed += ActualizarEstado;
            siguienteActualizacion.AutoReset = false;
            ultimaActualizacion = DateTime.Now;
            siguienteActualizacion.Start();
        }

        public override Proceso? EjecutarSiguiente()
        {
            Proceso? siguiente = null;
            bool haySiguiente = cola.TryPeek(out siguiente, out _);
            if (haySiguiente && siguiente?.estado == Proceso.Estado.listo)
            {
                siguiente = cola.Dequeue();
                AsignarQuantum(siguiente);

                this.procesos.ForEach(p => p.IncrementarPrioridad());
                siguiente.estado = Proceso.Estado.enEjecucion;
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
                || p.tiempoTranscurrido - p.tiempoTranscurrido.Modulo(p.intervaloES) + p.intervaloES > p.duracionCPU)
            {
                quantum = new [] { TIEMPO_MAXIMO_CPU, p.duracionCPU - p.tiempoTranscurrido }.Min();
            }
            else
            {
                quantum = new[] { TIEMPO_MAXIMO_CPU,
                    p.intervaloES - p.tiempoTranscurrido.Modulo(p.intervaloES) }.Min();
            }

            quantums.Add(p, quantum);
        }

        private TimeSpan DuracionSiguienteTimer
        {
            get
            {
                TimeSpan tiempoMinimoHastaES = procesos.Where(p => p.estado == Proceso.Estado.enEjecucion)
                    .Select(p => p.intervaloES == TimeSpan.Zero
                        ? TimeSpan.MaxValue
                        : p.intervaloES - p.tiempoTranscurrido.Modulo(p.intervaloES))
                    .Min();
                TimeSpan tiempoMinimoHastaFinalizacion =procesos
                    .Where(p => p.estado == Proceso.Estado.enEjecucion)
                    .Select(p => p.duracionCPU - p.tiempoTranscurrido)
                    .Min();
                return new TimeSpan[] { tiempoMinimoHastaES,
                    tiempoMinimoHastaFinalizacion,
                    frecuenciaActualizacion }.Min();
            }
        }

        private void ActualizarEstado(object? sender, ElapsedEventArgs e)
        {
            TimeSpan deltaT = DateTime.Now - ultimaActualizacion;
            IEnumerable<Proceso> procesosActivos = from cpu in cpus
                                                   where cpu.ProcesoActivo != null
                                                   select cpu.ProcesoActivo;
            foreach (Proceso p in procesosActivos)
            {
                p.tiempoTranscurrido += deltaT;
            }

            // TODO: seguir con esto
        }

        public void Notificar()
        {
            procesos.Sort(cola.Comparer);
            Estado estado = new Estado(procesos,
                procesos.Where(p => p.estado == Proceso.Estado.bloqueado || p.estado == Proceso.Estado.bloqueadoPorUsuario)
                    .OrderBy(p => p.estado),
                cpus);
            foreach (IObservador<Estado> observador in observadores)
            {
                observador.Notificar(estado);
            }
        }
    }
}