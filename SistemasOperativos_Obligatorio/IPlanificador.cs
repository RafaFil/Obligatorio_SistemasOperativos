using System.Collections.Generic;

namespace SistemasOperativos_Obligatorio
{
    public interface IPlanificador{
        Proceso? EjecutarSiguiente();
        double ObtenerTiempoMaximoEnCPU();
    }
}