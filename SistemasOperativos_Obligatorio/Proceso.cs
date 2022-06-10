namespace SistemasOperativos_Obligatorio
{

    public class Proceso {

        private static int ProxId {get; set; }
        public int id { get; }
        public string nombre;
        public bool esDeSo;
        public int prioridad;

        public int duracionCPU;
        public int intervaloES;
        public int duracionEs;
        public Estado estado;
        public CPU cpu;


        public Proceso (PlantillaProceso plantilla){
            this.nombre = plantilla.nombre;
            this.duracionCPU = plantilla.duracionCPU;
            this.esDeSo = plantilla.esDeSo;
            this.intervaloES = plantilla.intervaloEs;
            this.duracionEs = plantilla.duracionES;
            this.estado = Estado.listo;
            this.id = ProxId;
            ProxId++;

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

        public override string ToString()
        {
            return $"{nombre} ({(esDeSo ? "SO" : "USER")}) - {duracionCPU} | {duracionEs} | {intervaloES}";
        }

    }

}