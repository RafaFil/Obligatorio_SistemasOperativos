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

            planificador = new PlanificadorRoundRobin(procesos, cpus, 0.1);
            planificador.PausadoChanged += Planificador_PausadoChanged;
            foreach (CPU cpu in cpus)
            {
                grdProcesadores.Columns.Add(new DataGridViewTextBoxColumn());
            }
            grdProcesadores.Rows.Add(3);
        }

        private void FrmSimulacion_Load(object sender, EventArgs e)
        {
            planificador.Pausado = false;
            planificador.VerComoMueveLaCola(this);
        }

        private void Planificador_PausadoChanged(object sender, EventArgs e)
        {
            btnReanudar.Enabled = planificador.Pausado;
            btnDetener.Enabled = !planificador.Pausado;
            Text = $"Simulación ({(planificador.Pausado ? "En pausa" : "Corriendo")})";
            habilitarBtnBloquear();
            habilitarBtnDesbloquear();
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
            IOrderedEnumerable<Proceso> listos = estado.listos;
            IOrderedEnumerable<Proceso> bloqueados = estado.bloqueados;
            IOrderedEnumerable<Proceso> finalizados = estado.finalizados;
            List<Proceso> bloqueadosPorUsuario = estado.bloqueadosPorUsuario;

            for (int i = 0; i < cpus.Count; i++)
            {
                Color colorEstadoCPU = cpus[i].ProcesoActivo != null ? Color.Green : Color.Orange;
                grdProcesadores.Rows[0].Cells[i].Style.BackColor = colorEstadoCPU;
                grdProcesadores.Rows[1].Cells[i].Value = cpus[i];
                grdProcesadores.Rows[2].Cells[i].Value = cpus[i].ProcesoActivo;
            }

            grdProcesosListos.Invoke(
                (IOrderedEnumerable<Proceso> listos,
                IOrderedEnumerable<Proceso> finalizados, List<CPU> cpus) =>
                {
                    grdProcesosListos.Rows.Clear();

                    cpus.ForEach(cpu =>
                    {
                        if (cpu.ProcesoActivo != null)
                        {
                            Proceso p = cpu.ProcesoActivo;
                            var fila = new DataGridViewRow() { Tag = p };
                            fila.CreateCells(grdProcesosListos, p.id, p.esDeSo,
                                p.nombre, p.prioridad, p.duracionCPU, p.duracionEs, p.intervaloES,
                                p.PorcentajeCPUCompletado + "%");
                            grdProcesosListos.Rows.Add(fila);

                            grdProcesosListos.Rows[^1].Cells[colEstadoProcesoListo.Name]
                                .Style.BackColor = Color.Yellow;
                        }
                    });

                    listos.ToList().ForEach(p =>
                    {
                        var fila = new DataGridViewRow() { Tag = p };
                        fila.CreateCells(grdProcesosListos, p.id, p.esDeSo,
                            p.nombre, p.prioridad, p.duracionCPU, p.duracionEs, p.intervaloES,
                            p.PorcentajeCPUCompletado + "%");
                        grdProcesosListos.Rows.Add(fila);

                        grdProcesosListos.Rows[^1].Cells[colEstadoProcesoListo.Name]
                            .Style.BackColor = Color.Orange;
                    });

                    finalizados.ToList().ForEach(p =>
                    {
                        var fila = new DataGridViewRow() { Tag = p };
                        fila.CreateCells(grdProcesosListos, p.id, p.esDeSo,
                            p.nombre, p.prioridad, p.duracionCPU, p.duracionEs, p.intervaloES,
                            p.PorcentajeCPUCompletado + "%");
                        grdProcesosListos.Rows.Add(fila);

                        grdProcesosListos.Rows[^1].Cells[colEstadoProcesoListo.Name]
                            .Style.BackColor = Color.Green;
                    });


                    grdProcesosListos.ClearSelection();
                }, listos, finalizados, cpus);

            grdProcesosBloqueados.Invoke((IOrderedEnumerable<Proceso> bloqueados,
                List<Proceso> bloqueadosPorUsuario) =>
            {
                grdProcesosBloqueados.Rows.Clear();
                bloqueadosPorUsuario.ForEach(p =>
                {
                    var fila = new DataGridViewRow() { Tag = p };
                    fila.CreateCells(grdProcesosBloqueados, "#" + p.id, p.nombre, "Usuario",
                        p.PorcentajeESCompletado + "%");
                    grdProcesosBloqueados.Rows.Add(fila);
                });

                bloqueados.ToList().ForEach(p =>
                {
                    grdProcesosBloqueados.Rows.Add("#" + p.id, p.nombre, "E/S",
                        p.PorcentajeESCompletado + "%");

                    grdProcesosBloqueados.Rows[^1].Tag = p;
                });

                grdProcesosBloqueados.ClearSelection();
            }, bloqueados, bloqueadosPorUsuario);
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            planificador.Pausado = false;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            planificador.Pausado = true;
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            Proceso p = (Proceso) grdProcesosListos.SelectedRows[0].Tag!;
            planificador.BloquearProceso(p);
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            Proceso p = (Proceso) grdProcesosBloqueados.SelectedRows[0].Tag!;
            planificador.DesbloquearProceso(p);
        }

        private void habilitarBtnBloquear()
        {
            btnBloquear.Enabled = planificador.Pausado
                && grdProcesosListos.SelectedRows.Count == 1
                && ((Proceso)grdProcesosListos.SelectedRows[0].Tag!).estado != Proceso.Estado.finalizado;
        }

        private void habilitarBtnDesbloquear()
        {
            btnDesbloquear.Enabled = planificador.Pausado
                && grdProcesosBloqueados.SelectedRows.Count == 1
                && ((Proceso)grdProcesosBloqueados.SelectedRows[0].Tag!).estado == Proceso.Estado.bloqueadoPorUsuario;
        }

        private void grdProcesosListos_SelectionChanged(object sender, EventArgs e)
        {
            habilitarBtnBloquear();
        }

        private void grdProcesosBloqueados_SelectionChanged(object sender, EventArgs e)
        {
            habilitarBtnDesbloquear();
        }
    }
}
