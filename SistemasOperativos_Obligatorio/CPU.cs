using System;

namespace SistemasOperativos_Obligatorio
{
	public class CPU{
		private int id;
		private static int ProxId = 0;
		private IPlanificador planificador;
        private Proceso? procesoActivo;

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
		public double Velocidad { get; set; }

		public CPU(double velocidad)
		{
			this.id = CPU.ProxId;
			CPU.ProxId++;
			this.ProcesoActivo = null;
			this.Velocidad = velocidad;
        }

		public int Id{
            get{
				return this.id;
            }
        }

        public override string ToString()
        {
            return $"CPU {Id} @ {Velocidad * 100}%";
        }
    }
}
