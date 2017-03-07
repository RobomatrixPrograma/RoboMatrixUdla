namespace RoboMatrixUdla
{
    partial class frmGenerarLlaves
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlaves)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(248, 53);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(183, 21);
            this.cmbCategoria.TabIndex = 0;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(77, 56);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(125, 13);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Seleccionar la Categoria:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(418, 114);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Llaves";
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
            // frmGenerarLlaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 440);
            this.Controls.Add(this.dgvLlaves);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Name = "frmGenerarLlaves";
            this.Text = "Generar Llaves";
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
    }
}