using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace RoboMatrixUdla
{
    public partial class frmIngresoEquipo : Form
    {
        clsN_IngresoEquipo objN_IngresoEquipo = new clsN_IngresoEquipo();
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            habilitarBoton();
        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {
            habilitarBoton();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string pais = txtPais.Text;
            string lugar = txtLugar.Text;
            Image logo = pcbLogo.Image;
            Image = Imag
            if (objN_IngresoEquipo.ingresarEquipo(nombre, pais, lugar, logo))
                MessageBox.Show("Ingreso Correcto");
            else
                MessageBox.Show("Ingreso Incorrecto");
        }
    }
}
