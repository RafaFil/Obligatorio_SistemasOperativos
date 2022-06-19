using System;

namespace SistemasOperativos_Obligatorio
{
    public class Proceso {

        private static int ProxId {get; set; }
        public int id { get; }
        public string nombre;
        public bool esDeSo;
        public int prioridad;

        public TimeSpan duracionCPU;
        public TimeSpan intervaloES;
        public TimeSpan duracionEs;
        public TimeSpan tiempoCPUTranscurrido;
        public TimeSpan tiempoESTranscurrido;
        public Estado estado;
        public CPU? cpu;

        public Proceso (PlantillaProceso plantilla){
            this.nombre = plantilla.nombre;
            this.duracionCPU = plantilla.duracionCPU;
            this.esDeSo = plantilla.esDeSo;
            this.intervaloES = plantilla.intervaloEs;
            this.duracionEs = plantilla.duracionES;
            this.estado = Estado.listo;
            this.tiempoCPUTranscurrido = TimeSpan.Zero;
            this.tiempoESTranscurrido = TimeSpan.Zero;
            this.id = ProxId;
            ProxId++;
        }

        public int Prioridad{
            get{
                return this.prioridad;
            }
            set{
                this.prioridad = value;
            }
        }

        public CPU? Cpu{
            get{
                return this.cpu;
            }
            set{
                this.cpu = value;
            }
        }

        public int PorcentajeCPUCompletado
        {
            get => tiempoCPUTranscurrido != TimeSpan.Zero 
                ? (int)(tiempoCPUTranscurrido / duracionCPU * 100) 
                : 0;
        }
        public int PorcentajeESCompletado
        {
            get => tiempoESTranscurrido != TimeSpan.Zero
                ? (int)(tiempoESTranscurrido / duracionEs * 100)
                : 0;
        }

        public bool EstaBloqueado
        {
            get => estado == Estado.bloqueado || estado == Estado.bloqueadoPorUsuario;
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