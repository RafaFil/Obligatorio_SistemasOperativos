using System;

namespace SistemasOperativos_Obligatorio
{
	public class CPU{
		private int id;
		private static int ProxId = 0;
		private IPlanificador planificador;
        private Proceso? procesoActivo;

        /// <summary>
        /// El proceso que se está ejecutando actualmente en este CPU.
        /// </summary>
		public Proceso? ProcesoActivo
        {
            get
            {
                return procesoActivo;
            }
            set
            {
                if (value != null)
                {
                    value.Cpu = this;
                }
                procesoActivo = value;
            }
        }

        /// <summary>
        /// Velocidad relativa de este CPU.
        /// </summary>
		public double Velocidad { get; set; }

        /// <summary>
        /// Crea un nuevo CPU sin proceso asignado y la velocidad relativa indicada.
        /// </summary>
        /// <param name="velocidad"></param>
		public CPU(double velocidad)
		{
			this.id = CPU.ProxId;
			CPU.ProxId++;
			this.ProcesoActivo = null;
			this.Velocidad = velocidad;
        }

        /// <summary>
        /// Identificador único del CPU.
        /// </summary>
		public int Id{
            get{
				return this.id;
            }
        }

        /// <summary>
        /// Devuelve una representación textual de este CPU.
        /// </summary>
        /// <returns>la representación textyal de este CPU</returns>
        public override string ToString()
        {
            return $"CPU {Id} @ {Velocidad * 100}%";
        }
    }
}
