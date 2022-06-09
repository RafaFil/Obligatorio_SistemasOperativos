namespace SistemasOperativos_Obligatorio
{
    partial class FrmCrearPlantilla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkUsarBase = new System.Windows.Forms.CheckBox();
            this.cbxPlantillasCreadas = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numDuracionCPU = new System.Windows.Forms.NumericUpDown();
            this.numIntervaloES = new System.Windows.Forms.NumericUpDown();
            this.numDuracionES = new System.Windows.Forms.NumericUpDown();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDuracionCPU = new System.Windows.Forms.Label();
            this.lblDuracionES = new System.Windows.Forms.Label();
            this.lblIntervaloES = new System.Windows.Forms.Label();
            this.chkEsDeSO = new System.Windows.Forms.CheckBox();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervaloES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionES)).BeginInit();
            this.SuspendLayout();
            // 
            // chkUsarBase
            // 
            this.chkUsarBase.AutoSize = true;
            this.chkUsarBase.Location = new System.Drawing.Point(15, 16);
            this.chkUsarBase.Name = "chkUsarBase";
            this.chkUsarBase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkUsarBase.Size = new System.Drawing.Size(179, 19);
            this.chkUsarBase.TabIndex = 0;
            this.chkUsarBase.Text = "Usar otra plantilla como base";
            this.chkUsarBase.UseVisualStyleBackColor = true;
            // 
            // cbxPlantillasCreadas
            // 
            this.cbxPlantillasCreadas.Enabled = false;
            this.cbxPlantillasCreadas.FormattingEnabled = true;
            this.cbxPlantillasCreadas.Location = new System.Drawing.Point(267, 12);
            this.cbxPlantillasCreadas.Name = "cbxPlantillasCreadas";
            this.cbxPlantillasCreadas.Size = new System.Drawing.Size(190, 23);
            this.cbxPlantillasCreadas.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(445, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // numDuracionCPU
            // 
            this.numDuracionCPU.Location = new System.Drawing.Point(12, 151);
            this.numDuracionCPU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuracionCPU.Name = "numDuracionCPU";
            this.numDuracionCPU.Size = new System.Drawing.Size(110, 23);
            this.numDuracionCPU.TabIndex = 3;
            this.numDuracionCPU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuracionCPU.ValueChanged += new System.EventHandler(this.numDuracionCPU_ValueChanged);
            // 
            // numIntervaloES
            // 
            this.numIntervaloES.Enabled = false;
            this.numIntervaloES.Location = new System.Drawing.Point(337, 151);
            this.numIntervaloES.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIntervaloES.Name = "numIntervaloES";
            this.numIntervaloES.Size = new System.Drawing.Size(120, 23);
            this.numIntervaloES.TabIndex = 4;
            this.numIntervaloES.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDuracionES
            // 
            this.numDuracionES.Location = new System.Drawing.Point(172, 151);
            this.numDuracionES.Name = "numDuracionES";
            this.numDuracionES.Size = new System.Drawing.Size(121, 23);
            this.numDuracionES.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDuracionCPU
            // 
            this.lblDuracionCPU.AutoSize = true;
            this.lblDuracionCPU.Location = new System.Drawing.Point(12, 133);
            this.lblDuracionCPU.Name = "lblDuracionCPU";
            this.lblDuracionCPU.Size = new System.Drawing.Size(97, 15);
            this.lblDuracionCPU.TabIndex = 7;
            this.lblDuracionCPU.Text = "Duración en CPU";
            // 
            // lblDuracionES
            // 
            this.lblDuracionES.AutoSize = true;
            this.lblDuracionES.Location = new System.Drawing.Point(172, 133);
            this.lblDuracionES.Name = "lblDuracionES";
            this.lblDuracionES.Size = new System.Drawing.Size(91, 15);
            this.lblDuracionES.TabIndex = 8;
            this.lblDuracionES.Text = "Duración de E/S";
            // 
            // lblIntervaloES
            // 
            this.lblIntervaloES.AutoSize = true;
            this.lblIntervaloES.Location = new System.Drawing.Point(337, 133);
            this.lblIntervaloES.Name = "lblIntervaloES";
            this.lblIntervaloES.Size = new System.Drawing.Size(103, 15);
            this.lblIntervaloES.TabIndex = 9;
            this.lblIntervaloES.Text = "Intervalo entre E/S";
            // 
            // chkEsDeSO
            // 
            this.chkEsDeSO.AutoSize = true;
            this.chkEsDeSO.Location = new System.Drawing.Point(12, 199);
            this.chkEsDeSO.Name = "chkEsDeSO";
            this.chkEsDeSO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkEsDeSO.Size = new System.Drawing.Size(197, 19);
            this.chkEsDeSO.TabIndex = 10;
            this.chkEsDeSO.Text = "Es proceso del sistema operativo";
            this.chkEsDeSO.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCrear.Location = new System.Drawing.Point(357, 228);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 33);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FrmCrearPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 273);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.chkEsDeSO);
            this.Controls.Add(this.lblIntervaloES);
            this.Controls.Add(this.lblDuracionES);
            this.Controls.Add(this.lblDuracionCPU);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.numDuracionES);
            this.Controls.Add(this.numIntervaloES);
            this.Controls.Add(this.numDuracionCPU);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbxPlantillasCreadas);
            this.Controls.Add(this.chkUsarBase);
            this.Name = "FrmCrearPlantilla";
            this.Text = "Crear plantilla de proceso";
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervaloES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUsarBase;
        private System.Windows.Forms.ComboBox cbxPlantillasCreadas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown numDuracionCPU;
        private System.Windows.Forms.NumericUpDown numIntervaloES;
        private System.Windows.Forms.NumericUpDown numDuracionES;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDuracionCPU;
        private System.Windows.Forms.Label lblDuracionES;
        private System.Windows.Forms.Label lblIntervaloES;
        private System.Windows.Forms.CheckBox chkEsDeSO;
        private System.Windows.Forms.Button btnCrear;
    }
}