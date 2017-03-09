namespace RoboMatrixUdla
{
    partial class frmIngresoEquipo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.grbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnIngresarEquipo = new System.Windows.Forms.Button();
            this.btnBorrarEquipo = new System.Windows.Forms.Button();
            this.btnHabilitarIngreso = new System.Windows.Forms.Button();
            this.btnModificarEquipo = new System.Windows.Forms.Button();
            this.grbEquipos = new System.Windows.Forms.GroupBox();
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblidEquipo = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.grbOperaciones.SuspendLayout();
            this.grbEquipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(47, 94);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 1;
            this.lblPais.Text = "País:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(10, 125);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(69, 39);
            this.lblLugar.TabIndex = 2;
            this.lblLugar.Text = "Universidad \r\nu \r\nOrganizacion";
            this.lblLugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(94, 91);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(174, 20);
            this.txtPais.TabIndex = 5;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(94, 135);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(174, 20);
            this.txtLugar.TabIndex = 6;
            // 
            // grbOperaciones
            // 
            this.grbOperaciones.Controls.Add(this.btnIngresarEquipo);
            this.grbOperaciones.Controls.Add(this.btnBorrarEquipo);
            this.grbOperaciones.Controls.Add(this.btnHabilitarIngreso);
            this.grbOperaciones.Controls.Add(this.btnModificarEquipo);
            this.grbOperaciones.Location = new System.Drawing.Point(315, 30);
            this.grbOperaciones.Name = "grbOperaciones";
            this.grbOperaciones.Size = new System.Drawing.Size(274, 133);
            this.grbOperaciones.TabIndex = 10;
            this.grbOperaciones.TabStop = false;
            this.grbOperaciones.Text = "Operaciones";
            // 
            // btnIngresarEquipo
            // 
            this.btnIngresarEquipo.Location = new System.Drawing.Point(6, 78);
            this.btnIngresarEquipo.Name = "btnIngresarEquipo";
            this.btnIngresarEquipo.Size = new System.Drawing.Size(118, 23);
            this.btnIngresarEquipo.TabIndex = 11;
            this.btnIngresarEquipo.Text = "Ingresar Equipo";
            this.btnIngresarEquipo.UseVisualStyleBackColor = true;
            this.btnIngresarEquipo.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnBorrarEquipo
            // 
            this.btnBorrarEquipo.Location = new System.Drawing.Point(130, 78);
            this.btnBorrarEquipo.Name = "btnBorrarEquipo";
            this.btnBorrarEquipo.Size = new System.Drawing.Size(131, 23);
            this.btnBorrarEquipo.TabIndex = 14;
            this.btnBorrarEquipo.Text = "Borrar Equipo";
            this.btnBorrarEquipo.UseVisualStyleBackColor = true;
            this.btnBorrarEquipo.Click += new System.EventHandler(this.btnBorrarEquipo_Click);
            // 
            // btnHabilitarIngreso
            // 
            this.btnHabilitarIngreso.Location = new System.Drawing.Point(6, 36);
            this.btnHabilitarIngreso.Name = "btnHabilitarIngreso";
            this.btnHabilitarIngreso.Size = new System.Drawing.Size(118, 23);
            this.btnHabilitarIngreso.TabIndex = 10;
            this.btnHabilitarIngreso.Text = "Habilitar Ingreso";
            this.btnHabilitarIngreso.UseVisualStyleBackColor = true;
            this.btnHabilitarIngreso.Click += new System.EventHandler(this.btnHabilitarEquipo_Click);
            // 
            // btnModificarEquipo
            // 
            this.btnModificarEquipo.Location = new System.Drawing.Point(130, 36);
            this.btnModificarEquipo.Name = "btnModificarEquipo";
            this.btnModificarEquipo.Size = new System.Drawing.Size(131, 23);
            this.btnModificarEquipo.TabIndex = 13;
            this.btnModificarEquipo.Text = "Modificar Equipo";
            this.btnModificarEquipo.UseVisualStyleBackColor = true;
            this.btnModificarEquipo.Click += new System.EventHandler(this.btnModificarEquipo_Click);
            // 
            // grbEquipos
            // 
            this.grbEquipos.Controls.Add(this.btnQuitarFiltro);
            this.grbEquipos.Controls.Add(this.txtFiltro);
            this.grbEquipos.Controls.Add(this.lblBuscar);
            this.grbEquipos.Controls.Add(this.dgvEquipo);
            this.grbEquipos.Location = new System.Drawing.Point(12, 230);
            this.grbEquipos.Name = "grbEquipos";
            this.grbEquipos.Size = new System.Drawing.Size(590, 251);
            this.grbEquipos.TabIndex = 104;
            this.grbEquipos.TabStop = false;
            this.grbEquipos.Text = "Robots";
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.AllowUserToAddRows = false;
            this.dgvEquipo.AllowUserToDeleteRows = false;
            this.dgvEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipo.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipo.Enabled = false;
            this.dgvEquipo.Location = new System.Drawing.Point(14, 53);
            this.dgvEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.RowTemplate.Height = 24;
            this.dgvEquipo.Size = new System.Drawing.Size(563, 193);
            this.dgvEquipo.TabIndex = 102;
            this.dgvEquipo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipo_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblidEquipo);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblPais);
            this.groupBox1.Controls.Add(this.lblLugar);
            this.groupBox1.Controls.Add(this.txtLugar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtPais);
            this.groupBox1.Location = new System.Drawing.Point(25, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 187);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Equipo";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(94, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(92, 20);
            this.txtId.TabIndex = 8;
            // 
            // lblidEquipo
            // 
            this.lblidEquipo.AutoSize = true;
            this.lblidEquipo.Location = new System.Drawing.Point(24, 22);
            this.lblidEquipo.Name = "lblidEquipo";
            this.lblidEquipo.Size = new System.Drawing.Size(55, 13);
            this.lblidEquipo.TabIndex = 7;
            this.lblidEquipo.Text = "Id Equipo:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(33, 30);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 103;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(82, 27);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(152, 20);
            this.txtFiltro.TabIndex = 104;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(253, 25);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(91, 23);
            this.btnQuitarFiltro.TabIndex = 105;
            this.btnQuitarFiltro.Text = "Quitar Filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click);
            // 
            // frmIngresoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbEquipos);
            this.Controls.Add(this.grbOperaciones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIngresoEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Nuevo Equipo";
            this.Load += new System.EventHandler(this.frmIngresoEquipo_Load);
            this.grbOperaciones.ResumeLayout(false);
            this.grbEquipos.ResumeLayout(false);
            this.grbEquipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.GroupBox grbOperaciones;
        private System.Windows.Forms.Button btnIngresarEquipo;
        private System.Windows.Forms.Button btnBorrarEquipo;
        private System.Windows.Forms.Button btnHabilitarIngreso;
        private System.Windows.Forms.Button btnModificarEquipo;
        private System.Windows.Forms.GroupBox grbEquipos;
        private System.Windows.Forms.DataGridView dgvEquipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblidEquipo;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblBuscar;
    }
}