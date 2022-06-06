using System;

namespace SistemasOperativos_Obligatorio
{
	public class CPU{
		private int id;
		private int velocidad;
		private bool procesosActivo;

		public CPU(string id){
			this.id = id;
			this.procesoActivo = false;
			this.velocidad = 1;
        }

		public stirng Id{
            get{
				return this.id;
            }
        }
		
		public bool ProcesoActivo{
            get{
				return this.ProcesoActivo;
            }
            set{
				this.ProcesoActivo = value;
            }
        }

	}
}
