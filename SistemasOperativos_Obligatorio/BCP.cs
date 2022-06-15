using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasOperativos_Obligatorio
{
    public class BCP
    {
        public Proceso Proceso { get; set; }
        public int Envejecimiento { get; set; }
        public TimeSpan Quantum { get; set; }
        public TimeSpan DuracionESRestante { get; set; }
        public Proceso.Estado Estado
        {
            get => Proceso.estado;
            set => Proceso.estado = value;
        }
        public int Prioridad
        {
            get => Proceso.Prioridad;
        }

        public int PorcentajeCompletado
        {
            get => Proceso.PorcentajeCompletado;
        }

        public BCP(Proceso p)
        {
            this.Proceso = p;
            Envejecimiento = 0;
            Quantum = TimeSpan.Zero;
            DuracionESRestante = TimeSpan.Zero;
            Estado = Proceso.Estado.listo;
        }
    }
}
