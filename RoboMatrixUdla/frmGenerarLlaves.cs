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
    public partial class frmGenerarLlaves : Form
    {
        clsN_Categoria N_Categoria = new clsN_Categoria();
        public frmGenerarLlaves()
        {
            InitializeComponent();
        }

        private void frmGenerarLlaves_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void cargarCategorias()
        {
            var cat = N_Categoria.N_consultaCategoria(1);
            cmbCategoria.DataSource = cat;
            cmbCategoria.DisplayMember = "nomCat";
            cmbCategoria.ValueMember = "idCat";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmbCategoria.SelectedValue.ToString());
        }
    }
}
