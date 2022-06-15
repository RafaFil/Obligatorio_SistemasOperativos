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
    public partial class FrmInicio : Form
    {
        private const int MAXIMO_CPUS = 8;

        private List<PlantillaProceso> plantillasProcesosDisponibles;
        private List<Proceso> procesosIngresados;
        private List<CPU> cpusDisponibles;

        public FrmInicio()
        {
            InitializeComponent();

            plantillasProcesosDisponibles = new List<PlantillaProceso>();
            procesosIngresados = new List<Proceso>();
            cpusDisponibles = new List<CPU>();
            txtPrioridadProceso.Text = tckPrioridadProceso.Value.ToString();
            txtVelocidadCPU.Text = VelocidadTrackBarToString(tckVelocidadCPU.Value);
            numCantidadCPUs.Maximum = MAXIMO_CPUS;
        }

        private string VelocidadTrackBarToString(int velocidad)
        {
            return (100 + velocidad).ToString() + "%";
        }

        private string VelocidadDoubleToString(double velocidad)
        {
            return (velocidad * 100).ToString() + "%";
        }

        private void btnCrearPlantilla_Click(object sender, EventArgs e)
        {
            FrmCrearPlantilla frm = new FrmCrearPlantilla(plantillasProcesosDisponibles);
            frm.ShowDialog();
            if (frm.plantillaCreada != null)
            {
                plantillasProcesosDisponibles.Add(frm.plantillaCreada);
                actualizarPlantillasDisponibles();
                cbxPlantillaProceso.SelectedItem = frm.plantillaCreada;
            }
            else
            {
                MessageBox.Show("No se creó ninguna plantilla.", "Sin cambios",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void actualizarPlantillasDisponibles()
        {
            cbxPlantillaProceso.Items.Clear();
            plantillasProcesosDisponibles.Sort((a, b) => a.nombre.CompareTo(b.nombre));
            cbxPlantillaProceso.Items.AddRange(plantillasProcesosDisponibles.ToArray());
        }

        private void actualizarProcesosIngresados()
        {
            grdProcesos.Rows.Clear();
            procesosIngresados.ForEach(p => grdProcesos.Rows.Add(p.id, p.nombre,
                p.duracionCPU, p.duracionEs, p.intervaloES, p.prioridad, p.esDeSo));
            btnIniciarSimulacion.Enabled = cpusDisponibles.Count > 0 && procesosIngresados.Count > 0;
            grdProcesos.ClearSelection();
        }

        private void actualizarCPUsDisponibles()
        {
            grdCPUs.Rows.Clear();
            cpusDisponibles.ForEach(c => grdCPUs.Rows.Add(c.Id, VelocidadDoubleToString(c.Velocidad)));
            btnIniciarSimulacion.Enabled = cpusDisponibles.Count > 0 && procesosIngresados.Count > 0;
            grdCPUs.ClearSelection();
        }

        private void btnCargaMasivaProcesos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            string ruta = openFileDialog1.FileName;
            procesosIngresados.AddRange(CargaMasivaDatos.CargarProcesos(ruta));
            MessageBox.Show(ruta);
            actualizarProcesosIngresados();
        }

        private void btnAgregarProceso_Click(object sender, EventArgs e)
        {
            PlantillaProceso plantilla = (PlantillaProceso) cbxPlantillaProceso.SelectedItem;
            for (int i = 0; i < numCantidadProcesos.Value; i++)
            {
                Proceso proceso = new Proceso(plantilla);
                proceso.Prioridad = tckPrioridadProceso.Value;
                procesosIngresados.Add(proceso);
            }
            actualizarProcesosIngresados();
        }

        private void tckPrioridadProceso_ValueChanged(object sender, EventArgs e)
        {
            txtPrioridadProceso.Text = tckPrioridadProceso.Value.ToString();
        }

        private void cbxPlantillaProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAgregarProceso.Enabled = cbxPlantillaProceso.SelectedIndex != -1;
        }

        private void tckVelocidadCPU_ValueChanged(object sender, EventArgs e)
        {
            txtVelocidadCPU.Text = VelocidadTrackBarToString(tckVelocidadCPU.Value);
        }

        private void btnAgregarCPU_Click(object sender, EventArgs e)
        {
            double velocidad = 1 + ((double)tckVelocidadCPU.Value) / 100;
            for (int i = 0; i < numCantidadCPUs.Value; i++)
            {
                cpusDisponibles.Add(new CPU(velocidad));
            }
            actualizarCPUsDisponibles();

            numCantidadCPUs.Maximum = Math.Max(MAXIMO_CPUS - cpusDisponibles.Count, 1);
            btnAgregarCPU.Enabled = MAXIMO_CPUS > cpusDisponibles.Count;
        }

        private void btnLimpiarSimulacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar todos los procesos y CPUs ingresados?", "Confirmación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                LimpiarSimulacion();
            } 
        }

        private void LimpiarSimulacion()
        {
            procesosIngresados.Clear();
            cpusDisponibles.Clear();
            actualizarProcesosIngresados();
            actualizarCPUsDisponibles();
        }

        private void btnIniciarSimulacion_Click(object sender, EventArgs e)
        {
            FrmSimulacion frm = new FrmSimulacion(procesosIngresados, cpusDisponibles);
            frm.ShowDialog();
            LimpiarSimulacion();
        }
    }
}
