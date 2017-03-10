namespace RoboMatrixUdla
{
    partial class frmMinisumo
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
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.lblBatallas = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.nudRobot2 = new System.Windows.Forms.NumericUpDown();
            this.nudRobot1 = new System.Windows.Forms.NumericUpDown();
            this.lblRobot1 = new System.Windows.Forms.Label();
            this.lblRobot2 = new System.Windows.Forms.Label();
            this.lblVs = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.lblEquipo1 = new System.Windows.Forms.Label();
            this.lblEquipo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRobot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRobot1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.AllowUserToAddRows = false;
            this.dgvParticipantes.AllowUserToDeleteRows = false;
            this.dgvParticipantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Location = new System.Drawing.Point(12, 87);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.ReadOnly = true;
            this.dgvParticipantes.Size = new System.Drawing.Size(360, 533);
            this.dgvParticipantes.TabIndex = 0;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(378, 360);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(544, 260);
            this.dgvResultados.TabIndex = 1;
            // 
            // lblBatallas
            // 
            this.lblBatallas.AutoSize = true;
            this.lblBatallas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblBatallas.Location = new System.Drawing.Point(32, 34);
            this.lblBatallas.Name = "lblBatallas";
            this.lblBatallas.Size = new System.Drawing.Size(290, 39);
            this.lblBatallas.TabIndex = 2;
            this.lblBatallas.Text = "Próximas Batallas";
            this.lblBatallas.Click += new System.EventHandler(this.lblBatallas_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblResultados.Location = new System.Drawing.Point(574, 318);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(188, 39);
            this.lblResultados.TabIndex = 3;
            this.lblResultados.Text = "Resultados";
            // 
            // nudRobot2
            // 
            this.nudRobot2.BackColor = System.Drawing.Color.Aquamarine;
            this.nudRobot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.nudRobot2.Location = new System.Drawing.Point(657, 136);
            this.nudRobot2.Name = "nudRobot2";
            this.nudRobot2.Size = new System.Drawing.Size(129, 83);
            this.nudRobot2.TabIndex = 4;
            this.nudRobot2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudRobot1
            // 
            this.nudRobot1.BackColor = System.Drawing.Color.Aquamarine;
            this.nudRobot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.nudRobot1.Location = new System.Drawing.Point(422, 136);
            this.nudRobot1.Name = "nudRobot1";
            this.nudRobot1.Size = new System.Drawing.Size(129, 83);
            this.nudRobot1.TabIndex = 5;
            this.nudRobot1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRobot1
            // 
            this.lblRobot1.AutoSize = true;
            this.lblRobot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblRobot1.Location = new System.Drawing.Point(428, 42);
            this.lblRobot1.Name = "lblRobot1";
            this.lblRobot1.Size = new System.Drawing.Size(109, 31);
            this.lblRobot1.TabIndex = 6;
            this.lblRobot1.Text = "Robot 1";
            this.lblRobot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRobot2
            // 
            this.lblRobot2.AutoSize = true;
            this.lblRobot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblRobot2.Location = new System.Drawing.Point(664, 40);
            this.lblRobot2.Name = "lblRobot2";
            this.lblRobot2.Size = new System.Drawing.Size(109, 31);
            this.lblRobot2.TabIndex = 7;
            this.lblRobot2.Text = "Robot 2";
            this.lblRobot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblVs.Location = new System.Drawing.Point(577, 84);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(51, 39);
            this.lblVs.TabIndex = 8;
            this.lblVs.Text = "vs";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(422, 246);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(142, 39);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = "Siguiente Batalla";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(640, 246);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(146, 39);
            this.btnTerminar.TabIndex = 10;
            this.btnTerminar.Text = "Terminar Batalla";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click_1);
            // 
            // lblEquipo1
            // 
            this.lblEquipo1.AutoSize = true;
            this.lblEquipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblEquipo1.Location = new System.Drawing.Point(429, 87);
            this.lblEquipo1.Name = "lblEquipo1";
            this.lblEquipo1.Size = new System.Drawing.Size(97, 25);
            this.lblEquipo1.TabIndex = 11;
            this.lblEquipo1.Text = "Equipo 1";
            this.lblEquipo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquipo2
            // 
            this.lblEquipo2.AutoSize = true;
            this.lblEquipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblEquipo2.Location = new System.Drawing.Point(665, 87);
            this.lblEquipo2.Name = "lblEquipo2";
            this.lblEquipo2.Size = new System.Drawing.Size(97, 25);
            this.lblEquipo2.TabIndex = 12;
            this.lblEquipo2.Text = "Equipo 2";
            this.lblEquipo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMinisumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 632);
            this.Controls.Add(this.lblEquipo2);
            this.Controls.Add(this.lblEquipo1);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.lblRobot2);
            this.Controls.Add(this.lblRobot1);
            this.Controls.Add(this.nudRobot1);
            this.Controls.Add(this.nudRobot2);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lblBatallas);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.dgvParticipantes);
            this.Name = "frmMinisumo";
            this.Text = "Minisumo";
            this.Load += new System.EventHandler(this.frmMinisumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRobot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRobot1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label lblBatallas;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.NumericUpDown nudRobot2;
        private System.Windows.Forms.NumericUpDown nudRobot1;
        private System.Windows.Forms.Label lblRobot1;
        private System.Windows.Forms.Label lblRobot2;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label lblEquipo1;
        private System.Windows.Forms.Label lblEquipo2;
    }
}