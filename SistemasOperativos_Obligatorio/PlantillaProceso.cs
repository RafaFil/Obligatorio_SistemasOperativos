namespace SistemasOperativos_Obligatorio
{
    public class PlantillaProceso
    {
        public string nombre {get;}
        public int duracionCPU{get;}
        public int duracionES{get;}
        public int intervaloEs{get;}
        public bool esDeSo{get;}

        public PlantillaProceso(string nombre, int duracionCPU, int duracionES, int intervaloEs, bool esDeSo)
        {
            this.nombre = nombre;
            this.duracionCPU = duracionCPU;
            this.duracionES = duracionES;
            this.intervaloEs = intervaloEs;
            this.esDeSo = esDeSo;
        }

        // Constructor PlantillaProceso
        // CreateProcess
    }
}