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
            this.grbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnHabilitarModificaciones = new System.Windows.Forms.Button();
            this.btnHabilitarRobot = new System.Windows.Forms.Button();
            this.btnBorrarRobot = new System.Windows.Forms.Button();
            this.btnModificarRobot = new System.Windows.Forms.Button();
            this.btnIngresarRobot = new System.Windows.Forms.Button();
            this.dgvRobot = new System.Windows.Forms.DataGridView();
            this.grbRobots = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblTipoFiltro = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblIdRobot = new System.Windows.Forms.Label();
            this.cmbIdRobot = new System.Windows.Forms.ComboBox();
            this.grbDatosRobot.SuspendLayout();
            this.grbOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRobot)).BeginInit();
            this.grbRobots.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar el nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar el estado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "DESACTIVADO"});
            this.cmbEstado.Location = new System.Drawing.Point(138, 99);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 3;
            // 
            // grbDatosRobot
            // 
            this.grbDatosRobot.Controls.Add(this.cmbIdRobot);
            this.grbDatosRobot.Controls.Add(this.lblIdRobot);
            this.grbDatosRobot.Controls.Add(this.cmbEstado);
            this.grbDatosRobot.Controls.Add(this.label1);
            this.grbDatosRobot.Controls.Add(this.label2);
            this.grbDatosRobot.Controls.Add(this.txtNombre);
            this.grbDatosRobot.Location = new System.Drawing.Point(12, 12);
            this.grbDatosRobot.Name = "grbDatosRobot";
            this.grbDatosRobot.Size = new System.Drawing.Size(274, 133);
            this.grbDatosRobot.TabIndex = 5;
            this.grbDatosRobot.TabStop = false;
            this.grbDatosRobot.Text = "Datos del Robot";
            // 
            // grbOperaciones
            // 
            this.grbOperaciones.Controls.Add(this.btnHabilitarModificaciones);
            this.grbOperaciones.Controls.Add(this.btnIngresarRobot);
            this.grbOperaciones.Controls.Add(this.btnBorrarRobot);
            this.grbOperaciones.Controls.Add(this.btnHabilitarRobot);
            this.grbOperaciones.Controls.Add(this.btnModificarRobot);
            this.grbOperaciones.Location = new System.Drawing.Point(293, 12);
            this.grbOperaciones.Name = "grbOperaciones";
            this.grbOperaciones.Size = new System.Drawing.Size(274, 133);
            this.grbOperaciones.TabIndex = 6;
            this.grbOperaciones.TabStop = false;
            this.grbOperaciones.Text = "Operaciones";
            // 
            // btnHabilitarModificaciones
            // 
            this.btnHabilitarModificaciones.Location = new System.Drawing.Point(133, 35);
            this.btnHabilitarModificaciones.Name = "btnHabilitarModificaciones";
            this.btnHabilitarModificaciones.Size = new System.Drawing.Size(131, 23);
            this.btnHabilitarModificaciones.TabIndex = 12;
            this.btnHabilitarModificaciones.Text = "Habilitar Modificaciones";
            this.btnHabilitarModificaciones.UseVisualStyleBackColor = true;
            this.btnHabilitarModificaciones.Click += new System.EventHandler(this.btnHabilitarModificaciones_Click);
            // 
            // btnHabilitarRobot
            // 
            this.btnHabilitarRobot.Location = new System.Drawing.Point(6, 36);
            this.btnHabilitarRobot.Name = "btnHabilitarRobot";
            this.btnHabilitarRobot.Size = new System.Drawing.Size(118, 23);
            this.btnHabilitarRobot.TabIndex = 10;
            this.btnHabilitarRobot.Text = "Habilitar Ingreso";
            this.btnHabilitarRobot.UseVisualStyleBackColor = true;
            this.btnHabilitarRobot.Click += new System.EventHandler(this.btnHabilitarRobot_Click);
            // 
            // btnBorrarRobot
            // 
            this.btnBorrarRobot.Location = new System.Drawing.Point(133, 93);
            this.btnBorrarRobot.Name = "btnBorrarRobot";
            this.btnBorrarRobot.Size = new System.Drawing.Size(131, 23);
            this.btnBorrarRobot.TabIndex = 14;
            this.btnBorrarRobot.Text = "Borrar Robot";
            this.btnBorrarRobot.UseVisualStyleBackColor = true;
            this.btnBorrarRobot.Click += new System.EventHandler(this.btnBorrarRobot_Click);
            // 
            // btnModificarRobot
            // 
            this.btnModificarRobot.Location = new System.Drawing.Point(133, 64);
            this.btnModificarRobot.Name = "btnModificarRobot";
            this.btnModificarRobot.Size = new System.Drawing.Size(131, 23);
            this.btnModificarRobot.TabIndex = 13;
            this.btnModificarRobot.Text = "Modificar Robot";
            this.btnModificarRobot.UseVisualStyleBackColor = true;
            this.btnModificarRobot.Click += new System.EventHandler(this.btnModificarRobot_Click);
            // 
            // btnIngresarRobot
            // 
            this.btnIngresarRobot.Location = new System.Drawing.Point(6, 64);
            this.btnIngresarRobot.Name = "btnIngresarRobot";
            this.btnIngresarRobot.Size = new System.Drawing.Size(118, 23);
            this.btnIngresarRobot.TabIndex = 11;
            this.btnIngresarRobot.Text = "Ingresar Robot";
            this.btnIngresarRobot.UseVisualStyleBackColor = true;
            this.btnIngresarRobot.Click += new System.EventHandler(this.btnIngresarRobot_Click);
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
            // 
            // grbRobots
            // 
            this.grbRobots.Controls.Add(this.comboBox3);
            this.grbRobots.Controls.Add(this.txtFiltroNombre);
            this.grbRobots.Controls.Add(this.lblTipoFiltro);
            this.grbRobots.Controls.Add(this.comboBox2);
            this.grbRobots.Controls.Add(this.dgvRobot);
            this.grbRobots.Location = new System.Drawing.Point(12, 151);
            this.grbRobots.Name = "grbRobots";
            this.grbRobots.Size = new System.Drawing.Size(555, 222);
            this.grbRobots.TabIndex = 103;
            this.grbRobots.TabStop = false;
            this.grbRobots.Text = "Robots";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nombre",
            "Estado"});
            this.comboBox2.Location = new System.Drawing.Point(85, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 103;
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
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(235, 26);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(121, 20);
            this.txtFiltroNombre.TabIndex = 105;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "ACTIVO",
            "DESACTIVADO"});
            this.comboBox3.Location = new System.Drawing.Point(235, 26);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 106;
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
            // cmbIdRobot
            // 
            this.cmbIdRobot.FormattingEnabled = true;
            this.cmbIdRobot.Location = new System.Drawing.Point(138, 23);
            this.cmbIdRobot.Name = "cmbIdRobot";
            this.cmbIdRobot.Size = new System.Drawing.Size(121, 21);
            this.cmbIdRobot.TabIndex = 5;
            this.cmbIdRobot.SelectedIndexChanged += new System.EventHandler(this.cmbIdRobot_SelectedIndexChanged);
            // 
            // frmIngresoRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 385);
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
        private System.Windows.Forms.Button btnHabilitarModificaciones;
        private System.Windows.Forms.Button btnIngresarRobot;
        private System.Windows.Forms.Button btnBorrarRobot;
        private System.Windows.Forms.Button btnHabilitarRobot;
        private System.Windows.Forms.Button btnModificarRobot;
        private System.Windows.Forms.DataGridView dgvRobot;
        private System.Windows.Forms.GroupBox grbRobots;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Label lblTipoFiltro;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox cmbIdRobot;
        private System.Windows.Forms.Label lblIdRobot;
    }
}