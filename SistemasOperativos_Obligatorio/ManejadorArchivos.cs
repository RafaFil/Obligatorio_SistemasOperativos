using System.IO;

namespace SistemasOperativos_Obligatorio
{
    public static class ManejadorArchivos
    {
        public static string[] Leer(string ruta)
        {
            return File.ReadAllText(ruta).Split('\n');
        }
    }
}