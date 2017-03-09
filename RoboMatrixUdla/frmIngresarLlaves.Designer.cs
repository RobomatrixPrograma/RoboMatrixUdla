namespace RoboMatrixUdla
{
    partial class frmIngresarLlaves
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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvLlaves = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRobot1 = new System.Windows.Forms.ComboBox();
            this.cmbRobot2 = new System.Windows.Forms.ComboBox();
            this.btnSelccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlaves)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(157, 27);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(183, 21);
            this.cmbCategoria.TabIndex = 0;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            this.cmbCategoria.DropDownClosed += new System.EventHandler(this.cmbCategoria_DropDownClosed);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(37, 30);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(114, 13);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Seleccionar Categoria:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(398, 94);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(136, 24);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Ingresar Batalla";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvLlaves
            // 
            this.dgvLlaves.AllowUserToAddRows = false;
            this.dgvLlaves.AllowUserToDeleteRows = false;
            this.dgvLlaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLlaves.Location = new System.Drawing.Point(12, 185);
            this.dgvLlaves.Name = "dgvLlaves";
            this.dgvLlaves.Size = new System.Drawing.Size(548, 234);
            this.dgvLlaves.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Robot 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Robot 2:";
            // 
            // cmbRobot1
            // 
            this.cmbRobot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRobot1.FormattingEnabled = true;
            this.cmbRobot1.Location = new System.Drawing.Point(157, 72);
            this.cmbRobot1.Name = "cmbRobot1";
            this.cmbRobot1.Size = new System.Drawing.Size(183, 21);
            this.cmbRobot1.TabIndex = 6;
            this.cmbRobot1.SelectedIndexChanged += new System.EventHandler(this.cmbRobot1_SelectedIndexChanged);
            this.cmbRobot1.DropDownClosed += new System.EventHandler(this.cmbRobot1_DropDownClosed);
            this.cmbRobot1.Click += new System.EventHandler(this.cmbRobot1_Click);
            // 
            // cmbRobot2
            // 
            this.cmbRobot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRobot2.FormattingEnabled = true;
            this.cmbRobot2.Location = new System.Drawing.Point(158, 115);
            this.cmbRobot2.Name = "cmbRobot2";
            this.cmbRobot2.Size = new System.Drawing.Size(182, 21);
            this.cmbRobot2.TabIndex = 7;
            this.cmbRobot2.SelectedIndexChanged += new System.EventHandler(this.cmbRobot2_SelectedIndexChanged);
            this.cmbRobot2.Click += new System.EventHandler(this.cmbRobot2_Click);
            // 
            // btnSelccionar
            // 
            this.btnSelccionar.Location = new System.Drawing.Point(398, 50);
            this.btnSelccionar.Name = "btnSelccionar";
            this.btnSelccionar.Size = new System.Drawing.Size(136, 23);
            this.btnSelccionar.TabIndex = 8;
            this.btnSelccionar.Text = "Seleccionar Categoria";
            this.btnSelccionar.UseVisualStyleBackColor = true;
            this.btnSelccionar.Click += new System.EventHandler(this.btnSelccionar_Click);
            // 
            // frmIngresarLlaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 440);
            this.Controls.Add(this.btnSelccionar);
            this.Controls.Add(this.cmbRobot2);
            this.Controls.Add(this.cmbRobot1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLlaves);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Name = "frmIngresarLlaves";
            this.Text = "Ingresar Llaves";
            this.Load += new System.EventHandler(this.frmGenerarLlaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvLlaves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRobot1;
        private System.Windows.Forms.ComboBox cmbRobot2;
        private System.Windows.Forms.Button btnSelccionar;
    }
}