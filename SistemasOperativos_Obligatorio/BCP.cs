using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasOperativos_Obligatorio
{
    public class BCP
    {
        /// <summary>
        /// Proceso asociado a este BCP
        /// </summary>
        public Proceso Proceso { get; set; }

        /// <summary>
        /// Incremento de prioridad que aumenta cuanto más tiempo permanece el proceso sin CPU asignado
        /// </summary>
        public int Envejecimiento { get; set; }

        /// <summary>
        /// Tiempo restante por el cual el proceso puede utilizar un CPU
        /// </summary>
        public TimeSpan Quantum { get; set; }

        /// <summary>
        /// Tiempo hasta la siguiente operación E/S de este proceso
        /// </summary>
        public TimeSpan DuracionESRestante
        {
            get => Proceso.duracionEs - Proceso.tiempoESTranscurrido;
        }

        /// <summary>
        /// Estado del proceso asociado
        /// </summary>
        public Proceso.Estado Estado
        {
            get => Proceso.estado;
            set => Proceso.estado = value;
        }

        /// <summary>
        /// Prioridad base de este proceso
        /// </summary>
        public int Prioridad
        {
            get => Proceso.Prioridad;
        }

        /// <summary>
        /// Porcentaje de procesamiento completado.
        /// </summary>
        public int PorcentajeCompletado
        {
            get => Proceso.PorcentajeCPUCompletado;
        }

        /// <summary>
        /// Crea un BCP asociado a un proceso, con los datos necesarios para gestionarlo
        /// </summary>
        /// <param name="p">el proceso que se asocia al BCP creado</param>
        public BCP(Proceso p)
        {
            this.Proceso = p;
            Envejecimiento = 0;
            Quantum = TimeSpan.Zero;
            Estado = Proceso.Estado.listo;
        }
    }
}
