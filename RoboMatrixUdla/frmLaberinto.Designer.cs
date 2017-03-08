namespace RoboMatrixUdla
{
    partial class frmLaberinto
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.dgvPuntajes = new System.Windows.Forms.DataGridView();
            this.lblRobot = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblCambiarNombre = new System.Windows.Forms.Label();
            this.lblCambiarEquipo = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.btnNuevoParticipante = new System.Windows.Forms.Button();
            this.btnEnviarTiempo = new System.Windows.Forms.Button();
            this.lblTiempo1 = new System.Windows.Forms.Label();
            this.lblTiempo2 = new System.Windows.Forms.Label();
            this.lblTiempo3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 12);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(192, 319);
            this.dgvLista.TabIndex = 0;
            // 
            // dgvPuntajes
            // 
            this.dgvPuntajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntajes.Location = new System.Drawing.Point(467, 12);
            this.dgvPuntajes.Name = "dgvPuntajes";
            this.dgvPuntajes.Size = new System.Drawing.Size(192, 319);
            this.dgvPuntajes.TabIndex = 1;
            // 
            // lblRobot
            // 
            this.lblRobot.AutoSize = true;
            this.lblRobot.Location = new System.Drawing.Point(252, 97);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(39, 13);
            this.lblRobot.TabIndex = 2;
            this.lblRobot.Text = "Robot:";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(252, 137);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(43, 13);
            this.lblEquipo.TabIndex = 3;
            this.lblEquipo.Text = "Equipo:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(252, 180);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(45, 13);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // lblCambiarNombre
            // 
            this.lblCambiarNombre.AutoSize = true;
            this.lblCambiarNombre.Location = new System.Drawing.Point(337, 97);
            this.lblCambiarNombre.Name = "lblCambiarNombre";
            this.lblCambiarNombre.Size = new System.Drawing.Size(0, 13);
            this.lblCambiarNombre.TabIndex = 5;
            // 
            // lblCambiarEquipo
            // 
            this.lblCambiarEquipo.AutoSize = true;
            this.lblCambiarEquipo.Location = new System.Drawing.Point(336, 137);
            this.lblCambiarEquipo.Name = "lblCambiarEquipo";
            this.lblCambiarEquipo.Size = new System.Drawing.Size(0, 13);
            this.lblCambiarEquipo.TabIndex = 6;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(339, 177);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 7;
            // 
            // btnNuevoParticipante
            // 
            this.btnNuevoParticipante.Location = new System.Drawing.Point(283, 47);
            this.btnNuevoParticipante.Name = "btnNuevoParticipante";
            this.btnNuevoParticipante.Size = new System.Drawing.Size(117, 23);
            this.btnNuevoParticipante.TabIndex = 8;
            this.btnNuevoParticipante.Text = "Nuevo Participante";
            this.btnNuevoParticipante.UseVisualStyleBackColor = true;
            this.btnNuevoParticipante.Click += new System.EventHandler(this.btnNuevoParticipante_Click);
            // 
            // btnEnviarTiempo
            // 
            this.btnEnviarTiempo.Location = new System.Drawing.Point(283, 231);
            this.btnEnviarTiempo.Name = "btnEnviarTiempo";
            this.btnEnviarTiempo.Size = new System.Drawing.Size(117, 23);
            this.btnEnviarTiempo.TabIndex = 9;
            this.btnEnviarTiempo.Text = "Enviar";
            this.btnEnviarTiempo.UseVisualStyleBackColor = true;
            this.btnEnviarTiempo.Click += new System.EventHandler(this.btnEnviarTiempo_Click);
            // 
            // lblTiempo1
            // 
            this.lblTiempo1.AutoSize = true;
            this.lblTiempo1.Location = new System.Drawing.Point(236, 279);
            this.lblTiempo1.Name = "lblTiempo1";
            this.lblTiempo1.Size = new System.Drawing.Size(0, 13);
            this.lblTiempo1.TabIndex = 10;
            // 
            // lblTiempo2
            // 
            this.lblTiempo2.AutoSize = true;
            this.lblTiempo2.Location = new System.Drawing.Point(322, 279);
            this.lblTiempo2.Name = "lblTiempo2";
            this.lblTiempo2.Size = new System.Drawing.Size(0, 13);
            this.lblTiempo2.TabIndex = 11;
            // 
            // lblTiempo3
            // 
            this.lblTiempo3.AutoSize = true;
            this.lblTiempo3.Location = new System.Drawing.Point(402, 279);
            this.lblTiempo3.Name = "lblTiempo3";
            this.lblTiempo3.Size = new System.Drawing.Size(0, 13);
            this.lblTiempo3.TabIndex = 12;
            // 
            // frmLaberinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 343);
            this.Controls.Add(this.lblTiempo3);
            this.Controls.Add(this.lblTiempo2);
            this.Controls.Add(this.lblTiempo1);
            this.Controls.Add(this.btnEnviarTiempo);
            this.Controls.Add(this.btnNuevoParticipante);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.lblCambiarEquipo);
            this.Controls.Add(this.lblCambiarNombre);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.lblRobot);
            this.Controls.Add(this.dgvPuntajes);
            this.Controls.Add(this.dgvLista);
            this.Name = "frmLaberinto";
            this.Text = "Laberinto";
            this.Load += new System.EventHandler(this.frmLaberinto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridView dgvPuntajes;
        private System.Windows.Forms.Label lblRobot;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblCambiarNombre;
        private System.Windows.Forms.Label lblCambiarEquipo;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Button btnNuevoParticipante;
        private System.Windows.Forms.Button btnEnviarTiempo;
        private System.Windows.Forms.Label lblTiempo1;
        private System.Windows.Forms.Label lblTiempo2;
        private System.Windows.Forms.Label lblTiempo3;
    }
}