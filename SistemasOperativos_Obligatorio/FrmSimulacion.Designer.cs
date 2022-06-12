namespace SistemasOperativos_Obligatorio
{
    partial class FrmSimulacion
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
            this.grdProcesadores = new System.Windows.Forms.DataGridView();
            this.grdProcesosListos = new System.Windows.Forms.DataGridView();
            this.lblProcesosListos = new System.Windows.Forms.Label();
            this.grdProcesosBloqueados = new System.Windows.Forms.DataGridView();
            this.lblProcesosBloqueados = new System.Windows.Forms.Label();
            this.colIDProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrioridadProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracionCPUProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracionESProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIntervaloESProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompletadoProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcesadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcesosListos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcesosBloqueados)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProcesadores
            // 
            this.grdProcesadores.AllowUserToAddRows = false;
            this.grdProcesadores.AllowUserToDeleteRows = false;
            this.grdProcesadores.AllowUserToResizeColumns = false;
            this.grdProcesadores.AllowUserToResizeRows = false;
            this.grdProcesadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProcesadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProcesadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdProcesadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProcesadores.ColumnHeadersVisible = false;
            this.grdProcesadores.Location = new System.Drawing.Point(12, 12);
            this.grdProcesadores.Name = "grdProcesadores";
            this.grdProcesadores.ReadOnly = true;
            this.grdProcesadores.RowHeadersVisible = false;
            this.grdProcesadores.RowTemplate.Height = 25;
            this.grdProcesadores.Size = new System.Drawing.Size(776, 90);
            this.grdProcesadores.TabIndex = 0;
            // 
            // grdProcesosListos
            // 
            this.grdProcesosListos.AllowUserToAddRows = false;
            this.grdProcesosListos.AllowUserToDeleteRows = false;
            this.grdProcesosListos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProcesosListos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProcesosListos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProcesosListos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDProcesoListo,
            this.colNombreProcesoListo,
            this.colPrioridadProcesoListo,
            this.colDuracionCPUProcesoListo,
            this.colDuracionESProcesoListo,
            this.colIntervaloESProcesoListo,
            this.colCompletadoProcesoListo,
            this.colEstadoProcesoListo});
            this.grdProcesosListos.Location = new System.Drawing.Point(12, 139);
            this.grdProcesosListos.Name = "grdProcesosListos";
            this.grdProcesosListos.ReadOnly = true;
            this.grdProcesosListos.RowHeadersVisible = false;
            this.grdProcesosListos.RowTemplate.Height = 25;
            this.grdProcesosListos.Size = new System.Drawing.Size(493, 299);
            this.grdProcesosListos.TabIndex = 1;
            // 
            // lblProcesosListos
            // 
            this.lblProcesosListos.AutoSize = true;
            this.lblProcesosListos.Location = new System.Drawing.Point(12, 121);
            this.lblProcesosListos.Name = "lblProcesosListos";
            this.lblProcesosListos.Size = new System.Drawing.Size(97, 15);
            this.lblProcesosListos.TabIndex = 2;
            this.lblProcesosListos.Text = "Cola de procesos";
            // 
            // grdProcesosBloqueados
            // 
            this.grdProcesosBloqueados.AllowUserToAddRows = false;
            this.grdProcesosBloqueados.AllowUserToDeleteRows = false;
            this.grdProcesosBloqueados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProcesosBloqueados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProcesosBloqueados.Location = new System.Drawing.Point(511, 139);
            this.grdProcesosBloqueados.Name = "grdProcesosBloqueados";
            this.grdProcesosBloqueados.ReadOnly = true;
            this.grdProcesosBloqueados.RowTemplate.Height = 25;
            this.grdProcesosBloqueados.Size = new System.Drawing.Size(277, 146);
            this.grdProcesosBloqueados.TabIndex = 3;
            // 
            // lblProcesosBloqueados
            // 
            this.lblProcesosBloqueados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcesosBloqueados.AutoSize = true;
            this.lblProcesosBloqueados.Location = new System.Drawing.Point(511, 121);
            this.lblProcesosBloqueados.Name = "lblProcesosBloqueados";
            this.lblProcesosBloqueados.Size = new System.Drawing.Size(119, 15);
            this.lblProcesosBloqueados.TabIndex = 4;
            this.lblProcesosBloqueados.Text = "Procesos bloqueados";
            // 
            // colIDProcesoListo
            // 
            this.colIDProcesoListo.HeaderText = "ID";
            this.colIDProcesoListo.Name = "colIDProcesoListo";
            this.colIDProcesoListo.ReadOnly = true;
            // 
            // colNombreProcesoListo
            // 
            this.colNombreProcesoListo.HeaderText = "Nombre";
            this.colNombreProcesoListo.Name = "colNombreProcesoListo";
            this.colNombreProcesoListo.ReadOnly = true;
            // 
            // colPrioridadProcesoListo
            // 
            this.colPrioridadProcesoListo.HeaderText = "Prioridad";
            this.colPrioridadProcesoListo.Name = "colPrioridadProcesoListo";
            this.colPrioridadProcesoListo.ReadOnly = true;
            // 
            // colDuracionCPUProcesoListo
            // 
            this.colDuracionCPUProcesoListo.HeaderText = "Uso CPU";
            this.colDuracionCPUProcesoListo.Name = "colDuracionCPUProcesoListo";
            this.colDuracionCPUProcesoListo.ReadOnly = true;
            // 
            // colDuracionESProcesoListo
            // 
            this.colDuracionESProcesoListo.HeaderText = "Duración E/S";
            this.colDuracionESProcesoListo.Name = "colDuracionESProcesoListo";
            this.colDuracionESProcesoListo.ReadOnly = true;
            // 
            // colIntervaloESProcesoListo
            // 
            this.colIntervaloESProcesoListo.HeaderText = "Intervalo E/S";
            this.colIntervaloESProcesoListo.Name = "colIntervaloESProcesoListo";
            this.colIntervaloESProcesoListo.ReadOnly = true;
            // 
            // colCompletadoProcesoListo
            // 
            this.colCompletadoProcesoListo.HeaderText = "Completado";
            this.colCompletadoProcesoListo.Name = "colCompletadoProcesoListo";
            this.colCompletadoProcesoListo.ReadOnly = true;
            // 
            // colEstadoProcesoListo
            // 
            this.colEstadoProcesoListo.HeaderText = "Estado";
            this.colEstadoProcesoListo.Name = "colEstadoProcesoListo";
            this.colEstadoProcesoListo.ReadOnly = true;
            // 
            // FrmSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProcesosBloqueados);
            this.Controls.Add(this.grdProcesosBloqueados);
            this.Controls.Add(this.lblProcesosListos);
            this.Controls.Add(this.grdProcesosListos);
            this.Controls.Add(this.grdProcesadores);
            this.Name = "FrmSimulacion";
            this.Text = "Simulación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmSimulacion_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdProcesadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcesosListos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcesosBloqueados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProcesadores;
        private System.Windows.Forms.DataGridView grdProcesosListos;
        private System.Windows.Forms.Label lblProcesosListos;
        private System.Windows.Forms.DataGridView grdProcesosBloqueados;
        private System.Windows.Forms.Label lblProcesosBloqueados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrioridadProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracionCPUProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracionESProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntervaloESProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompletadoProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoProcesoListo;
    }
}