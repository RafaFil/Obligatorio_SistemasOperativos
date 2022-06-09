﻿namespace SistemasOperativos_Obligatorio
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAgregarProcesos = new System.Windows.Forms.GroupBox();
            this.txtPrioridadProceso = new System.Windows.Forms.TextBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.tckPrioridadProceso = new System.Windows.Forms.TrackBar();
            this.btnAgregarProceso = new System.Windows.Forms.Button();
            this.lblCantidadProcesos = new System.Windows.Forms.Label();
            this.btnCargaMasivaProcesos = new System.Windows.Forms.Button();
            this.lblPlantillaProceso = new System.Windows.Forms.Label();
            this.btnCrearPlantilla = new System.Windows.Forms.Button();
            this.numCantidadProcesos = new System.Windows.Forms.NumericUpDown();
            this.cbxPlantillaProceso = new System.Windows.Forms.ComboBox();
            this.grpCPUs = new System.Windows.Forms.GroupBox();
            this.btnAgregarCPU = new System.Windows.Forms.Button();
            this.txtVelocidadCPU = new System.Windows.Forms.TextBox();
            this.lblVelocidadCPU = new System.Windows.Forms.Label();
            this.lblCantidadCPUs = new System.Windows.Forms.Label();
            this.numCantidadCPUs = new System.Windows.Forms.NumericUpDown();
            this.tckVelocidadCPU = new System.Windows.Forms.TrackBar();
            this.btnIniciarSimulacion = new System.Windows.Forms.Button();
            this.btnLimpiarSimulacion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblProcesosIngresados = new System.Windows.Forms.Label();
            this.lblCPUsIngresados = new System.Windows.Forms.Label();
            this.grpAgregarProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckPrioridadProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadProcesos)).BeginInit();
            this.grpCPUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadCPUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckVelocidadCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgregarProcesos
            // 
            this.grpAgregarProcesos.Controls.Add(this.txtPrioridadProceso);
            this.grpAgregarProcesos.Controls.Add(this.lblPrioridad);
            this.grpAgregarProcesos.Controls.Add(this.tckPrioridadProceso);
            this.grpAgregarProcesos.Controls.Add(this.btnAgregarProceso);
            this.grpAgregarProcesos.Controls.Add(this.lblCantidadProcesos);
            this.grpAgregarProcesos.Controls.Add(this.btnCargaMasivaProcesos);
            this.grpAgregarProcesos.Controls.Add(this.lblPlantillaProceso);
            this.grpAgregarProcesos.Controls.Add(this.btnCrearPlantilla);
            this.grpAgregarProcesos.Controls.Add(this.numCantidadProcesos);
            this.grpAgregarProcesos.Controls.Add(this.cbxPlantillaProceso);
            this.grpAgregarProcesos.Location = new System.Drawing.Point(12, 12);
            this.grpAgregarProcesos.Name = "grpAgregarProcesos";
            this.grpAgregarProcesos.Size = new System.Drawing.Size(415, 162);
            this.grpAgregarProcesos.TabIndex = 0;
            this.grpAgregarProcesos.TabStop = false;
            this.grpAgregarProcesos.Text = "Agregar procesos";
            // 
            // txtPrioridadProceso
            // 
            this.txtPrioridadProceso.Location = new System.Drawing.Point(206, 84);
            this.txtPrioridadProceso.Name = "txtPrioridadProceso";
            this.txtPrioridadProceso.ReadOnly = true;
            this.txtPrioridadProceso.Size = new System.Drawing.Size(59, 23);
            this.txtPrioridadProceso.TabIndex = 7;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(128, 87);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(55, 15);
            this.lblPrioridad.TabIndex = 3;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // tckPrioridadProceso
            // 
            this.tckPrioridadProceso.Location = new System.Drawing.Point(128, 105);
            this.tckPrioridadProceso.Maximum = 100;
            this.tckPrioridadProceso.Minimum = 1;
            this.tckPrioridadProceso.Name = "tckPrioridadProceso";
            this.tckPrioridadProceso.Size = new System.Drawing.Size(136, 45);
            this.tckPrioridadProceso.TabIndex = 6;
            this.tckPrioridadProceso.TickFrequency = 10;
            this.tckPrioridadProceso.Value = 1;
            // 
            // btnAgregarProceso
            // 
            this.btnAgregarProceso.Location = new System.Drawing.Point(316, 127);
            this.btnAgregarProceso.Name = "btnAgregarProceso";
            this.btnAgregarProceso.Size = new System.Drawing.Size(92, 23);
            this.btnAgregarProceso.TabIndex = 5;
            this.btnAgregarProceso.Text = "Agregar";
            this.btnAgregarProceso.UseVisualStyleBackColor = true;
            // 
            // lblCantidadProcesos
            // 
            this.lblCantidadProcesos.AutoSize = true;
            this.lblCantidadProcesos.Location = new System.Drawing.Point(6, 87);
            this.lblCantidadProcesos.Name = "lblCantidadProcesos";
            this.lblCantidadProcesos.Size = new System.Drawing.Size(55, 15);
            this.lblCantidadProcesos.TabIndex = 2;
            this.lblCantidadProcesos.Text = "Cantidad";
            // 
            // btnCargaMasivaProcesos
            // 
            this.btnCargaMasivaProcesos.Location = new System.Drawing.Point(316, 48);
            this.btnCargaMasivaProcesos.Name = "btnCargaMasivaProcesos";
            this.btnCargaMasivaProcesos.Size = new System.Drawing.Size(92, 23);
            this.btnCargaMasivaProcesos.TabIndex = 4;
            this.btnCargaMasivaProcesos.Text = "Carga masiva";
            this.btnCargaMasivaProcesos.UseVisualStyleBackColor = true;
            // 
            // lblPlantillaProceso
            // 
            this.lblPlantillaProceso.AutoSize = true;
            this.lblPlantillaProceso.Location = new System.Drawing.Point(6, 27);
            this.lblPlantillaProceso.Name = "lblPlantillaProceso";
            this.lblPlantillaProceso.Size = new System.Drawing.Size(134, 15);
            this.lblPlantillaProceso.TabIndex = 1;
            this.lblPlantillaProceso.Text = "Seleccione una plantilla:";
            // 
            // btnCrearPlantilla
            // 
            this.btnCrearPlantilla.Location = new System.Drawing.Point(316, 19);
            this.btnCrearPlantilla.Name = "btnCrearPlantilla";
            this.btnCrearPlantilla.Size = new System.Drawing.Size(92, 23);
            this.btnCrearPlantilla.TabIndex = 3;
            this.btnCrearPlantilla.Text = "Crear plantilla";
            this.btnCrearPlantilla.UseVisualStyleBackColor = true;
            this.btnCrearPlantilla.Click += new System.EventHandler(this.btnCrearPlantilla_Click);
            // 
            // numCantidadProcesos
            // 
            this.numCantidadProcesos.Location = new System.Drawing.Point(6, 105);
            this.numCantidadProcesos.Name = "numCantidadProcesos";
            this.numCantidadProcesos.Size = new System.Drawing.Size(79, 23);
            this.numCantidadProcesos.TabIndex = 1;
            // 
            // cbxPlantillaProceso
            // 
            this.cbxPlantillaProceso.FormattingEnabled = true;
            this.cbxPlantillaProceso.Location = new System.Drawing.Point(6, 45);
            this.cbxPlantillaProceso.Name = "cbxPlantillaProceso";
            this.cbxPlantillaProceso.Size = new System.Drawing.Size(259, 23);
            this.cbxPlantillaProceso.TabIndex = 0;
            // 
            // grpCPUs
            // 
            this.grpCPUs.Controls.Add(this.btnAgregarCPU);
            this.grpCPUs.Controls.Add(this.txtVelocidadCPU);
            this.grpCPUs.Controls.Add(this.lblVelocidadCPU);
            this.grpCPUs.Controls.Add(this.lblCantidadCPUs);
            this.grpCPUs.Controls.Add(this.numCantidadCPUs);
            this.grpCPUs.Controls.Add(this.tckVelocidadCPU);
            this.grpCPUs.Location = new System.Drawing.Point(433, 12);
            this.grpCPUs.Name = "grpCPUs";
            this.grpCPUs.Size = new System.Drawing.Size(415, 162);
            this.grpCPUs.TabIndex = 1;
            this.grpCPUs.TabStop = false;
            this.grpCPUs.Text = "Agregar procesadores";
            // 
            // btnAgregarCPU
            // 
            this.btnAgregarCPU.Location = new System.Drawing.Point(317, 127);
            this.btnAgregarCPU.Name = "btnAgregarCPU";
            this.btnAgregarCPU.Size = new System.Drawing.Size(92, 23);
            this.btnAgregarCPU.TabIndex = 8;
            this.btnAgregarCPU.Text = "Agregar";
            this.btnAgregarCPU.UseVisualStyleBackColor = true;
            // 
            // txtVelocidadCPU
            // 
            this.txtVelocidadCPU.Location = new System.Drawing.Point(206, 27);
            this.txtVelocidadCPU.Name = "txtVelocidadCPU";
            this.txtVelocidadCPU.ReadOnly = true;
            this.txtVelocidadCPU.Size = new System.Drawing.Size(59, 23);
            this.txtVelocidadCPU.TabIndex = 8;
            // 
            // lblVelocidadCPU
            // 
            this.lblVelocidadCPU.AutoSize = true;
            this.lblVelocidadCPU.Location = new System.Drawing.Point(128, 30);
            this.lblVelocidadCPU.Name = "lblVelocidadCPU";
            this.lblVelocidadCPU.Size = new System.Drawing.Size(58, 15);
            this.lblVelocidadCPU.TabIndex = 8;
            this.lblVelocidadCPU.Text = "Velocidad";
            // 
            // lblCantidadCPUs
            // 
            this.lblCantidadCPUs.AutoSize = true;
            this.lblCantidadCPUs.Location = new System.Drawing.Point(6, 30);
            this.lblCantidadCPUs.Name = "lblCantidadCPUs";
            this.lblCantidadCPUs.Size = new System.Drawing.Size(55, 15);
            this.lblCantidadCPUs.TabIndex = 7;
            this.lblCantidadCPUs.Text = "Cantidad";
            // 
            // numCantidadCPUs
            // 
            this.numCantidadCPUs.Location = new System.Drawing.Point(6, 48);
            this.numCantidadCPUs.Name = "numCantidadCPUs";
            this.numCantidadCPUs.Size = new System.Drawing.Size(79, 23);
            this.numCantidadCPUs.TabIndex = 2;
            // 
            // tckVelocidadCPU
            // 
            this.tckVelocidadCPU.Location = new System.Drawing.Point(128, 48);
            this.tckVelocidadCPU.Maximum = 100;
            this.tckVelocidadCPU.Name = "tckVelocidadCPU";
            this.tckVelocidadCPU.Size = new System.Drawing.Size(136, 45);
            this.tckVelocidadCPU.TabIndex = 0;
            this.tckVelocidadCPU.TickFrequency = 10;
            // 
            // btnIniciarSimulacion
            // 
            this.btnIniciarSimulacion.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIniciarSimulacion.Location = new System.Drawing.Point(748, 459);
            this.btnIniciarSimulacion.Name = "btnIniciarSimulacion";
            this.btnIniciarSimulacion.Size = new System.Drawing.Size(100, 33);
            this.btnIniciarSimulacion.TabIndex = 2;
            this.btnIniciarSimulacion.Text = "Iniciar";
            this.btnIniciarSimulacion.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarSimulacion
            // 
            this.btnLimpiarSimulacion.BackColor = System.Drawing.Color.LightCoral;
            this.btnLimpiarSimulacion.Location = new System.Drawing.Point(639, 459);
            this.btnLimpiarSimulacion.Name = "btnLimpiarSimulacion";
            this.btnLimpiarSimulacion.Size = new System.Drawing.Size(100, 33);
            this.btnLimpiarSimulacion.TabIndex = 3;
            this.btnLimpiarSimulacion.Text = "Limpiar";
            this.btnLimpiarSimulacion.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(607, 285);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(639, 207);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(209, 223);
            this.dataGridView2.TabIndex = 5;
            // 
            // lblProcesosIngresados
            // 
            this.lblProcesosIngresados.AutoSize = true;
            this.lblProcesosIngresados.Location = new System.Drawing.Point(12, 189);
            this.lblProcesosIngresados.Name = "lblProcesosIngresados";
            this.lblProcesosIngresados.Size = new System.Drawing.Size(117, 15);
            this.lblProcesosIngresados.TabIndex = 6;
            this.lblProcesosIngresados.Text = "Procesos ingresados:";
            // 
            // lblCPUsIngresados
            // 
            this.lblCPUsIngresados.AutoSize = true;
            this.lblCPUsIngresados.Location = new System.Drawing.Point(639, 189);
            this.lblCPUsIngresados.Name = "lblCPUsIngresados";
            this.lblCPUsIngresados.Size = new System.Drawing.Size(98, 15);
            this.lblCPUsIngresados.TabIndex = 7;
            this.lblCPUsIngresados.Text = "CPUs ingresados:";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 504);
            this.Controls.Add(this.lblCPUsIngresados);
            this.Controls.Add(this.lblProcesosIngresados);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiarSimulacion);
            this.Controls.Add(this.btnIniciarSimulacion);
            this.Controls.Add(this.grpCPUs);
            this.Controls.Add(this.grpAgregarProcesos);
            this.Name = "FrmInicio";
            this.Text = "Configuración de simulación";
            this.grpAgregarProcesos.ResumeLayout(false);
            this.grpAgregarProcesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckPrioridadProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadProcesos)).EndInit();
            this.grpCPUs.ResumeLayout(false);
            this.grpCPUs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadCPUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckVelocidadCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgregarProcesos;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.TrackBar tckPrioridadProceso;
        private System.Windows.Forms.Button btnAgregarProceso;
        private System.Windows.Forms.Label lblCantidadProcesos;
        private System.Windows.Forms.Button btnCargaMasivaProcesos;
        private System.Windows.Forms.Label lblPlantillaProceso;
        private System.Windows.Forms.Button btnCrearPlantilla;
        private System.Windows.Forms.NumericUpDown numCantidadProcesos;
        private System.Windows.Forms.ComboBox cbxPlantillaProceso;
        private System.Windows.Forms.GroupBox grpCPUs;
        private System.Windows.Forms.TextBox txtPrioridadProceso;
        private System.Windows.Forms.Label lblVelocidadCPU;
        private System.Windows.Forms.Label lblCantidadCPUs;
        private System.Windows.Forms.NumericUpDown numCantidadCPUs;
        private System.Windows.Forms.TrackBar tckVelocidadCPU;
        private System.Windows.Forms.Button btnIniciarSimulacion;
        private System.Windows.Forms.Button btnLimpiarSimulacion;
        private System.Windows.Forms.TextBox txtVelocidadCPU;
        private System.Windows.Forms.Button btnAgregarCPU;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblProcesosIngresados;
        private System.Windows.Forms.Label lblCPUsIngresados;
    }
}
