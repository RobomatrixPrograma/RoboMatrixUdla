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
        clsN_Equipo objN_Equipo = new clsN_Equipo();
        DataSet ds = new DataSet();
        public frmIngresoEquipo()
        {
            InitializeComponent();
            limpiar();
        }

        private void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPais.Clear();
            txtLugar.Clear();
        }

        private void frmIngresoEquipo_Load(object sender, EventArgs e)
        {
            txtNombre.MaxLength = 50;
            txtPais.MaxLength = 25;
            txtLugar.MaxLength = 50;
            txtId.Enabled = false;
            btnIngresarEquipo.Enabled = false;
            btnModificarEquipo.Enabled = false;
            btnBorrarEquipo.Enabled = false;
            dgvEquipo.Enabled = true;
            cargarDataGridView();
            txtNombre.Enabled = false;
            txtPais.Enabled = false;
            txtLugar.Enabled = false;
            txtPais.CharacterCasing = CharacterCasing.Upper;
        }
        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPais.Text != "" && btnModificarEquipo.Enabled == false)
            {
                string nombre = txtNombre.Text;
                string pais = txtPais.Text;
                string lugar = txtLugar.Text;
                if (objN_Equipo.ingresarEquipo(nombre, pais, lugar))
                    MessageBox.Show("Ingreso Correcto");
                else
                    MessageBox.Show("Ingreso Incorrecto");
                cargarDataGridView();
                btnHabilitarIngreso.Enabled = true;
                txtNombre.Enabled = false;
                txtPais.Enabled = false;
                txtLugar.Enabled = false;
                limpiar();
            }
            else
                MessageBox.Show("Llene todos los campos");
        }

        private void btnHabilitarEquipo_Click(object sender, EventArgs e)
        {
            btnIngresarEquipo.Enabled = true;
            btnHabilitarIngreso.Enabled = false;
            btnModificarEquipo.Enabled = false;
            btnBorrarEquipo.Enabled = false;
            limpiar();
            txtNombre.Enabled = true;
            txtPais.Enabled = true;
            txtLugar.Enabled = true;
        }
        

        private void HabilitarModificaciones()
        {
            btnHabilitarIngreso.Enabled = true;
            btnIngresarEquipo.Enabled = false;
            btnHabilitarIngreso.Enabled = true;
            btnModificarEquipo.Enabled = true;
            btnBorrarEquipo.Enabled = true;
            txtNombre.Enabled = true;
            txtLugar.Enabled = true;
            txtPais.Enabled = true;
        }

        private void cargarDataGridView()
        {
            try
            {
                dgvEquipo.DataSource = objN_Equipo.consultaEquipoPresentacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar la informacion", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        
        private void btnModificarEquipo_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPais.Text != "")
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                string pais = txtPais.Text;
                string lugar = txtLugar.Text;
                if (objN_Equipo.actualizarEquipo(id, nombre, pais, lugar))
                    MessageBox.Show("Actualización Correcto");
                else
                    MessageBox.Show("Actualización Incorrecto");
                limpiar();
                cargarDataGridView();
                txtId.Enabled = false;
                btnIngresarEquipo.Enabled = false;
                btnModificarEquipo.Enabled = false;
                btnBorrarEquipo.Enabled = false;
                dgvEquipo.Enabled = true;
                txtNombre.Enabled = false;
                txtPais.Enabled = false;
                txtLugar.Enabled = false;
            }
            else
                MessageBox.Show("Llene todos los campos");

        }

        private void dgvEquipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarModificaciones();
            limpiar();
            txtId.Text = dgvEquipo.CurrentRow.Cells["Código_Equipo"].Value.ToString();
            txtNombre.Text = (string)dgvEquipo.CurrentRow.Cells["Nombre"].Value;
            txtPais.Text = (string)dgvEquipo.CurrentRow.Cells["País"].Value;
            txtLugar.Text = (string)dgvEquipo.CurrentRow.Cells["Universidad"].Value;
        }

        private void btnBorrarEquipo_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            if (objN_Equipo.borrarEquipo(id))
                MessageBox.Show("Eliminación Correcto");
            else
                MessageBox.Show("Eliminación Incorrecto");

            cargarDataGridView();
            limpiar();
            txtId.Enabled = false;
            btnIngresarEquipo.Enabled = false;
            btnModificarEquipo.Enabled = false;
            btnBorrarEquipo.Enabled = false;
            dgvEquipo.Enabled = true;
            txtNombre.Enabled = false;
            txtPais.Enabled = false;
            txtLugar.Enabled = false;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvEquipo.DataSource = objN_Equipo.consultaPorNombre(txtFiltro.Text);
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            cargarDataGridView();
            txtFiltro.Clear();
        }
    }
}
