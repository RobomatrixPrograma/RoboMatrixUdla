using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboMatrixUdla
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }


        private void ingresarRobotToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIngresoEquipo objIngresoEquipo = new frmIngresoEquipo();
            objIngresoEquipo.MdiParent = this;
            objIngresoEquipo.Show();

        }

        private void ingresarRobotToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmIngresoRobot objIngresoRobot = new frmIngresoRobot();
            objIngresoRobot.MdiParent = this;
            objIngresoRobot.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmIngresarLlaves objIngresoLlaves = new frmIngresarLlaves();
            objIngresoLlaves.MdiParent = this;
            objIngresoLlaves.Show();
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresarOrden objIngresoOrden = new frmIngresarOrden();
            objIngresoOrden.MdiParent = this;
            objIngresoOrden.Show();
        }

        private void seguidorDeLíneaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeguidorLinea objSeguidorLinea = new frmSeguidorLinea();
            objSeguidorLinea.Show();
        }

        private void seguidorDeLíneaLegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeguidorLego objSeguidorLego = new frmSeguidorLego();
            objSeguidorLego.Show();
        }

        private void laberintoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaberinto objLaberinto = new frmLaberinto();
            objLaberinto.Show();
        }

        private void minisumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMinisumo objMinisumo = new frmMinisumo();
            objMinisumo.Show();
        }

        private void dronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrones objDron = new frmDrones();
            objDron.Show();
        }

        private void megasumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMegasumo objMegasumo = new frmMegasumo();
            objMegasumo.Show();
        }
    }
}
