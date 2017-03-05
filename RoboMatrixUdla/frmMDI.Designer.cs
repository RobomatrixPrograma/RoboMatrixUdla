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
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarRobotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megaSumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguidorDeLineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laberintoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaBatallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLlavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarLlavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.megaSumoToolStripMenuItem,
            this.seguidorDeLineaToolStripMenuItem,
            this.laberintoToolStripMenuItem});
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
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.archivoToolStripMenuItem.Text = "Configuracion";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaBatallaToolStripMenuItem,
            this.verLlavesToolStripMenuItem,
            this.generarLlavesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.reportesToolStripMenuItem.Text = "MiniSumo";
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
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // megaSumoToolStripMenuItem
            // 
            this.megaSumoToolStripMenuItem.Name = "megaSumoToolStripMenuItem";
            this.megaSumoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.megaSumoToolStripMenuItem.Text = "MegaSumo";
            // 
            // seguidorDeLineaToolStripMenuItem
            // 
            this.seguidorDeLineaToolStripMenuItem.Name = "seguidorDeLineaToolStripMenuItem";
            this.seguidorDeLineaToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.seguidorDeLineaToolStripMenuItem.Text = "Seguidor de Linea";
            // 
            // laberintoToolStripMenuItem
            // 
            this.laberintoToolStripMenuItem.Name = "laberintoToolStripMenuItem";
            this.laberintoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.laberintoToolStripMenuItem.Text = "Laberinto";
            // 
            // nuevaBatallaToolStripMenuItem
            // 
            this.nuevaBatallaToolStripMenuItem.Name = "nuevaBatallaToolStripMenuItem";
            this.nuevaBatallaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaBatallaToolStripMenuItem.Text = "Nueva Batalla";
            // 
            // verLlavesToolStripMenuItem
            // 
            this.verLlavesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.verLlavesToolStripMenuItem.Name = "verLlavesToolStripMenuItem";
            this.verLlavesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verLlavesToolStripMenuItem.Text = "Lllaves";
            // 
            // generarLlavesToolStripMenuItem
            // 
            this.generarLlavesToolStripMenuItem.Name = "generarLlavesToolStripMenuItem";
            this.generarLlavesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generarLlavesToolStripMenuItem.Text = "Resultados";
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generarToolStripMenuItem.Text = "Generar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verToolStripMenuItem.Text = "Ver";
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
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaBatallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLlavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarLlavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megaSumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguidorDeLineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laberintoToolStripMenuItem;
    }
}

