namespace RoboMatrixUdla
{
    partial class frmDrones
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
            this.btnEnviarTiempo = new System.Windows.Forms.Button();
            this.btnNuevoParticipante = new System.Windows.Forms.Button();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblCambiarEquipo = new System.Windows.Forms.Label();
            this.lblCambiarNombre = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblRobot = new System.Windows.Forms.Label();
            this.dgvPuntajes = new System.Windows.Forms.DataGridView();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviarTiempo
            // 
            this.btnEnviarTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarTiempo.Location = new System.Drawing.Point(311, 266);
            this.btnEnviarTiempo.Name = "btnEnviarTiempo";
            this.btnEnviarTiempo.Size = new System.Drawing.Size(117, 23);
            this.btnEnviarTiempo.TabIndex = 25;
            this.btnEnviarTiempo.Text = "Enviar Tiempo";
            this.btnEnviarTiempo.UseVisualStyleBackColor = true;
            this.btnEnviarTiempo.Click += new System.EventHandler(this.btnEnviarTiempo_Click);
            // 
            // btnNuevoParticipante
            // 
            this.btnNuevoParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoParticipante.Location = new System.Drawing.Point(311, 47);
            this.btnNuevoParticipante.Name = "btnNuevoParticipante";
            this.btnNuevoParticipante.Size = new System.Drawing.Size(117, 23);
            this.btnNuevoParticipante.TabIndex = 24;
            this.btnNuevoParticipante.Text = "Nuevo Participante";
            this.btnNuevoParticipante.UseVisualStyleBackColor = true;
            this.btnNuevoParticipante.Click += new System.EventHandler(this.btnNuevoParticipante_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(367, 177);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 23);
            this.txtTiempo.TabIndex = 23;
            // 
            // lblCambiarEquipo
            // 
            this.lblCambiarEquipo.AutoSize = true;
            this.lblCambiarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarEquipo.Location = new System.Drawing.Point(364, 137);
            this.lblCambiarEquipo.Name = "lblCambiarEquipo";
            this.lblCambiarEquipo.Size = new System.Drawing.Size(0, 17);
            this.lblCambiarEquipo.TabIndex = 22;
            // 
            // lblCambiarNombre
            // 
            this.lblCambiarNombre.AutoSize = true;
            this.lblCambiarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarNombre.Location = new System.Drawing.Point(365, 97);
            this.lblCambiarNombre.Name = "lblCambiarNombre";
            this.lblCambiarNombre.Size = new System.Drawing.Size(0, 17);
            this.lblCambiarNombre.TabIndex = 21;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(280, 180);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(59, 17);
            this.lblTiempo.TabIndex = 20;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(280, 137);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(56, 17);
            this.lblEquipo.TabIndex = 19;
            this.lblEquipo.Text = "Equipo:";
            // 
            // lblRobot
            // 
            this.lblRobot.AutoSize = true;
            this.lblRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRobot.Location = new System.Drawing.Point(280, 97);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(50, 17);
            this.lblRobot.TabIndex = 18;
            this.lblRobot.Text = "Robot:";
            // 
            // dgvPuntajes
            // 
            this.dgvPuntajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPuntajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntajes.Location = new System.Drawing.Point(483, 12);
            this.dgvPuntajes.Name = "dgvPuntajes";
            this.dgvPuntajes.Size = new System.Drawing.Size(545, 459);
            this.dgvPuntajes.TabIndex = 17;
            // 
            // dgvLista
            // 
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 12);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(243, 459);
            this.dgvLista.TabIndex = 16;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.Location = new System.Drawing.Point(280, 227);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(56, 17);
            this.lblPuntaje.TabIndex = 26;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntaje.Location = new System.Drawing.Point(367, 224);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(100, 23);
            this.txtPuntaje.TabIndex = 27;
            // 
            // frmDrones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 483);
            this.Controls.Add(this.txtPuntaje);
            this.Controls.Add(this.lblPuntaje);
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
            this.Name = "frmDrones";
            this.Text = "Drones";
            this.Load += new System.EventHandler(this.frmDrones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarTiempo;
        private System.Windows.Forms.Button btnNuevoParticipante;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblCambiarEquipo;
        private System.Windows.Forms.Label lblCambiarNombre;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblRobot;
        private System.Windows.Forms.DataGridView dgvPuntajes;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.TextBox txtPuntaje;
    }
}