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

        private void ingresarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoEquipo objIngresoEquipo = new frmIngresoEquipo();
            objIngresoEquipo.MdiParent = this;
            objIngresoEquipo.Show();
        }

        private void ingresarRobotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoRobot objIngresoRobot = new frmIngresoRobot();
            objIngresoRobot.MdiParent = this;
            objIngresoRobot.Show();
        }
    }
}
