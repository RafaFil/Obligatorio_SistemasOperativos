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

        public void VerComoMueveLaCola(IObservador<Estado> observador)
        {
            if (!observadores.Contains(observador))
            {
                observadores.Add(observador);
                Notificar(observador);
            }
        }

        public void SalirCorriendoAlVerSuPistola(IObservador<Estado> observador)
        {
            if (observadores.Contains(observador))
            {
                observadores.Remove(observador);
            }
        }

        public abstract void Iniciar();
        public abstract void Pausar();
        protected abstract void Notificar();
        protected abstract void Notificar(IObservador<Estado> observador);
        protected abstract Estado GenerarEstado();

        public class Estado
        {
            public IOrderedEnumerable<Proceso> colaDeProcesos;
            public IOrderedEnumerable<Proceso> procesosBloqueados;
            public List<CPU> cpus;

            public Estado(IOrderedEnumerable<Proceso> colaDeProcesos,
                IOrderedEnumerable<Proceso> procesosBloqueados, List<CPU> cpus)
            {
                this.colaDeProcesos = colaDeProcesos;
                this.procesosBloqueados = procesosBloqueados;
                this.cpus = cpus;
            }
        }
    }
}
