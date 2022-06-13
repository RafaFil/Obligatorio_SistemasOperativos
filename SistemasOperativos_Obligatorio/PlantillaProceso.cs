using System;

namespace SistemasOperativos_Obligatorio
{
    public class PlantillaProceso
    {
        public string nombre {get;}
        public TimeSpan duracionCPU{get;}
        public TimeSpan duracionES {get;}
        public TimeSpan intervaloEs {get;}
        public bool esDeSo{get;}

        public PlantillaProceso(string nombre, int duracionCPU, int duracionES, int intervaloEs, bool esDeSo)
        {
            this.nombre = nombre;
            this.duracionCPU = new TimeSpan(0, 0, duracionCPU);
            this.duracionES = new TimeSpan(0, 0, duracionES);
            this.intervaloEs = new TimeSpan(0, 0, intervaloEs);
            this.esDeSo = esDeSo;
        }

        // Constructor PlantillaProceso
        // CreateProcess

        public override string ToString()
        {
            return $"{nombre} ({(esDeSo ? "SO" : "USER")}) - {duracionCPU} | {duracionES} | {intervaloEs}";
        }
    }
}