namespace RoboMatrixUdla
{
    partial class frmMDI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarRobotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeParticipacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarEquipoToolStripMenuItem,
            this.ingresarRobotToolStripMenuItem,
            this.llavesToolStripMenuItem,
            this.ordenDeParticipacionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.archivoToolStripMenuItem.Text = "Configuracion";
            // 
            // ingresarEquipoToolStripMenuItem
            // 
            this.ingresarEquipoToolStripMenuItem.Name = "ingresarEquipoToolStripMenuItem";
            this.ingresarEquipoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ingresarEquipoToolStripMenuItem.Text = "Ingresar Equipo";
            this.ingresarEquipoToolStripMenuItem.Click += new System.EventHandler(this.ingresarEquipoToolStripMenuItem_Click);
            // 
            // ingresarRobotToolStripMenuItem
            // 
            this.ingresarRobotToolStripMenuItem.Name = "ingresarRobotToolStripMenuItem";
            this.ingresarRobotToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ingresarRobotToolStripMenuItem.Text = "Ingresar Robot";
            this.ingresarRobotToolStripMenuItem.Click += new System.EventHandler(this.ingresarRobotToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // llavesToolStripMenuItem
            // 
            this.llavesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem1,
            this.generarToolStripMenuItem1});
            this.llavesToolStripMenuItem.Name = "llavesToolStripMenuItem";
            this.llavesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.llavesToolStripMenuItem.Text = "Llaves";
            // 
            // ordenDeParticipacionToolStripMenuItem
            // 
            this.ordenDeParticipacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.generarToolStripMenuItem});
            this.ordenDeParticipacionToolStripMenuItem.Name = "ordenDeParticipacionToolStripMenuItem";
            this.ordenDeParticipacionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ordenDeParticipacionToolStripMenuItem.Text = "Orden de Participacion";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generarToolStripMenuItem.Text = "Generar";
            // 
            // verToolStripMenuItem1
            // 
            this.verToolStripMenuItem1.Name = "verToolStripMenuItem1";
            this.verToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.verToolStripMenuItem1.Text = "Ver";
            // 
            // generarToolStripMenuItem1
            // 
            this.generarToolStripMenuItem1.Name = "generarToolStripMenuItem1";
            this.generarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.generarToolStripMenuItem1.Text = "Generar";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 618);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robomatrix UDLA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarRobotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem llavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordenDeParticipacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
    }
}

