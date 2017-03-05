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
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(46, 80);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 1;
            this.lblPais.Text = "País:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(24, 111);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(69, 39);
            this.lblLugar.TabIndex = 2;
            this.lblLugar.Text = "Universidad \r\nu \r\nOrganizacion";
            this.lblLugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(46, 170);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(35, 13);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "label4";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(108, 77);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(146, 20);
            this.txtPais.TabIndex = 5;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(108, 121);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(146, 20);
            this.txtLugar.TabIndex = 6;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Location = new System.Drawing.Point(108, 158);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(146, 116);
            this.pcbLogo.TabIndex = 7;
            this.pcbLogo.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(191, 280);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(63, 23);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar...";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(128, 328);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(117, 31);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar Equipo";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // frmIngresoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 371);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIngresoEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Nuevo Equipo";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnIngresar;
    }
}