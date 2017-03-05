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
    public partial class frmIngresoRobot : Form
    {
        clsNRobot N_objRobot = new clsNRobot();
        DataSet ds = new DataSet();
        int a = 0;
        public frmIngresoRobot()
        {
            InitializeComponent();
        }
        private void consultaRobot()
        {
            dgvRobot.DataSource = N_objRobot.N_consultaRobot();
        }
        private void cargarCombo()
        {
            cmbIdRobot.DataSource = N_objRobot.N_consultaRobot();
            cmbIdRobot.ValueMember = "idRobot";
            cmbIdRobot.DisplayMember = "nomRobot";
        }
        private void frmIngresoRobot_Load(object sender, EventArgs e)
        {
            try
            {
                consultaRobot();
                cargarCombo();
            }
            catch
            {
                MessageBox.Show("ERROR EN LA CONSULTA DE CATEGORÍAS");
            }

            a = 1;
        }

        private void btnIngresarRobot_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && (cmbEstado.Text == "ACTIVO" || cmbEstado.Text == "DESACTIVADO"))
            {
                try
                {
                    if (N_objRobot.N_IngresarRobot(txtNombre.Text, cmbEstado.Text))
                    {
                        MessageBox.Show("INGRESO CORRECTO");
                    }
                    else
                    {
                        MessageBox.Show("INGRESO INCORRECTO");
                    }
                }
                catch
                {
                    MessageBox.Show("INGRESO INCORRECTO");
                }

                try
                {
                    consultaRobot();
                    cargarCombo();
                }
                catch
                {
                    MessageBox.Show("ERROR EN LA CONSULTA DE ROBOTS");
                }
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("INGRESE EL NOMBRE");
            }

            else if (cmbEstado.Text != "ACTIVO" || cmbEstado.Text != "DESACTIVADO")
            {
                MessageBox.Show("ESTADO DESCONOCIDO");
            }
            

            btnHabilitarModificaciones.Enabled = true;
            btnHabilitarRobot.Enabled = true;
        }

        private void btnModificarRobot_Click(object sender, EventArgs e)
        {
            try
            {
                if (N_objRobot.N_ActualizarRobot(int.Parse(cmbIdRobot.SelectedValue.ToString()), txtNombre.Text, cmbEstado.Text))
                {
                    MessageBox.Show("ACTUALIZACION CORRECTA");
                }
                else
                {
                    MessageBox.Show("ACTUALIZACION INCORRECTA");
                }
            }
            catch
            {
                MessageBox.Show("ACTUALIZACION INCORRECTA");
            }
            try
            {
                consultaRobot();
                cargarCombo();
            }
            catch
            {
                MessageBox.Show("ERROR EN LA CONSULTA DE CATEGORÍAS");
            }
            cmbIdRobot.Enabled = true;
        }

        private void btnHabilitarModificaciones_Click(object sender, EventArgs e)
        {
            btnHabilitarModificaciones.Enabled = false;
            btnIngresarRobot.Enabled = false;
            btnHabilitarRobot.Enabled = true;
            btnModificarRobot.Enabled = true;
            btnBorrarRobot.Enabled = true;
            cmbIdRobot.Enabled = true;
            cmbIdRobot.Text = "";
            txtNombre.Clear();
        }

        private void btnHabilitarRobot_Click(object sender, EventArgs e)
        {
            btnIngresarRobot.Enabled = true;
            btnHabilitarRobot.Enabled = false;
            btnModificarRobot.Enabled = false;
            btnBorrarRobot.Enabled = false;
            cmbIdRobot.Enabled = false;
            cmbIdRobot.Text = "";
            txtNombre.Clear();
            btnHabilitarModificaciones.Enabled = true;
        }

        private void cmbIdRobot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {
                btnHabilitarModificaciones.Enabled = false;
                ds = N_objRobot.N_consultaRobot(int.Parse(cmbIdRobot.SelectedValue.ToString()));
                cmbIdRobot.Text = ds.Tables[0].Rows[0]["idRobot"].ToString();
                txtNombre.Text = ds.Tables[0].Rows[0]["nomRobot"].ToString();
                cmbEstado.Text = ds.Tables[0].Rows[0]["estadoRobot"].ToString();
                cmbIdRobot.Enabled = false;
                btnIngresarRobot.Enabled = false;
            }
        }

        private void btnBorrarRobot_Click(object sender, EventArgs e)
        {
            try
            {
                if (N_objRobot.N_EliminarRobot(int.Parse(cmbIdRobot.SelectedValue.ToString())))
                {
                    MessageBox.Show("ELIMINACION CORRECTA");
                }
                else
                {
                    MessageBox.Show("ELIMINACION INCORRECTA");
                }
            }
            catch
            {
                MessageBox.Show("ELIMINACION INCORRECTA");
            }

            try
            {
                consultaRobot();
                cargarCombo();
            }
            catch
            {
                MessageBox.Show("ERROR EN LA CONSULTA DE CATEGORÍAS");
            }
            cmbIdRobot.Enabled = true;
        }
    }
}
