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
    public partial class frmIngresoEquipo : Form
    {
        public frmIngresoEquipo()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Archivo JPG|*.jpg";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pcbLogo.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void frmIngresoEquipo_Load(object sender, EventArgs e)
        {
            txtNombre.MaxLength = 50;
            txtPais.MaxLength = 25;
            txtLugar.MaxLength = 50;
            btnIngresar.Enabled = false;
        }

        private void habilitarBoton()
        {
            if (txtNombre.Text != "" && txtPais.Text!= "")
                btnIngresar.Enabled = true;
            else
                btnIngresar.Enabled = false;
        }
    }
}
