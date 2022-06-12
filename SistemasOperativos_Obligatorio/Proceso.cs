using System;

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
        public double tiempoTranscurrido;
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

        public int PorcentajeCompletado
        {
            get
            {
                if (tiempoTranscurrido == 0)
                {
                    return 0;
                }
                else
                {
                    return (int) (duracionCPU / tiempoTranscurrido) * 100;
                }
            }
        }

        public void IncrementarPrioridad()
        {
            prioridad = Math.Max(1, prioridad - 1);
        }

        public enum Estado
        {
            enEjecucion,
            listo,
            bloqueado,
            bloqueadoPorUsuario,
            finalizado
        }

        public override string ToString()
        {
            return $"#{id} {nombre} ({(esDeSo ? "SO" : "USER")}) - {duracionCPU} | {duracionEs} | {intervaloES}";
        }

    }

}