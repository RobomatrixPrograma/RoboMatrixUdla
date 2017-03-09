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
    public partial class frmIngresarOrden : Form
    {
        clsN_Categoria N_Categoria = new clsN_Categoria();
        clsN_OrdenLlaves N_OrdenLlaves = new clsN_OrdenLlaves();
        clsNRobot N_Robot = new clsNRobot();
        public frmIngresarOrden()
        {
            InitializeComponent();
            btnGenerar.Enabled = false;
            btnSeleccionar.Enabled = true;
            cmbCategoria.Enabled = false;
            cmbRobot.Enabled = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnGenerar.Enabled = false;
            int idC = int.Parse(cmbCategoria.SelectedValue.ToString());
            int idR = int.Parse(cmbRobot.SelectedValue.ToString());
            if(N_OrdenLlaves.N_ingresarCategoria(idC,idR))
                MessageBox.Show("Ingreso Correcto");  
            else
                MessageBox.Show("Ingreso Incorrecto");
            int cat = int.Parse(cmbCategoria.SelectedValue.ToString());
            consultaCategoria(cat);

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

        private void cmbCategoria_DropDownClosed(object sender, EventArgs e)
        {
            int cat = int.Parse(cmbCategoria.SelectedValue.ToString());
            cargarRobot1(cat);
            consultaCategoria(cat);
            cmbRobot.Enabled = true;
            cmbCategoria.Enabled = false;
        }
        private void cargarRobot1(int cat)
        {
            var robot = N_Robot.N_consultaRobotCat(cat);
            if (robot != null)
            {
                cmbRobot.DataSource = robot;
                cmbRobot.DisplayMember = "nomRobot";
                cmbRobot.ValueMember = "idRobot";
            }
        }
        private void consultaCategoria(int cat)
        {
            try
            {
                var Orden = N_OrdenLlaves.consultaCategorias(cat);
                dgvOrden.DataSource = Orden;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar la informacion", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            cmbCategoria.Enabled = true;
        }

        private void cmbRobot_DropDownClosed(object sender, EventArgs e)
        {
            btnGenerar.Enabled = true;
        }
    }
}
