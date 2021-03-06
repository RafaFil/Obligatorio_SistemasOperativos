namespace SistemasOperativos_Obligatorio
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
            this.grdCPUs = new System.Windows.Forms.DataGridView();
            this.colIDCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVelocidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProcesosIngresados = new System.Windows.Forms.Label();
            this.lblCPUsIngresados = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grdProcesos = new System.Windows.Forms.DataGridView();
            this.colIDProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracionCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracionES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIntervaloES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEsDeSO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tckIntervaloActualizacion = new System.Windows.Forms.TrackBar();
            this.lblIntervaloActualizacion = new System.Windows.Forms.Label();
            this.txtIntervaloActualizacion = new System.Windows.Forms.TextBox();
            this.lblTiempoMaximoCPU = new System.Windows.Forms.Label();
            this.tckTiempoMaximoCPU = new System.Windows.Forms.TrackBar();
            this.txtTiempoMaximoCPU = new System.Windows.Forms.TextBox();
            this.grpAgregarProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckPrioridadProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadProcesos)).BeginInit();
            this.grpCPUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadCPUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckVelocidadCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCPUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckIntervaloActualizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckTiempoMaximoCPU)).BeginInit();
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
            this.tckPrioridadProceso.TabIndex = 2;
            this.tckPrioridadProceso.TickFrequency = 10;
            this.tckPrioridadProceso.Value = 1;
            this.tckPrioridadProceso.ValueChanged += new System.EventHandler(this.tckPrioridadProceso_ValueChanged);
            // 
            // btnAgregarProceso
            // 
            this.btnAgregarProceso.Enabled = false;
            this.btnAgregarProceso.Location = new System.Drawing.Point(316, 127);
            this.btnAgregarProceso.Name = "btnAgregarProceso";
            this.btnAgregarProceso.Size = new System.Drawing.Size(92, 23);
            this.btnAgregarProceso.TabIndex = 3;
            this.btnAgregarProceso.Text = "Agregar";
            this.btnAgregarProceso.UseVisualStyleBackColor = true;
            this.btnAgregarProceso.Click += new System.EventHandler(this.btnAgregarProceso_Click);
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
            this.btnCargaMasivaProcesos.TabIndex = 5;
            this.btnCargaMasivaProcesos.Text = "Carga masiva";
            this.btnCargaMasivaProcesos.UseVisualStyleBackColor = true;
            this.btnCargaMasivaProcesos.Click += new System.EventHandler(this.btnCargaMasivaProcesos_Click);
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
            this.btnCrearPlantilla.TabIndex = 4;
            this.btnCrearPlantilla.Text = "Crear plantilla";
            this.btnCrearPlantilla.UseVisualStyleBackColor = true;
            this.btnCrearPlantilla.Click += new System.EventHandler(this.btnCrearPlantilla_Click);
            // 
            // numCantidadProcesos
            // 
            this.numCantidadProcesos.Location = new System.Drawing.Point(6, 105);
            this.numCantidadProcesos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidadProcesos.Name = "numCantidadProcesos";
            this.numCantidadProcesos.Size = new System.Drawing.Size(79, 23);
            this.numCantidadProcesos.TabIndex = 1;
            this.numCantidadProcesos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxPlantillaProceso
            // 
            this.cbxPlantillaProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPlantillaProceso.FormattingEnabled = true;
            this.cbxPlantillaProceso.Location = new System.Drawing.Point(6, 45);
            this.cbxPlantillaProceso.Name = "cbxPlantillaProceso";
            this.cbxPlantillaProceso.Size = new System.Drawing.Size(259, 23);
            this.cbxPlantillaProceso.TabIndex = 0;
            this.cbxPlantillaProceso.SelectedIndexChanged += new System.EventHandler(this.cbxPlantillaProceso_SelectedIndexChanged);
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
            this.btnAgregarCPU.TabIndex = 2;
            this.btnAgregarCPU.Text = "Agregar";
            this.btnAgregarCPU.UseVisualStyleBackColor = true;
            this.btnAgregarCPU.Click += new System.EventHandler(this.btnAgregarCPU_Click);
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
            this.numCantidadCPUs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidadCPUs.Name = "numCantidadCPUs";
            this.numCantidadCPUs.Size = new System.Drawing.Size(79, 23);
            this.numCantidadCPUs.TabIndex = 0;
            this.numCantidadCPUs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tckVelocidadCPU
            // 
            this.tckVelocidadCPU.Location = new System.Drawing.Point(128, 48);
            this.tckVelocidadCPU.Maximum = 100;
            this.tckVelocidadCPU.Name = "tckVelocidadCPU";
            this.tckVelocidadCPU.Size = new System.Drawing.Size(136, 45);
            this.tckVelocidadCPU.TabIndex = 1;
            this.tckVelocidadCPU.TickFrequency = 10;
            this.tckVelocidadCPU.ValueChanged += new System.EventHandler(this.tckVelocidadCPU_ValueChanged);
            // 
            // btnIniciarSimulacion
            // 
            this.btnIniciarSimulacion.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIniciarSimulacion.Enabled = false;
            this.btnIniciarSimulacion.Location = new System.Drawing.Point(750, 581);
            this.btnIniciarSimulacion.Name = "btnIniciarSimulacion";
            this.btnIniciarSimulacion.Size = new System.Drawing.Size(100, 33);
            this.btnIniciarSimulacion.TabIndex = 1;
            this.btnIniciarSimulacion.Text = "Iniciar";
            this.btnIniciarSimulacion.UseVisualStyleBackColor = false;
            this.btnIniciarSimulacion.Click += new System.EventHandler(this.btnIniciarSimulacion_Click);
            // 
            // btnLimpiarSimulacion
            // 
            this.btnLimpiarSimulacion.BackColor = System.Drawing.Color.LightCoral;
            this.btnLimpiarSimulacion.Location = new System.Drawing.Point(641, 581);
            this.btnLimpiarSimulacion.Name = "btnLimpiarSimulacion";
            this.btnLimpiarSimulacion.Size = new System.Drawing.Size(100, 33);
            this.btnLimpiarSimulacion.TabIndex = 0;
            this.btnLimpiarSimulacion.Text = "Limpiar";
            this.btnLimpiarSimulacion.UseVisualStyleBackColor = false;
            this.btnLimpiarSimulacion.Click += new System.EventHandler(this.btnLimpiarSimulacion_Click);
            // 
            // grdCPUs
            // 
            this.grdCPUs.AllowUserToAddRows = false;
            this.grdCPUs.AllowUserToDeleteRows = false;
            this.grdCPUs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCPUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCPUs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDCPU,
            this.colVelocidad});
            this.grdCPUs.Location = new System.Drawing.Point(639, 207);
            this.grdCPUs.Name = "grdCPUs";
            this.grdCPUs.ReadOnly = true;
            this.grdCPUs.RowHeadersVisible = false;
            this.grdCPUs.RowTemplate.Height = 25;
            this.grdCPUs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCPUs.Size = new System.Drawing.Size(209, 223);
            this.grdCPUs.TabIndex = 3;
            this.grdCPUs.TabStop = false;
            // 
            // colIDCPU
            // 
            this.colIDCPU.FillWeight = 25F;
            this.colIDCPU.HeaderText = "ID";
            this.colIDCPU.Name = "colIDCPU";
            this.colIDCPU.ReadOnly = true;
            // 
            // colVelocidad
            // 
            this.colVelocidad.FillWeight = 75F;
            this.colVelocidad.HeaderText = "Velocidad relativa";
            this.colVelocidad.Name = "colVelocidad";
            this.colVelocidad.ReadOnly = true;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // grdProcesos
            // 
            this.grdProcesos.AllowUserToAddRows = false;
            this.grdProcesos.AllowUserToDeleteRows = false;
            this.grdProcesos.AllowUserToResizeRows = false;
            this.grdProcesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDProceso,
            this.colNombreProceso,
            this.colDuracionCPU,
            this.colDuracionES,
            this.colIntervaloES,
            this.colPrioridad,
            this.colEsDeSO});
            this.grdProcesos.Location = new System.Drawing.Point(12, 207);
            this.grdProcesos.Name = "grdProcesos";
            this.grdProcesos.ReadOnly = true;
            this.grdProcesos.RowHeadersVisible = false;
            this.grdProcesos.RowTemplate.Height = 25;
            this.grdProcesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProcesos.Size = new System.Drawing.Size(607, 407);
            this.grdProcesos.TabIndex = 4;
            this.grdProcesos.TabStop = false;
            // 
            // colIDProceso
            // 
            this.colIDProceso.FillWeight = 20F;
            this.colIDProceso.HeaderText = "ID";
            this.colIDProceso.Name = "colIDProceso";
            this.colIDProceso.ReadOnly = true;
            // 
            // colNombreProceso
            // 
            this.colNombreProceso.HeaderText = "Nombre";
            this.colNombreProceso.Name = "colNombreProceso";
            this.colNombreProceso.ReadOnly = true;
            // 
            // colDuracionCPU
            // 
            this.colDuracionCPU.HeaderText = "Duración CPU";
            this.colDuracionCPU.Name = "colDuracionCPU";
            this.colDuracionCPU.ReadOnly = true;
            // 
            // colDuracionES
            // 
            this.colDuracionES.HeaderText = "Duración E/S";
            this.colDuracionES.Name = "colDuracionES";
            this.colDuracionES.ReadOnly = true;
            // 
            // colIntervaloES
            // 
            this.colIntervaloES.HeaderText = "Intervalo E/S";
            this.colIntervaloES.Name = "colIntervaloES";
            this.colIntervaloES.ReadOnly = true;
            // 
            // colPrioridad
            // 
            this.colPrioridad.HeaderText = "Prioridad";
            this.colPrioridad.Name = "colPrioridad";
            this.colPrioridad.ReadOnly = true;
            // 
            // colEsDeSO
            // 
            this.colEsDeSO.FillWeight = 30F;
            this.colEsDeSO.HeaderText = "SO";
            this.colEsDeSO.Name = "colEsDeSO";
            this.colEsDeSO.ReadOnly = true;
            // 
            // tckIntervaloActualizacion
            // 
            this.tckIntervaloActualizacion.LargeChange = 500;
            this.tckIntervaloActualizacion.Location = new System.Drawing.Point(641, 530);
            this.tckIntervaloActualizacion.Maximum = 4900;
            this.tckIntervaloActualizacion.Name = "tckIntervaloActualizacion";
            this.tckIntervaloActualizacion.Size = new System.Drawing.Size(137, 45);
            this.tckIntervaloActualizacion.SmallChange = 100;
            this.tckIntervaloActualizacion.TabIndex = 8;
            this.tckIntervaloActualizacion.TickFrequency = 500;
            this.tckIntervaloActualizacion.Scroll += new System.EventHandler(this.tckIntervaloActualizacion_Scroll);
            // 
            // lblIntervaloActualizacion
            // 
            this.lblIntervaloActualizacion.AutoSize = true;
            this.lblIntervaloActualizacion.Location = new System.Drawing.Point(641, 512);
            this.lblIntervaloActualizacion.Name = "lblIntervaloActualizacion";
            this.lblIntervaloActualizacion.Size = new System.Drawing.Size(168, 15);
            this.lblIntervaloActualizacion.TabIndex = 9;
            this.lblIntervaloActualizacion.Text = "Intervalo de actualización (ms)";
            // 
            // txtIntervaloActualizacion
            // 
            this.txtIntervaloActualizacion.Enabled = false;
            this.txtIntervaloActualizacion.Location = new System.Drawing.Point(784, 530);
            this.txtIntervaloActualizacion.Name = "txtIntervaloActualizacion";
            this.txtIntervaloActualizacion.Size = new System.Drawing.Size(66, 23);
            this.txtIntervaloActualizacion.TabIndex = 10;
            // 
            // lblTiempoMaximoCPU
            // 
            this.lblTiempoMaximoCPU.AutoSize = true;
            this.lblTiempoMaximoCPU.Location = new System.Drawing.Point(639, 449);
            this.lblTiempoMaximoCPU.Name = "lblTiempoMaximoCPU";
            this.lblTiempoMaximoCPU.Size = new System.Drawing.Size(163, 15);
            this.lblTiempoMaximoCPU.TabIndex = 11;
            this.lblTiempoMaximoCPU.Text = "Tiempo máximo en CPU (ms)";
            // 
            // tckTiempoMaximoCPU
            // 
            this.tckTiempoMaximoCPU.LargeChange = 500;
            this.tckTiempoMaximoCPU.Location = new System.Drawing.Point(639, 467);
            this.tckTiempoMaximoCPU.Maximum = 4900;
            this.tckTiempoMaximoCPU.Name = "tckTiempoMaximoCPU";
            this.tckTiempoMaximoCPU.Size = new System.Drawing.Size(139, 45);
            this.tckTiempoMaximoCPU.SmallChange = 100;
            this.tckTiempoMaximoCPU.TabIndex = 12;
            this.tckTiempoMaximoCPU.TickFrequency = 500;
            this.tckTiempoMaximoCPU.Value = 4900;
            this.tckTiempoMaximoCPU.Scroll += new System.EventHandler(this.tckTiempoMaximoCPU_Scroll);
            // 
            // txtTiempoMaximoCPU
            // 
            this.txtTiempoMaximoCPU.Enabled = false;
            this.txtTiempoMaximoCPU.Location = new System.Drawing.Point(784, 467);
            this.txtTiempoMaximoCPU.Name = "txtTiempoMaximoCPU";
            this.txtTiempoMaximoCPU.Size = new System.Drawing.Size(66, 23);
            this.txtTiempoMaximoCPU.TabIndex = 13;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 626);
            this.Controls.Add(this.txtTiempoMaximoCPU);
            this.Controls.Add(this.tckTiempoMaximoCPU);
            this.Controls.Add(this.lblTiempoMaximoCPU);
            this.Controls.Add(this.txtIntervaloActualizacion);
            this.Controls.Add(this.lblIntervaloActualizacion);
            this.Controls.Add(this.tckIntervaloActualizacion);
            this.Controls.Add(this.lblCPUsIngresados);
            this.Controls.Add(this.lblProcesosIngresados);
            this.Controls.Add(this.grdCPUs);
            this.Controls.Add(this.grdProcesos);
            this.Controls.Add(this.btnLimpiarSimulacion);
            this.Controls.Add(this.btnIniciarSimulacion);
            this.Controls.Add(this.grpCPUs);
            this.Controls.Add(this.grpAgregarProcesos);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de simulación";
            this.grpAgregarProcesos.ResumeLayout(false);
            this.grpAgregarProcesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckPrioridadProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadProcesos)).EndInit();
            this.grpCPUs.ResumeLayout(false);
            this.grpCPUs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadCPUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckVelocidadCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCPUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckIntervaloActualizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckTiempoMaximoCPU)).EndInit();
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
        private System.Windows.Forms.DataGridView grdCPUs;
        private System.Windows.Forms.Label lblProcesosIngresados;
        private System.Windows.Forms.Label lblCPUsIngresados;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView grdProcesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracionCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracionES;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntervaloES;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrioridad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEsDeSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVelocidad;
        private System.Windows.Forms.TrackBar tckIntervaloActualizacion;
        private System.Windows.Forms.Label lblIntervaloActualizacion;
        private System.Windows.Forms.TextBox txtIntervaloActualizacion;
        private System.Windows.Forms.Label lblTiempoMaximoCPU;
        private System.Windows.Forms.TrackBar tckTiempoMaximoCPU;
        private System.Windows.Forms.TextBox txtTiempoMaximoCPU;
    }
}
