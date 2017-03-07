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
    public partial class frmGenerarOrden : Form
    {
        clsN_Categoria N_Categoria = new clsN_Categoria();
        public frmGenerarOrden()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnGenerar.Enabled = false;
            int id = int.Parse(cmbCategoria.SelectedValue.ToString());
            string nom = cmbCategoria.SelectedItem.ToString();
            var cat = N_Categoria.GenerarOrden(id,nom);
            dgvOrden.DataSource = cat.ToList();

        }
        private void cargarCategorias()
        {
            var cat = N_Categoria.N_consultaCategoria(2);
            cmbCategoria.DataSource = cat;
            cmbCategoria.DisplayMember = "nomCat";
            cmbCategoria.ValueMember = "idCat";
        }

        private void frmGenerarOrden_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }
    }
}
