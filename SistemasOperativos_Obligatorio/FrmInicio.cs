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
            numCantidadProcesos.Value = 1;
        }

        private void btnCrearPlantilla_Click(object sender, EventArgs e)
        {
            FrmCrearPlantilla frm = new FrmCrearPlantilla();
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
        }

        private void btnCargaMasivaProcesos_Click(object sender, EventArgs e)
        {
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
    }
}
