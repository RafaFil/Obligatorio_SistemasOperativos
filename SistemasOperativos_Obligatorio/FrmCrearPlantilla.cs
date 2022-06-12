﻿using System;
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

        public FrmCrearPlantilla(List<PlantillaProceso> plantillas)
        {
            InitializeComponent();

            plantillaCreada = null;
            cbxPlantillasCreadas.Items.AddRange(plantillas.ToArray());
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Datos inválidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numIntervaloES.Enabled && numIntervaloES.Value > numDuracionCPU.Value)
            {
                MessageBox.Show("El intervalo entre operaciones E/S es mayor que el tiempo que "
                    + "el proceso ocupará el CPU. Deshabilite las operaciones E/S reduciendo su "
                    + "duración a 0, o incremente la duración de CPU", "Datos inválidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            plantillaCreada = new PlantillaProceso(txtNombre.Text,
                (int) numDuracionCPU.Value,
                (int) numDuracionES.Value,
                numIntervaloES.Enabled ? (int)numIntervaloES.Value : 0,
                chkEsDeSO.Checked);

            MessageBox.Show("Plantilla creada exitosamente.", "Creada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void numDuracionCPU_ValueChanged(object sender, EventArgs e)
        {
            numIntervaloES.Maximum = numDuracionCPU.Value;
        }

        private void chkUsarBase_CheckedChanged(object sender, EventArgs e)
        {
            cbxPlantillasCreadas.Enabled = chkUsarBase.Checked;
        }

        private void cbxPlantillasCreadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlantillaProceso pp = (PlantillaProceso) cbxPlantillasCreadas.SelectedItem;
            txtNombre.Text = pp.nombre;
            numDuracionCPU.Value = pp.duracionCPU;
            numDuracionES.Value = pp.duracionES;
            numIntervaloES.Value = pp.intervaloEs;
            chkEsDeSO.Checked = pp.esDeSo;
        }

        private void numDuracionES_ValueChanged(object sender, EventArgs e)
        {
            numIntervaloES.Enabled = numDuracionES.Value > 0;
        }
    }
}
