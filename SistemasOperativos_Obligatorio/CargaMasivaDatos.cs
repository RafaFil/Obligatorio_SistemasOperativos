using System.Collections.Generic;

namespace SistemasOperativos_Obligatorio
{
    public static class CargaMasivaDatos{

    
        public static List<Proceso> CargarProcesos(string ruta){
            List<Proceso> lista = new List<Proceso>();
            string[] lineas = ManejadorArchivos.Leer(ruta);
            int duracionCPU;
            int duracionES;
            int intervaloEs;
            bool esDeSo;
            foreach (string linea in lineas){
                string[] datos = linea.Split(',');
                if(datos.Length == 5 && int.TryParse(datos[1],out duracionCPU) 
                    && int.TryParse(datos[2], out duracionES) && 
                    int.TryParse(datos[3], out intervaloEs) && bool.TryParse(datos[4], out esDeSo))
                {
                    string nombre = datos[0];
                    PlantillaProceso plantilla = new PlantillaProceso(nombre, duracionCPU, duracionES, intervaloEs, esDeSo);
                    Proceso proceso = new Proceso(plantilla);
                    lista.Add(proceso);
                }
            }
            return lista;
        }
        
    }
}