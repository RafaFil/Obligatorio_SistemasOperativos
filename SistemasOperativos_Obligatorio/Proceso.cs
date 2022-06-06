namespace SistemasOperativos_Obligatorio
{

    public class Proceso {
        private int id;
        private string nombre;
        private bool esDeSo;
        private int prioridad;
        private int intervaloES;
        private int duracionEs;
        private Estado estado;
        private CPU cpu;
 


        public Proceso(string nombre, bool esDeSo){
            this.nombre = nombre;
            this.esDeSo = esDeSo;
        }

        public int Prioridad{
            get{
                return this.prioridad;
            }
            set{
                this.prioridad = value;
            }
        }

        public CPU Cpu{
            get{
                return this.cpu;
            }
            set{
                this.cpu = value;
            }
        }

        public enum Estado
        {
            enEjecucion,
            listo,
            bloqueado
        }


    }

}