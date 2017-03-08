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
    public partial class frmIngresarLlaves : Form
    {
        clsN_Llaves N_llaves = new clsN_Llaves();
        clsN_Categoria N_Categoria = new clsN_Categoria();
        clsNRobot N_Robot = new clsNRobot();
        public frmIngresarLlaves()
        {
            InitializeComponent();
        }

        private void frmGenerarLlaves_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            cmbRobot1.Enabled = false;
            cmbRobot2.Enabled = false;
            btnGenerar.Enabled = false;
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
            int idr1 = int.Parse(cmbRobot1.SelectedValue.ToString());
            int idr2 = int.Parse(cmbRobot2.SelectedValue.ToString());
            string nom1 = cmbRobot1.SelectedItem.ToString();
            string nom2 = cmbRobot2.SelectedItem.ToString();
            string cat = cmbCategoria.SelectedText.ToString();
            if(idr1 != idr2)
            {

                if (N_llaves.N_ingresarCategoria(cat, idr1, idr2, nom1, nom2))
                    MessageBox.Show("Ingreso Correcto");
                else
                    MessageBox.Show("Ingreso Incorrecto");
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cargarRobot1(int cat)
        {
            var robot = N_Robot.N_consultaRobotCat(cat);
            if (robot != null)
            {
                cmbRobot1.DataSource = robot;
                cmbRobot1.DisplayMember = "nomRobot";
                cmbRobot1.ValueMember = "idRobot";

            }
        }

        private void cmbRobot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerar.Enabled = true;
        }

        private void cmbRobot1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbCategoria_Click(object sender, EventArgs e)
        {
            int cat = int.Parse(cmbCategoria.SelectedValue.ToString());
            cargarRobot1(cat);
            cmbRobot1.Enabled = true;
            cmbRobot2.Enabled = false;

        }

        private void cmbRobot2_Click(object sender, EventArgs e)
        {
        }

        private void cmbRobot1_Click(object sender, EventArgs e)
        {
            int idR = int.Parse(cmbRobot1.SelectedValue.ToString());
            cargarRobot2(idR);
            cmbRobot2.Enabled = true;
        }

        private void cargarRobot2(int idR)
        {
            var robot = N_Robot.N_consultaRobotExcepto(idR);
            cmbRobot2.DataSource = robot;
            cmbRobot2.DisplayMember = "nomRobot";
            cmbRobot2.ValueMember = "idRobot";
        }
    }
}
