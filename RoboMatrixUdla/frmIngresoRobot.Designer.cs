namespace RoboMatrixUdla
{
    partial class frmIngresoRobot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.grbDatosRobot = new System.Windows.Forms.GroupBox();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblLider = new System.Windows.Forms.Label();
            this.txtlider = new System.Windows.Forms.TextBox();
            this.txtIdRobot = new System.Windows.Forms.TextBox();
            this.lblIdRobot = new System.Windows.Forms.Label();
            this.grbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnIngresarRobot = new System.Windows.Forms.Button();
            this.btnBorrarRobot = new System.Windows.Forms.Button();
            this.btnHabilitarRobot = new System.Windows.Forms.Button();
            this.btnModificarRobot = new System.Windows.Forms.Button();
            this.dgvRobot = new System.Windows.Forms.DataGridView();
            this.grbRobots = new System.Windows.Forms.GroupBox();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.lblTipoFiltro = new System.Windows.Forms.Label();
            this.cmbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.grbDatosRobot.SuspendLayout();
            this.grbOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRobot)).BeginInit();
            this.grbRobots.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar el nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar el estado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "DESACTIVADO"});
            this.cmbEstado.Location = new System.Drawing.Point(167, 95);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(171, 21);
            this.cmbEstado.TabIndex = 3;
            // 
            // grbDatosRobot
            // 
            this.grbDatosRobot.Controls.Add(this.cmbEquipo);
            this.grbDatosRobot.Controls.Add(this.label4);
            this.grbDatosRobot.Controls.Add(this.cmbCategoria);
            this.grbDatosRobot.Controls.Add(this.lblCategoria);
            this.grbDatosRobot.Controls.Add(this.lblLider);
            this.grbDatosRobot.Controls.Add(this.txtlider);
            this.grbDatosRobot.Controls.Add(this.txtIdRobot);
            this.grbDatosRobot.Controls.Add(this.lblIdRobot);
            this.grbDatosRobot.Controls.Add(this.cmbEstado);
            this.grbDatosRobot.Controls.Add(this.label1);
            this.grbDatosRobot.Controls.Add(this.label2);
            this.grbDatosRobot.Controls.Add(this.txtNombre);
            this.grbDatosRobot.Location = new System.Drawing.Point(12, 12);
            this.grbDatosRobot.Name = "grbDatosRobot";
            this.grbDatosRobot.Size = new System.Drawing.Size(356, 244);
            this.grbDatosRobot.TabIndex = 5;
            this.grbDatosRobot.TabStop = false;
            this.grbDatosRobot.Text = "Datos del Robot";
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(167, 215);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(171, 21);
            this.cmbEquipo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingresar el equipo:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "MEGASUMO",
            "MINISUMO",
            "SEGUIDOR DE LÍNEAS",
            "DRONES",
            "LEGO SUMO",
            "SEGUIDOR DE LÍNEAS LEGO",
            "ROBOTOPIA",
            "LABERINTO"});
            this.cmbCategoria.Location = new System.Drawing.Point(167, 176);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(171, 21);
            this.cmbCategoria.TabIndex = 9;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(10, 179);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(109, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Ingresar la Categoría:";
            // 
            // lblLider
            // 
            this.lblLider.AutoSize = true;
            this.lblLider.Location = new System.Drawing.Point(10, 138);
            this.lblLider.Name = "lblLider";
            this.lblLider.Size = new System.Drawing.Size(83, 13);
            this.lblLider.TabIndex = 6;
            this.lblLider.Text = "Ingresar el líder:";
            // 
            // txtlider
            // 
            this.txtlider.Location = new System.Drawing.Point(167, 135);
            this.txtlider.Name = "txtlider";
            this.txtlider.Size = new System.Drawing.Size(171, 20);
            this.txtlider.TabIndex = 7;
            // 
            // txtIdRobot
            // 
            this.txtIdRobot.Location = new System.Drawing.Point(167, 23);
            this.txtIdRobot.Name = "txtIdRobot";
            this.txtIdRobot.Size = new System.Drawing.Size(171, 20);
            this.txtIdRobot.TabIndex = 5;
            // 
            // lblIdRobot
            // 
            this.lblIdRobot.AutoSize = true;
            this.lblIdRobot.Location = new System.Drawing.Point(10, 26);
            this.lblIdRobot.Name = "lblIdRobot";
            this.lblIdRobot.Size = new System.Drawing.Size(53, 13);
            this.lblIdRobot.TabIndex = 4;
            this.lblIdRobot.Text = "ID Robot:";
            // 
            // grbOperaciones
            // 
            this.grbOperaciones.Controls.Add(this.btnIngresarRobot);
            this.grbOperaciones.Controls.Add(this.btnBorrarRobot);
            this.grbOperaciones.Controls.Add(this.btnHabilitarRobot);
            this.grbOperaciones.Controls.Add(this.btnModificarRobot);
            this.grbOperaciones.Location = new System.Drawing.Point(379, 12);
            this.grbOperaciones.Name = "grbOperaciones";
            this.grbOperaciones.Size = new System.Drawing.Size(188, 244);
            this.grbOperaciones.TabIndex = 6;
            this.grbOperaciones.TabStop = false;
            this.grbOperaciones.Text = "Operaciones";
            // 
            // btnIngresarRobot
            // 
            this.btnIngresarRobot.Location = new System.Drawing.Point(17, 66);
            this.btnIngresarRobot.Name = "btnIngresarRobot";
            this.btnIngresarRobot.Size = new System.Drawing.Size(155, 23);
            this.btnIngresarRobot.TabIndex = 11;
            this.btnIngresarRobot.Text = "Ingresar Robot";
            this.btnIngresarRobot.UseVisualStyleBackColor = true;
            this.btnIngresarRobot.Click += new System.EventHandler(this.btnIngresarRobot_Click);
            // 
            // btnBorrarRobot
            // 
            this.btnBorrarRobot.Location = new System.Drawing.Point(17, 124);
            this.btnBorrarRobot.Name = "btnBorrarRobot";
            this.btnBorrarRobot.Size = new System.Drawing.Size(155, 23);
            this.btnBorrarRobot.TabIndex = 14;
            this.btnBorrarRobot.Text = "Borrar Robot";
            this.btnBorrarRobot.UseVisualStyleBackColor = true;
            this.btnBorrarRobot.Click += new System.EventHandler(this.btnBorrarRobot_Click);
            // 
            // btnHabilitarRobot
            // 
            this.btnHabilitarRobot.Location = new System.Drawing.Point(17, 38);
            this.btnHabilitarRobot.Name = "btnHabilitarRobot";
            this.btnHabilitarRobot.Size = new System.Drawing.Size(155, 23);
            this.btnHabilitarRobot.TabIndex = 10;
            this.btnHabilitarRobot.Text = "Habilitar Ingreso";
            this.btnHabilitarRobot.UseVisualStyleBackColor = true;
            this.btnHabilitarRobot.Click += new System.EventHandler(this.btnHabilitarRobot_Click);
            // 
            // btnModificarRobot
            // 
            this.btnModificarRobot.Location = new System.Drawing.Point(17, 95);
            this.btnModificarRobot.Name = "btnModificarRobot";
            this.btnModificarRobot.Size = new System.Drawing.Size(155, 23);
            this.btnModificarRobot.TabIndex = 13;
            this.btnModificarRobot.Text = "Modificar Robot";
            this.btnModificarRobot.UseVisualStyleBackColor = true;
            this.btnModificarRobot.Click += new System.EventHandler(this.btnModificarRobot_Click);
            // 
            // dgvRobot
            // 
            this.dgvRobot.AllowUserToAddRows = false;
            this.dgvRobot.AllowUserToDeleteRows = false;
            this.dgvRobot.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvRobot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRobot.Enabled = false;
            this.dgvRobot.Location = new System.Drawing.Point(13, 55);
            this.dgvRobot.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRobot.Name = "dgvRobot";
            this.dgvRobot.RowTemplate.Height = 24;
            this.dgvRobot.Size = new System.Drawing.Size(532, 162);
            this.dgvRobot.TabIndex = 102;
            this.dgvRobot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRobot_CellContentClick);
            // 
            // grbRobots
            // 
            this.grbRobots.Controls.Add(this.btnFiltrar);
            this.grbRobots.Controls.Add(this.txtFiltroNombre);
            this.grbRobots.Controls.Add(this.lblTipoFiltro);
            this.grbRobots.Controls.Add(this.cmbTipoFiltro);
            this.grbRobots.Controls.Add(this.dgvRobot);
            this.grbRobots.Location = new System.Drawing.Point(12, 262);
            this.grbRobots.Name = "grbRobots";
            this.grbRobots.Size = new System.Drawing.Size(555, 222);
            this.grbRobots.TabIndex = 103;
            this.grbRobots.TabStop = false;
            this.grbRobots.Text = "Robots";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(235, 26);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(121, 20);
            this.txtFiltroNombre.TabIndex = 105;
            // 
            // lblTipoFiltro
            // 
            this.lblTipoFiltro.AutoSize = true;
            this.lblTipoFiltro.Location = new System.Drawing.Point(13, 29);
            this.lblTipoFiltro.Name = "lblTipoFiltro";
            this.lblTipoFiltro.Size = new System.Drawing.Size(53, 13);
            this.lblTipoFiltro.TabIndex = 104;
            this.lblTipoFiltro.Text = "Filtrar por:";
            // 
            // cmbTipoFiltro
            // 
            this.cmbTipoFiltro.FormattingEnabled = true;
            this.cmbTipoFiltro.Items.AddRange(new object[] {
            "NOMBRE",
            "ESTADO"});
            this.cmbTipoFiltro.Location = new System.Drawing.Point(85, 26);
            this.cmbTipoFiltro.Name = "cmbTipoFiltro";
            this.cmbTipoFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoFiltro.TabIndex = 103;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(384, 25);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(114, 23);
            this.btnFiltrar.TabIndex = 107;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmIngresoRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 496);
            this.Controls.Add(this.grbRobots);
            this.Controls.Add(this.grbOperaciones);
            this.Controls.Add(this.grbDatosRobot);
            this.Name = "frmIngresoRobot";
            this.Text = "Ingresar Robot";
            this.Load += new System.EventHandler(this.frmIngresoRobot_Load);
            this.grbDatosRobot.ResumeLayout(false);
            this.grbDatosRobot.PerformLayout();
            this.grbOperaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRobot)).EndInit();
            this.grbRobots.ResumeLayout(false);
            this.grbRobots.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox grbDatosRobot;
        private System.Windows.Forms.GroupBox grbOperaciones;
        private System.Windows.Forms.Button btnIngresarRobot;
        private System.Windows.Forms.Button btnBorrarRobot;
        private System.Windows.Forms.Button btnHabilitarRobot;
        private System.Windows.Forms.Button btnModificarRobot;
        private System.Windows.Forms.DataGridView dgvRobot;
        private System.Windows.Forms.GroupBox grbRobots;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Label lblTipoFiltro;
        private System.Windows.Forms.ComboBox cmbTipoFiltro;
        private System.Windows.Forms.Label lblIdRobot;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblLider;
        private System.Windows.Forms.TextBox txtlider;
        private System.Windows.Forms.TextBox txtIdRobot;
        private System.Windows.Forms.Button btnFiltrar;
    }
}