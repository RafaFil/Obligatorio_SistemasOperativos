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
    public partial class FrmCrearPlantilla : Form
    {
        public PlantillaProceso? plantillaCreada;

        public FrmCrearPlantilla()
        {
            InitializeComponent();

            plantillaCreada = null;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Datos inválidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            plantillaCreada = new PlantillaProceso(txtNombre.Text, (int) numDuracionCPU.Value,
                (int) numDuracionES.Value, (int) numIntervaloES.Value, chkEsDeSO.Checked);

            MessageBox.Show("Plantilla creada exitosamente.", "Creada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void numDuracionCPU_ValueChanged(object sender, EventArgs e)
        {
            numIntervaloES.Maximum = numDuracionCPU.Value;
        }
    }
}
