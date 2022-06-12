using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;

namespace SistemasOperativos_Obligatorio
{
    public class Planificador : IPlanificador, IObservable<Planificador.Estado> {

        private PriorityQueue<Proceso, Proceso> cola;
        private Dictionary<Proceso, double> quantums;
        private List<Proceso> procesos;
        private List<CPU> cpus;
        private double frecuenciaActualizacion;
        private const double TIEMPO_MAXIMO_CPU = 5;

        private Timer siguienteReasignacion;
        private Timer siguienteActualizacion;

        private List<IObservador<Estado>> observadores;

        public Planificador(List<Proceso> procesos, List<CPU> cpus, double frecuenciaActualizacion)
        {
            this.frecuenciaActualizacion = frecuenciaActualizacion;
            this.procesos = procesos;
            this.cola = new PriorityQueue<Proceso, Proceso>(from p in procesos select (p, p),
                Comparer<Proceso>.Create((p1, p2) =>
                {
                    if (p1.estado != Proceso.Estado.listo)
                    {
                        return 1;
                    }
                    else
                    {
                        return p1.prioridad - p2.prioridad;
                    }
                }));
            this.cpus = cpus;

            double tiempoSiguienteInterrupcion = Math.Min(procesos.Min(p => p.intervaloES), TIEMPO_MAXIMO_CPU);
            siguienteReasignacion = new Timer(tiempoSiguienteInterrupcion);
            siguienteReasignacion.Elapsed += ReasignarCPUs;





            siguienteReasignacion.Start();
        }

        public double ObtenerTiempoMaximoEnCPU()
        {
            return TIEMPO_MAXIMO_CPU;
        }

        public Proceso? EjecutarSiguiente()
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
            double quantum;
            // Si no tiene operaciones E/S, o basándome en el intervalo de E/S veo que no realizará
            // ninguna más antes de terminar
            if (p.intervaloES == 0
                || p.tiempoTranscurrido + p.intervaloES > p.duracionCPU)
            {
                quantum = Math.Min(TIEMPO_MAXIMO_CPU, p.duracionCPU);
            }
            else
            {
                quantum = Math.Min(TIEMPO_MAXIMO_CPU,
                    p.intervaloES - p.tiempoTranscurrido % p.intervaloES);
            }

            quantums.Add(p, quantum);
        }

        private void ReasignarCPUs(object? sender, ElapsedEventArgs e)
        {

        }

        public void Subscribe(IObservador<Estado> observador)
        {
            if (! observadores.Contains(observador))
            {
                observadores.Add(observador);
            }
        }

        public void Unsubscribe(IObservador<Estado> observador)
        {
            if (observadores.Contains(observador))
            {
                observadores.Remove(observador);
            }
        }

        public void Notificar()
        {
            procesos.Sort(cola.Comparer);
            Estado estado = new Estado(procesos,
                procesos.Where(p => p.estado == Proceso.Estado.bloqueado
                    || p.estado == Proceso.Estado.bloqueadoPorUsuario).OrderBy(p => p.estado),
                cpus);
            foreach (IObservador<Estado> observador in observadores)
            {
                observador.Notificar(estado);
            }
        }

        public class Estado
        {
            public List<Proceso> colaDeProcesos;
            public IOrderedEnumerable<Proceso> procesosBloqueados;
            public List<CPU> cpus;

            public Estado(List<Proceso> colaDeProcesos,
                IOrderedEnumerable<Proceso> procesosBloqueados, List<CPU> cpus)
            {
                this.colaDeProcesos = colaDeProcesos;
                this.procesosBloqueados = procesosBloqueados;
                this.cpus = cpus;
            }
        }
    }
}