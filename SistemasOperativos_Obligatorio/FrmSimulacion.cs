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
        private readonly TimeSpan intervaloActualizacion;
        private readonly TimeSpan tiempoMaximoCPU;
        private List<Proceso> procesos;
        private List<CPU> cpus;

        public FrmSimulacion(List<Proceso> procesos, List<CPU> cpus, TimeSpan tiempoMaximoCPU, TimeSpan intervaloActualizacion)
        {
            InitializeComponent();

            this.procesos = procesos;
            this.cpus = cpus;
            this.intervaloActualizacion = intervaloActualizacion;
            this.tiempoMaximoCPU = tiempoMaximoCPU;
            foreach (CPU cpu in cpus)
            {
                grdProcesadores.Columns.Add(new DataGridViewTextBoxColumn());
            }
            grdProcesadores.Rows.Add(3);
            grdProcesadores.Rows[0].Height = grdProcesadores.Height - grdProcesadores.Rows[0].Height * 2;
        }

        private void FrmSimulacion_Load(object sender, EventArgs e)
        {
            InicializarPlanificador();
        }

        private void InicializarPlanificador()
        {
            planificador = new PlanificadorRoundRobin(procesos, cpus, tiempoMaximoCPU, intervaloActualizacion);
            planificador.PausadoChanged += Planificador_PausadoChanged;
            planificador.VerComoMueveLaCola(this);
            planificador.Pausado = false;
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

            bool terminado = !cpus.Select(cpu => cpu.ProcesoActivo).Where(p => p != null)
                .Union(listos).Union(bloqueados).Union(bloqueadosPorUsuario).Any();
            btnDetener.Invoke((bool terminado) => btnDetener.Visible = !terminado, terminado);
            btnReanudar.Invoke((bool terminado) => btnReanudar.Visible = !terminado, terminado);
            btnReiniciar.Invoke((bool terminado) => btnReiniciar.Visible = terminado, terminado);

            for (int i = 0; i < cpus.Count; i++)
            {
                if (cpus[i].ProcesoActivo != null)
                {
                    grdProcesadores.Rows[0].Cells[i].Style.BackColor = Color.Green;
                    grdProcesadores.Rows[0].Cells[i].Value = "En uso";
                }
                else
                {
                    grdProcesadores.Rows[0].Cells[i].Style.BackColor = Color.Orange;
                    grdProcesadores.Rows[0].Cells[i].Value = "Inactivo";
                }
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
                                p.PorcentajeCPUCompletado + "%", "En ejecución");
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
                            p.PorcentajeCPUCompletado + "%", "Listo");
                        grdProcesosListos.Rows.Add(fila);

                        grdProcesosListos.Rows[^1].Cells[colEstadoProcesoListo.Name]
                            .Style.BackColor = Color.Orange;
                    });

                    finalizados.ToList().ForEach(p =>
                    {
                        var fila = new DataGridViewRow() { Tag = p };
                        fila.CreateCells(grdProcesosListos, p.id, p.esDeSo,
                            p.nombre, p.prioridad, p.duracionCPU, p.duracionEs, p.intervaloES,
                            p.PorcentajeCPUCompletado + "%", "Finalizado");
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

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            procesos.ForEach(p =>
            {
                p.estado = Proceso.Estado.listo;
                p.tiempoCPUTranscurrido = TimeSpan.Zero;
                p.tiempoESTranscurrido = TimeSpan.Zero;
            });
            InicializarPlanificador();
        }
    }
}
