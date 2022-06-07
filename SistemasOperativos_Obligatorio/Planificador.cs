using System.Collections.Generic;

namespace SistemasOperativos_Obligatorio
{
    public class Planificador : IPlanificador{

        private PriorityQueue<Proceso, int> cola;

        public PriorityQueue<Proceso, int> Cola{
            get{
                return this.cola;
            }
        }

    }
}