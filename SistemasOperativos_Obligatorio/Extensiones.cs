using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensiones
{
    public static class Extensiones
    {
        public static TimeSpan Mod(this TimeSpan a, TimeSpan b)
        {
            return TimeSpan.FromTicks(a.Ticks % b.Ticks);
        }

        /// <summary>
        /// Devuelve la parte entera de un número en punto flotante.
        /// </summary>
        /// <param name="a"></param>
        /// <returns>la parte entera del número</returns>
        public static int ParteEntera(this double a)
        {
            return (int) a;
        }

        /// <summary>
        /// Devuelve la parte decimal de un número en punto flotante.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="desplazamiento">la cantidad de puntos a desplazar la coma decimal</param>
        /// <returns>la parte decimal del número</returns>
        public static int ParteDecimal(this double a, int desplazamiento)
        {
            return (int)((a - a.ParteEntera()) * Math.Pow(10, desplazamiento));
        }
    }
}
