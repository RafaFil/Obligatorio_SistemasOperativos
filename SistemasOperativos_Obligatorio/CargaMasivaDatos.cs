namespace SistemasOperativos_Obligatorio
{
    public static class CargaMasivaDatos{
    
        public static void CargarProcesos(string ruta){
            string[] lineas = ManejadorArchivos.Leer(ruta);
            foreach(string linea in lineas){
                string[] datos = linea.Split(',');
                if(datos.Length == 5){
                    string nombre = datos[0];
                    int duracionCPU = int.Parse(datos[1]);
                    int duracionES = int.Parse(datos[2]);
                    int intervaloEs = int.Parse(datos[3]);
                    bool esDeSo = bool.Parse(datos[4]);
                    PlantillaProceso plantilla = new PlantillaProceso(nombre, duracionCPU, duracionES, intervaloEs, esDeSo);
                    Proceso proceso = new Proceso(plantilla);
                    //Agregar a la cola de procesos (ver q pasa aca)
                }
            }
        }
        
    }
}