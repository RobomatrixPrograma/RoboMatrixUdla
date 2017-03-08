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
        int a = 0;
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
            a = 1;

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
            if (N_llaves.N_ingresarCategoria(cat, idr1, idr2, nom1, nom2)) ;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarRobot1();
            cmbRobot1.Enabled = true;
            cmbRobot2.Enabled = false;
        }

        private void cargarRobot1()
        {
            var robot = N_Robot.N_consultaRobot();
            cmbRobot1.DataSource = robot;
            cmbRobot1.DisplayMember = "nomRobot";
            cmbRobot1.ValueMember = "idRobot";
            cmbRobot1.SelectedIndex = 0;
        }

        private void cargarRobot2()
        {
            if(a==1)
            {
                var robot = N_Robot.N_consultaRobot();
                cmbRobot2.DataSource = robot;
                cmbRobot2.DisplayMember = "nomRobot";
                cmbRobot2.ValueMember = "idRobot";
                cmbRobot2.SelectedIndex = 0;

            }

        }
        
        private void cmbRobot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerar.Enabled = true;
        }

        private void cmbRobot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {
                cargarRobot2();
                //cmbRobot2.Items.Remove(cmbRobot1.SelectedItem);
                cmbRobot2.Enabled = true;
            }
            
        }
    }
}
