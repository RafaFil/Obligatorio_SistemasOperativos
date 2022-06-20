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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdProcesadores = new System.Windows.Forms.DataGridView();
            this.grdProcesosListos = new System.Windows.Forms.DataGridView();
            this.colIDProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOProcesoListo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNombreProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrioridadProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracionCPUProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracionESProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIntervaloESProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompletadoProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoProcesoListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProcesosListos = new System.Windows.Forms.Label();
            this.grdProcesosBloqueados = new System.Windows.Forms.DataGridView();
            this.lblProcesosBloqueados = new System.Windows.Forms.Label();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.colIDProcesoBloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProcesoBloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotiboProcesoBloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProcesoBloqueadoCompletado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grdProcesadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProcesadores.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProcesadores.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdProcesadores.Location = new System.Drawing.Point(12, 12);
            this.grdProcesadores.Name = "grdProcesadores";
            this.grdProcesadores.ReadOnly = true;
            this.grdProcesadores.RowHeadersVisible = false;
            this.grdProcesadores.RowTemplate.Height = 25;
            this.grdProcesadores.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grdProcesadores.Size = new System.Drawing.Size(776, 90);
            this.grdProcesadores.TabIndex = 0;
            // 
            // grdProcesosListos
            // 
            this.grdProcesosListos.AllowUserToAddRows = false;
            this.grdProcesosListos.AllowUserToDeleteRows = false;
            this.grdProcesosListos.AllowUserToResizeColumns = false;
            this.grdProcesosListos.AllowUserToResizeRows = false;
            this.grdProcesosListos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProcesosListos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProcesosListos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProcesosListos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDProcesoListo,
            this.colSOProcesoListo,
            this.colNombreProcesoListo,
            this.colPrioridadProcesoListo,
            this.colDuracionCPUProcesoListo,
            this.colDuracionESProcesoListo,
            this.colIntervaloESProcesoListo,
            this.colCompletadoProcesoListo,
            this.colEstadoProcesoListo});
            this.grdProcesosListos.Location = new System.Drawing.Point(12, 139);
            this.grdProcesosListos.MultiSelect = false;
            this.grdProcesosListos.Name = "grdProcesosListos";
            this.grdProcesosListos.ReadOnly = true;
            this.grdProcesosListos.RowHeadersVisible = false;
            this.grdProcesosListos.RowTemplate.Height = 25;
            this.grdProcesosListos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProcesosListos.Size = new System.Drawing.Size(429, 299);
            this.grdProcesosListos.TabIndex = 1;
            this.grdProcesosListos.SelectionChanged += new System.EventHandler(this.grdProcesosListos_SelectionChanged);
            // 
            // colIDProcesoListo
            // 
            this.colIDProcesoListo.HeaderText = "ID";
            this.colIDProcesoListo.Name = "colIDProcesoListo";
            this.colIDProcesoListo.ReadOnly = true;
            // 
            // colSOProcesoListo
            // 
            this.colSOProcesoListo.HeaderText = "SO";
            this.colSOProcesoListo.Name = "colSOProcesoListo";
            this.colSOProcesoListo.ReadOnly = true;
            this.colSOProcesoListo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSOProcesoListo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNombreProcesoListo
            // 
            this.colNombreProcesoListo.HeaderText = "Nombre";
            this.colNombreProcesoListo.Name = "colNombreProcesoListo";
            this.colNombreProcesoListo.ReadOnly = true;
            // 
            // colPrioridadProcesoListo
            // 
            this.colPrioridadProcesoListo.HeaderText = "Prioridad base";
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
            this.grdProcesosBloqueados.AllowUserToResizeColumns = false;
            this.grdProcesosBloqueados.AllowUserToResizeRows = false;
            this.grdProcesosBloqueados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProcesosBloqueados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProcesosBloqueados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProcesosBloqueados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDProcesoBloqueado,
            this.colNombreProcesoBloqueado,
            this.colMotiboProcesoBloqueado,
            this.colProcesoBloqueadoCompletado});
            this.grdProcesosBloqueados.Location = new System.Drawing.Point(447, 139);
            this.grdProcesosBloqueados.MultiSelect = false;
            this.grdProcesosBloqueados.Name = "grdProcesosBloqueados";
            this.grdProcesosBloqueados.ReadOnly = true;
            this.grdProcesosBloqueados.RowHeadersVisible = false;
            this.grdProcesosBloqueados.RowTemplate.Height = 25;
            this.grdProcesosBloqueados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProcesosBloqueados.Size = new System.Drawing.Size(341, 146);
            this.grdProcesosBloqueados.TabIndex = 3;
            this.grdProcesosBloqueados.SelectionChanged += new System.EventHandler(this.grdProcesosBloqueados_SelectionChanged);
            // 
            // lblProcesosBloqueados
            // 
            this.lblProcesosBloqueados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcesosBloqueados.AutoSize = true;
            this.lblProcesosBloqueados.Location = new System.Drawing.Point(447, 121);
            this.lblProcesosBloqueados.Name = "lblProcesosBloqueados";
            this.lblProcesosBloqueados.Size = new System.Drawing.Size(119, 15);
            this.lblProcesosBloqueados.TabIndex = 4;
            this.lblProcesosBloqueados.Text = "Procesos bloqueados";
            // 
            // btnReanudar
            // 
            this.btnReanudar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReanudar.Location = new System.Drawing.Point(469, 402);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(97, 36);
            this.btnReanudar.TabIndex = 5;
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.UseVisualStyleBackColor = true;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetener.Location = new System.Drawing.Point(671, 402);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(94, 36);
            this.btnDetener.TabIndex = 6;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnBloquear
            // 
            this.btnBloquear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBloquear.Enabled = false;
            this.btnBloquear.Location = new System.Drawing.Point(469, 317);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(296, 23);
            this.btnBloquear.TabIndex = 7;
            this.btnBloquear.Text = "Bloquear proceso";
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesbloquear.Enabled = false;
            this.btnDesbloquear.Location = new System.Drawing.Point(469, 346);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(296, 23);
            this.btnDesbloquear.TabIndex = 8;
            this.btnDesbloquear.Text = "Desbloquear proceso";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReiniciar.Location = new System.Drawing.Point(469, 402);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(296, 36);
            this.btnReiniciar.TabIndex = 9;
            this.btnReiniciar.Text = "Reiniciar simulación";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Visible = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // colIDProcesoBloqueado
            // 
            this.colIDProcesoBloqueado.FillWeight = 50F;
            this.colIDProcesoBloqueado.HeaderText = "ID";
            this.colIDProcesoBloqueado.Name = "colIDProcesoBloqueado";
            this.colIDProcesoBloqueado.ReadOnly = true;
            // 
            // colNombreProcesoBloqueado
            // 
            this.colNombreProcesoBloqueado.HeaderText = "Nombre";
            this.colNombreProcesoBloqueado.Name = "colNombreProcesoBloqueado";
            this.colNombreProcesoBloqueado.ReadOnly = true;
            // 
            // colMotiboProcesoBloqueado
            // 
            this.colMotiboProcesoBloqueado.HeaderText = "Motivo";
            this.colMotiboProcesoBloqueado.Name = "colMotiboProcesoBloqueado";
            this.colMotiboProcesoBloqueado.ReadOnly = true;
            // 
            // colProcesoBloqueadoCompletado
            // 
            this.colProcesoBloqueadoCompletado.HeaderText = "Completado";
            this.colProcesoBloqueadoCompletado.Name = "colProcesoBloqueadoCompletado";
            this.colProcesoBloqueadoCompletado.ReadOnly = true;
            // 
            // FrmSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnBloquear);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnReanudar);
            this.Controls.Add(this.lblProcesosBloqueados);
            this.Controls.Add(this.grdProcesosBloqueados);
            this.Controls.Add(this.lblProcesosListos);
            this.Controls.Add(this.grdProcesosListos);
            this.Controls.Add(this.grdProcesadores);
            this.Controls.Add(this.btnReiniciar);
            this.Name = "FrmSimulacion";
            this.Text = "Simulación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSimulacion_Load);
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
        private System.Windows.Forms.Button btnReanudar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDProcesoListo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSOProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrioridadProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracionCPUProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracionESProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntervaloESProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompletadoProcesoListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoProcesoListo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDProcesoBloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProcesoBloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotiboProcesoBloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcesoBloqueadoCompletado;
    }
}