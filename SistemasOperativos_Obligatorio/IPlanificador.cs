using System.Collections.Generic;

namespace SistemasOperativos_Obligatorio
{
    public interface IPlanificador : IObservable<PlanificadorBase.Estado>{
        Proceso? MoverLaCola();
        void Iniciar();
        void Pausar();
    }
}