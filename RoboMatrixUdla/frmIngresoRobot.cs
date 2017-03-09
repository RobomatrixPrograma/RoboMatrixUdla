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
            dgvRobot.DataSource = N_objRobot.N_consultaRobotPresentacion();
            
        }

        private void cargarCombo()
        {
            cmbEquipo.DataSource = N_objEquipo.consultaEquipo();
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
                Limpiar();
                cmbCategoria.SelectedIndex = 0;
                cmbEstado.SelectedIndex = 0;
                txtNombre.MaxLength = 50;
                txtlider.MaxLength = 25;
                btnBorrarRobot.Enabled = false;
                btnModificarRobot.Enabled = false;
                btnIngresarRobot.Enabled = false;
                btnHabilitarRobot.Enabled = true;
                txtlider.Enabled = false;
                txtIdRobot.Enabled = false;
                txtNombre.Enabled = false;
                cmbCategoria.Enabled = false;
                cmbEquipo.Enabled = false;
                cmbEstado.Enabled = false;

            }
            catch
            {
                MessageBox.Show("ERROR EN LA CONSULTA");
            }

            a = 1;
        }

        private void btnIngresarRobot_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != ""  && txtIdRobot.Text != "" )
            {
                try
                {
                    if (N_objRobot.N_IngresarRobot(int.Parse(txtIdRobot.Text),txtNombre.Text,cmbEstado.SelectedIndex.ToString(),txtlider.Text,int.Parse(cmbCategoria.SelectedValue.ToString()),int.Parse(cmbEquipo.SelectedValue.ToString())))
                    {
                        MessageBox.Show("INGRESO CORRECTO");
                        Limpiar();
                        txtlider.Enabled = false;
                        txtIdRobot.Enabled = false;
                        txtNombre.Enabled = false;
                        cmbCategoria.Enabled = false;
                        cmbEquipo.Enabled = false;
                        cmbEstado.Enabled = false;
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
            else if (txtNombre.Text == "" || txtIdRobot.Text == "")
            {
                MessageBox.Show("Llene todos los campos");
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
                if(txtNombre.Text!= "" && txtIdRobot.Text != "")
                {
                    if (N_objRobot.N_ActualizarRobot(int.Parse(txtIdRobot.Text), txtNombre.Text, cmbEstado.SelectedIndex.ToString(), txtlider.Text, int.Parse(cmbCategoria.SelectedValue.ToString()), int.Parse(cmbEquipo.SelectedValue.ToString())))
                    {
                        MessageBox.Show("ACTUALIZACION CORRECTA");
                        Limpiar();
                        txtlider.Enabled = false;
                        txtIdRobot.Enabled = false;
                        txtNombre.Enabled = false;
                        cmbCategoria.Enabled = false;
                        cmbEquipo.Enabled = false;
                        cmbEstado.Enabled = false;
                    }
                    else
                        MessageBox.Show("ACTUALIZACION INCORRECTA");
                }
                else
                    MessageBox.Show("Llene todos los campos");
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
        }

        private void btnHabilitarModificaciones_Click(object sender, EventArgs e)
        {
            habilitarModificaciones();
        }

        private void habilitarModificaciones()
        {
            btnIngresarRobot.Enabled = false;
            btnHabilitarRobot.Enabled = true;
            btnModificarRobot.Enabled = true;
            btnBorrarRobot.Enabled = true;
            btnHabilitarRobot.Enabled = true;
            Limpiar();
            txtlider.Enabled = true;
            txtIdRobot.Enabled = true;
            txtNombre.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbEquipo.Enabled = true;
            cmbEstado.Enabled = true;
        }

        private void btnHabilitarRobot_Click(object sender, EventArgs e)
        {
            btnIngresarRobot.Enabled = true;
            btnHabilitarRobot.Enabled = false;
            btnModificarRobot.Enabled = false;
            btnBorrarRobot.Enabled = false;
            txtIdRobot.Enabled = true;
            Limpiar();
            txtlider.Enabled = true;
            txtIdRobot.Enabled = true;
            txtNombre.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbEquipo.Enabled = true;
            cmbEstado.Enabled = true;
        }

        private void Limpiar()
        {
            txtIdRobot.Clear();
            txtlider.Clear();
            txtNombre.Clear();
            txtFiltroNombre.Clear();
            cargarCombo();
            cargarCombo2();
            cmbCategoria.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
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
                    Limpiar();
                    txtlider.Enabled = false;
                    txtIdRobot.Enabled = false;
                    txtNombre.Enabled = false;
                    cmbCategoria.Enabled = false;
                    cmbEquipo.Enabled = false;
                    cmbEstado.Enabled = false;
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
        }

        private void dgvRobot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltroNombre.Clear();
            consultaRobot();
        }

        private void dgvRobot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarModificaciones();
            int b = int.Parse(dgvRobot.CurrentRow.Cells[0].Value.ToString());
            if (a == 1)
            {
                ds = N_objRobot.N_consultaRobot(b);
                txtIdRobot.Text = ds.Tables[0].Rows[0]["idRobot"].ToString();
                txtNombre.Text = ds.Tables[0].Rows[0]["nomRobot"].ToString();
                if(ds.Tables[0].Rows[0]["estadoRobot"].ToString()=="AC")
                {
                    cmbEstado.SelectedIndex = 0;
                }
                else
                {
                    cmbEstado.SelectedIndex = 1;
                }

                txtlider.Text = ds.Tables[0].Rows[0]["liderRobot"].ToString();
                cmbCategoria.Text = N_objCategoria.consultaCategoria(int.Parse(ds.Tables[0].Rows[0]["idCategoria"].ToString()));

                cmbEquipo.Text = ds.Tables[0].Rows[0]["idEquipo"].ToString();
                txtIdRobot.Enabled = false;
                btnIngresarRobot.Enabled = false;
            }
        }

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            dgvRobot.DataSource = N_objRobot.N_consultaRobotPorNombre(txtFiltroNombre.Text);
        }
    }
}
