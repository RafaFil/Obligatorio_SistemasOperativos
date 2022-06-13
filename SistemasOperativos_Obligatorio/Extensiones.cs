using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensiones
{
    public static class Extensiones
    {
        public static TimeSpan Modulo(this TimeSpan a, TimeSpan b)
        {
            return TimeSpan.FromTicks(a.Ticks % b.Ticks);
        }

        public static int ParteEntera(this double a)
        {
            return (int) a;
        }

        public static int ParteDecimal(this double a, int decimales)
        {
            return (int)(a - a.ParteEntera() * Math.Pow(10, decimales));
        }
    }
}
