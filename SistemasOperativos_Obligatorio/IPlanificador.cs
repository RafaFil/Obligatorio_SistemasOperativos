using System.Collections.Generic;

namespace SistemasOperativos_Obligatorio
{
    public interface IPlanificador{
        
        PriorityQueue<Proceso, int> Cola { get; }

    }
}