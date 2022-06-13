using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasOperativos_Obligatorio
{
    public abstract class PlanificadorBase : IPlanificador
    {
        protected List<IObservador<Estado>> observadores;

        public PlanificadorBase()
        {
            observadores = new List<IObservador<Estado>>();
        }
        public abstract Proceso? EjecutarSiguiente();

        public void Subscribe(IObservador<Estado> observador)
        {
            if (!observadores.Contains(observador))
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
