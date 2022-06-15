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
    public partial class FrmSimulacion : Form, IObservador<PlanificadorBase.Estado>
    {
        private IPlanificador planificador;

        public FrmSimulacion(List<Proceso> procesos, List<CPU> cpus)
        {
            InitializeComponent();

            planificador = new PlanificadorRoundRobin(procesos, cpus, 5);
            foreach (CPU cpu in cpus)
            {
                grdProcesadores.Columns.Add(new DataGridViewTextBoxColumn());
            }
            grdProcesadores.Rows.Add(3);
        }

        private void FrmSimulacion_Load(object sender, EventArgs e)
        {
            planificador.Iniciar();
            planificador.VerComoMueveLaCola(this);
        }

        private void FrmSimulacion_Shown(object sender, EventArgs e)
        {
            grdProcesadores.ClearSelection();
        }

        public void Notificar(PlanificadorBase.Estado estado)
        {
            ActualizarEstado(estado);
        }

        public void ActualizarEstado(PlanificadorBase.Estado estado)
        {
            List<CPU> cpus = estado.cpus;
            IOrderedEnumerable<Proceso> procesos = estado.colaDeProcesos;
            IOrderedEnumerable<Proceso> bloqueados = estado.procesosBloqueados;
            for (int i = 0; i < cpus.Count; i++)
            {
                Color colorEstadoCPU = cpus[i].ProcesoActivo != null ? Color.Green : Color.Orange;
                grdProcesadores.Rows[0].Cells[i].Style.BackColor = colorEstadoCPU;
                grdProcesadores.Rows[1].Cells[i].Value = cpus[i];
                grdProcesadores.Rows[2].Cells[i].Value = cpus[i].ProcesoActivo;
            }

            grdProcesosListos.Invoke(
                (IOrderedEnumerable<Proceso> procesos, IOrderedEnumerable<Proceso> bloqueados) =>
                {
                    grdProcesosListos.Rows.Clear();
                    procesos.Reverse().ToList().ForEach(p =>
                    {
                        grdProcesosListos.Rows.Add(p.id, p.nombre, p.prioridad, p.duracionCPU,
                            p.duracionEs, p.intervaloES, p.PorcentajeCPUCompletado + "%");

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
                        grdProcesosListos.Rows[^1].Cells[colEstadoProcesoListo.Name]
                            .Style.BackColor = colorEstadoProceso;
                    });
                    grdProcesosListos.ClearSelection();

                    grdProcesosBloqueados.Rows.Clear();
                    bloqueados.Reverse().ToList().ForEach(p =>
                    {
                        grdProcesosBloqueados.Rows.Add("#" + p.id, p.nombre,
                            p.estado == Proceso.Estado.bloqueado ? "E/S" : "Usuario");
                    });
                    grdProcesosBloqueados.ClearSelection();
                }, procesos, bloqueados);
        }
    }
}
