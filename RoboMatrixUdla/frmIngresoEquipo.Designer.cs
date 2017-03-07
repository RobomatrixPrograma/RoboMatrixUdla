﻿namespace RoboMatrixUdla
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
            this.btnHabilitarModificaciones = new System.Windows.Forms.Button();
            this.btnIngresarEquipo = new System.Windows.Forms.Button();
            this.btnBorrarEquipo = new System.Windows.Forms.Button();
            this.btnHabilitarIngreso = new System.Windows.Forms.Button();
            this.btnModificarEquipo = new System.Windows.Forms.Button();
            this.grbEquipos = new System.Windows.Forms.GroupBox();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.btnAgregarFiltro = new System.Windows.Forms.Button();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.lblTipoFiltro = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblidEquipo = new System.Windows.Forms.Label();
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
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(94, 91);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(174, 20);
            this.txtPais.TabIndex = 5;
            this.txtPais.TextChanged += new System.EventHandler(this.txtPais_TextChanged);
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
            this.grbOperaciones.Controls.Add(this.btnHabilitarModificaciones);
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
            // btnIngresarEquipo
            // 
            this.btnIngresarEquipo.Location = new System.Drawing.Point(6, 64);
            this.btnIngresarEquipo.Name = "btnIngresarEquipo";
            this.btnIngresarEquipo.Size = new System.Drawing.Size(118, 23);
            this.btnIngresarEquipo.TabIndex = 11;
            this.btnIngresarEquipo.Text = "Ingresar Equipo";
            this.btnIngresarEquipo.UseVisualStyleBackColor = true;
            this.btnIngresarEquipo.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnBorrarEquipo
            // 
            this.btnBorrarEquipo.Location = new System.Drawing.Point(133, 93);
            this.btnBorrarEquipo.Name = "btnBorrarEquipo";
            this.btnBorrarEquipo.Size = new System.Drawing.Size(131, 23);
            this.btnBorrarEquipo.TabIndex = 14;
            this.btnBorrarEquipo.Text = "Borrar Equipo";
            this.btnBorrarEquipo.UseVisualStyleBackColor = true;
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
            this.btnModificarEquipo.Location = new System.Drawing.Point(133, 64);
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
            this.grbEquipos.Controls.Add(this.btnAgregarFiltro);
            this.grbEquipos.Controls.Add(this.cmbLugar);
            this.grbEquipos.Controls.Add(this.txtFiltroNombre);
            this.grbEquipos.Controls.Add(this.lblTipoFiltro);
            this.grbEquipos.Controls.Add(this.cmbPais);
            this.grbEquipos.Controls.Add(this.dgvEquipo);
            this.grbEquipos.Location = new System.Drawing.Point(24, 230);
            this.grbEquipos.Name = "grbEquipos";
            this.grbEquipos.Size = new System.Drawing.Size(565, 233);
            this.grbEquipos.TabIndex = 104;
            this.grbEquipos.TabStop = false;
            this.grbEquipos.Text = "Robots";
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(470, 24);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarFiltro.TabIndex = 108;
            this.btnQuitarFiltro.Text = "Quitar Filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click);
            // 
            // btnAgregarFiltro
            // 
            this.btnAgregarFiltro.Location = new System.Drawing.Point(6, 23);
            this.btnAgregarFiltro.Name = "btnAgregarFiltro";
            this.btnAgregarFiltro.Size = new System.Drawing.Size(81, 23);
            this.btnAgregarFiltro.TabIndex = 107;
            this.btnAgregarFiltro.Text = "Agregar Filtro";
            this.btnAgregarFiltro.UseVisualStyleBackColor = true;
            this.btnAgregarFiltro.Click += new System.EventHandler(this.btnAgregarFiltro_Click);
            // 
            // cmbLugar
            // 
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Items.AddRange(new object[] {
            "ACTIVO",
            "DESACTIVADO"});
            this.cmbLugar.Location = new System.Drawing.Point(314, 26);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(121, 21);
            this.cmbLugar.TabIndex = 106;
            this.cmbLugar.SelectedIndexChanged += new System.EventHandler(this.cmbLugar_SelectedIndexChanged);
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(314, 26);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(121, 20);
            this.txtFiltroNombre.TabIndex = 105;
            // 
            // lblTipoFiltro
            // 
            this.lblTipoFiltro.AutoSize = true;
            this.lblTipoFiltro.Location = new System.Drawing.Point(105, 28);
            this.lblTipoFiltro.Name = "lblTipoFiltro";
            this.lblTipoFiltro.Size = new System.Drawing.Size(53, 13);
            this.lblTipoFiltro.TabIndex = 104;
            this.lblTipoFiltro.Text = "Filtrar por:";
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Items.AddRange(new object[] {
            "Nombre",
            "Estado"});
            this.cmbPais.Location = new System.Drawing.Point(164, 26);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 103;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.AllowUserToAddRows = false;
            this.dgvEquipo.AllowUserToDeleteRows = false;
            this.dgvEquipo.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipo.Enabled = false;
            this.dgvEquipo.Location = new System.Drawing.Point(13, 55);
            this.dgvEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.RowTemplate.Height = 24;
            this.dgvEquipo.Size = new System.Drawing.Size(542, 162);
            this.dgvEquipo.TabIndex = 102;
            this.dgvEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipo_CellContentClick);
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
            // frmIngresoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 475);
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
        private System.Windows.Forms.Button btnHabilitarModificaciones;
        private System.Windows.Forms.Button btnIngresarEquipo;
        private System.Windows.Forms.Button btnBorrarEquipo;
        private System.Windows.Forms.Button btnHabilitarIngreso;
        private System.Windows.Forms.Button btnModificarEquipo;
        private System.Windows.Forms.GroupBox grbEquipos;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Label lblTipoFiltro;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.DataGridView dgvEquipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblidEquipo;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.Button btnAgregarFiltro;
    }
}