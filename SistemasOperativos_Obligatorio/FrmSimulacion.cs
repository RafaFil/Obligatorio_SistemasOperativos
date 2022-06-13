using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasOperativos_Obligatorio
{
    public partial class FrmSimulacion : Form, IObservador<Planificador.Estado>
    {
        private IPlanificador planificador;

        public FrmSimulacion(List<Proceso> procesos, List<CPU> cpus)
        {
            InitializeComponent();

            planificador = new Planificador(procesos, cpus, 0.1);

            foreach (CPU cpu in cpus)
            {
                cpu.ProcesoActivo = planificador.EjecutarSiguiente();
                grdProcesadores.Columns.Add(new DataGridViewTextBoxColumn());
            }

            grdProcesadores.Rows.Add(3);
        }

        private void FrmSimulacion_Shown(object sender, EventArgs e)
        {
            grdProcesadores.ClearSelection();
        }

        public void Notificar(Planificador.Estado estado)
        {
            ActualizarEstado(estado);
        }

        public void ActualizarEstado(Planificador.Estado estado)
        {
            List<CPU> cpus = estado.cpus;
            List<Proceso> procesos = estado.colaDeProcesos;
            for (int i = 0; i < cpus.Count; i++)
            {
                Color colorEstadoCPU = cpus[i].ProcesoActivo != null ? Color.Green : Color.Orange;
                grdProcesadores.Rows[0].Cells[i].Style.BackColor = colorEstadoCPU;
                grdProcesadores.Rows[1].Cells[i].Value = cpus[i];
                grdProcesadores.Rows[2].Cells[i].Value = cpus[i].ProcesoActivo;
            }

            for (int i = 0; i < procesos.Count; i++)
            {
                Proceso p = procesos[i];
                grdProcesosListos.Rows.Add(p.id, p.nombre, p.prioridad, p.duracionCPU, p.duracionEs,
                    p.intervaloES, p.PorcentajeCompletado + "%");

                Color colorEstadoProceso;
                switch (p.estado)
                {
                    case Proceso.Estado.enEjecucion:
                        colorEstadoProceso = Color.Yellow;
                        break;
                    case Proceso.Estado.listo:
                        colorEstadoProceso = Color.Orange;
                        break;
                    default:
                        colorEstadoProceso = Color.Green;
                        break;
                }
                grdProcesosListos.Rows[i].Cells[colEstadoProcesoListo.Name].Style.BackColor = colorEstadoProceso;
            }
        }
    }
}
