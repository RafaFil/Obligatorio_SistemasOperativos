namespace SistemasOperativos_Obligatorio
{

    public class Proceso {

        private static int ProxId {get; set; }
        private int id; 
// Hacerlo autoincremental, atributo estatico que sea id proximo cada vez que pregunta por el id proxima seteas el id de la clase y le sumas 1 al estatico
        private string nombre;
        private bool esDeSo;
        private int prioridad;
        private int intervaloES;
        private int duracionEs;
        private Estado estado;
        private CPU cpu;


        public Proceso (PlantillaProceso plantilla){
            this.nombre = plantilla.nombre;
            this.esDeSo = plantilla.esDeSo;
            this.intervaloES = plantilla.intervaloEs;
            this.duracionEs = plantilla.duracionES;
            this.estado = Estado.listo; // -> Lo Crea como listo o el estado es de forma especial
            this.id = ProxId;
            ProxId++;

            //Falta asignar id (un numero random o el numero de la lista de procesos)
            //Falta asignar la CPU (lo asigna el planificador con su metodo Get)
            //Falta asignar la prioridad 
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
            bloqueado,
            bloqueadoPorUsuario
        }

    }

}