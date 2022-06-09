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
    }
}
