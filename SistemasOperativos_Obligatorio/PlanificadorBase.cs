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
        protected bool pausado = true;

        protected TimeSpan intervaloActualizacion;

        public bool Pausado
        {
            get => pausado;
            set
            {
                if (value != pausado)
                {
                    pausado = value;
                    PausadoChanged.Invoke(this, EventArgs.Empty);
                    if (pausado)
                    {
                        Pausar();
                    }
                    else
                    {
                        Iniciar();
                    }
                }
            }
        }

        public event EventHandler PausadoChanged;

        public PlanificadorBase(TimeSpan intervaloActualizacion)
        {
            observadores = new List<IObservador<Estado>>();
            this.intervaloActualizacion = intervaloActualizacion;
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
        public abstract void BloquearProceso(Proceso p);
        public abstract void DesbloquearProceso(Proceso p);
        protected abstract void Notificar();
        protected abstract void Notificar(IObservador<Estado> observador);
        protected abstract Estado GenerarEstado();

        public class Estado
        {
            public IOrderedEnumerable<Proceso> listos;
            public IOrderedEnumerable<Proceso> bloqueados;
            public IOrderedEnumerable<Proceso> finalizados;
            public List<Proceso> bloqueadosPorUsuario;
            public List<CPU> cpus;

            public Estado(IOrderedEnumerable<Proceso> listos, IOrderedEnumerable<Proceso> bloqueados,
                IOrderedEnumerable<Proceso> finalizados, List<Proceso> bloqueadosPorUsuario,
                List<CPU> cpus)
            {
                this.listos = listos;
                this.bloqueados = bloqueados;
                this.finalizados = finalizados;
                this.bloqueadosPorUsuario = bloqueadosPorUsuario;
                this.cpus = cpus;
            }
        }
    }
}
