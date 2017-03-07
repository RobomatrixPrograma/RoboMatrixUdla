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
        clsN_Equipo N_objEquipo = new clsN_Equipo();
        clsN_Categoria N_objCategoria = new clsN_Categoria();
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
            cmbEquipo.DataSource = N_objEquipo.consultaEquipo2();
            cmbEquipo.ValueMember = "idEquipo";
            cmbEquipo.DisplayMember = "nomEquipo";
        }
        private void cargarCombo2()
        {
            cmbCategoria.DataSource = N_objCategoria.N_consultaCategoria();
            cmbCategoria.ValueMember = "idCat";
            cmbCategoria.DisplayMember = "nomCat";
        }
        private void frmIngresoRobot_Load(object sender, EventArgs e)
        {
            try
            {
                consultaRobot();
                cargarCombo();
                cargarCombo2();
                cmbCategoria.SelectedIndex = 0;
                cmbEstado.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("ERROR EN LA CONSULTA");
            }

            a = 1;
        }

        private void btnIngresarRobot_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && (cmbEstado.Text == "ACTIVO" || cmbEstado.Text == "DESACTIVADO"))
            {
                try
                {
                    if (N_objRobot.N_IngresarRobot(int.Parse(txtIdRobot.Text),txtNombre.Text,cmbEstado.Text,txtlider.Text,int.Parse(cmbCategoria.SelectedValue.ToString()),int.Parse(cmbEquipo.SelectedValue.ToString())))
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
            
            btnHabilitarRobot.Enabled = true;
        }

        private void btnModificarRobot_Click(object sender, EventArgs e)
        {
            try
            {
                if (N_objRobot.N_ActualizarRobot(int.Parse(txtIdRobot.Text), txtNombre.Text, cmbEstado.Text, txtlider.Text, int.Parse(cmbCategoria.SelectedValue.ToString()), int.Parse(cmbEquipo.SelectedValue.ToString())))
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
            txtIdRobot.Enabled = true;
        }

        private void btnHabilitarModificaciones_Click(object sender, EventArgs e)
        {
            btnIngresarRobot.Enabled = false;
            btnHabilitarRobot.Enabled = true;
            btnModificarRobot.Enabled = true;
            btnBorrarRobot.Enabled = true;
            txtIdRobot.Enabled = true;
            txtIdRobot.Text = "";
            txtNombre.Clear();
        }

        private void btnHabilitarRobot_Click(object sender, EventArgs e)
        {
            btnIngresarRobot.Enabled = true;
            btnHabilitarRobot.Enabled = false;
            btnModificarRobot.Enabled = false;
            btnBorrarRobot.Enabled = false;
            txtIdRobot.Enabled = true;
            txtIdRobot.Text = "";
            txtNombre.Clear();
            
        }

        private void cmbIdRobot_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBorrarRobot_Click(object sender, EventArgs e)
        {
            try
            {
                if (N_objRobot.N_EliminarRobot(int.Parse(txtIdRobot.Text)))
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
            txtIdRobot.Enabled = true;
        }

        private void dgvRobot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                
                 dgvRobot.DataSource = N_objRobot.N_consultaRobotPorNombre(txtFiltroNombre.Text);
           
            }
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            consultaRobot();
        }

        private void dgvRobot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnIngresarRobot.Enabled = false;
            btnHabilitarRobot.Enabled = true;
            btnModificarRobot.Enabled = true;
            btnBorrarRobot.Enabled = true;
            txtIdRobot.Enabled = true;
            txtIdRobot.Text = "";
            txtNombre.Clear();
            int b = int.Parse(dgvRobot.CurrentRow.Cells[0].Value.ToString());
            if (a == 1)
            {
                ds = N_objRobot.N_consultaRobot(b);
                txtIdRobot.Text = ds.Tables[0].Rows[0]["idRobot"].ToString();
                txtNombre.Text = ds.Tables[0].Rows[0]["nomRobot"].ToString();
                cmbEstado.Text = ds.Tables[0].Rows[0]["estadoRobot"].ToString();
                txtlider.Text = ds.Tables[0].Rows[0]["liderRobot"].ToString();
                cmbCategoria.Text = N_objCategoria.consultaCategoria(int.Parse(ds.Tables[0].Rows[0]["idCategoria"].ToString()));

                cmbEquipo.Text = ds.Tables[0].Rows[0]["idEquipo"].ToString();
                txtIdRobot.Enabled = false;
                btnIngresarRobot.Enabled = false;
            }
        }
    }
}
