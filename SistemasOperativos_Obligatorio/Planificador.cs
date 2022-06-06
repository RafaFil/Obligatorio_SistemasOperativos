using System.Collections.Generic;

namespace SistemasOperativos_Obligatorio
{
    public class Planificador : IPlanificador{

        private PriorityQueue<Proceso, TPriority> cola;

        public PriorityQueue<Proceso, TPriority> Cola{
            get{
                return this.cola;
            }
        }

    }
}