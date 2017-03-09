namespace RoboMatrixUdla
{
    partial class frmIngresarOrden
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.cmbRobot = new System.Windows.Forms.ComboBox();
            this.lblRobot = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(44, 34);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(108, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Sleccionar Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(175, 31);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(183, 21);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.DropDownClosed += new System.EventHandler(this.cmbCategoria_DropDownClosed);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(390, 62);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(137, 27);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Ingresar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvOrden
            // 
            this.dgvOrden.AllowUserToAddRows = false;
            this.dgvOrden.AllowUserToDeleteRows = false;
            this.dgvOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Location = new System.Drawing.Point(47, 120);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.ReadOnly = true;
            this.dgvOrden.Size = new System.Drawing.Size(524, 244);
            this.dgvOrden.TabIndex = 3;
            // 
            // cmbRobot
            // 
            this.cmbRobot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRobot.FormattingEnabled = true;
            this.cmbRobot.Location = new System.Drawing.Point(175, 68);
            this.cmbRobot.Name = "cmbRobot";
            this.cmbRobot.Size = new System.Drawing.Size(183, 21);
            this.cmbRobot.TabIndex = 9;
            this.cmbRobot.DropDownClosed += new System.EventHandler(this.cmbRobot_DropDownClosed);
            // 
            // lblRobot
            // 
            this.lblRobot.AutoSize = true;
            this.lblRobot.Location = new System.Drawing.Point(104, 76);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(48, 13);
            this.lblRobot.TabIndex = 8;
            this.lblRobot.Text = "Robot 1:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(390, 25);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(137, 27);
            this.btnSeleccionar.TabIndex = 10;
            this.btnSeleccionar.Text = "Seleccionar Categoria";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmIngresarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 376);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.cmbRobot);
            this.Controls.Add(this.lblRobot);
            this.Controls.Add(this.dgvOrden);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Name = "frmIngresarOrden";
            this.Text = "Ingresar Orden";
            this.Load += new System.EventHandler(this.frmGenerarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.ComboBox cmbRobot;
        private System.Windows.Forms.Label lblRobot;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}