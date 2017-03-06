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
        }
        /*
        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Archivo JPG|*.jpg";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pcbLogo.Image = Image.FromFile(fileDialog.FileName);
            }
        }
        */

        private void frmIngresoEquipo_Load(object sender, EventArgs e)
        {
            txtNombre.MaxLength = 50;
            txtPais.MaxLength = 25;
            txtLugar.MaxLength = 50;
            txtId.Enabled = false;
            btnIngresarEquipo.Enabled = false;
            cargarDataGridView();
            cmbLugar.Enabled = false;
            cmbPais.Enabled = false;
        }

        private void habilitarBoton()
        {
            if (txtNombre.Text != "" && txtPais.Text!= "")
                btnIngresarEquipo.Enabled = true;
            else
                btnIngresarEquipo.Enabled = false;
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
            if (objN_Equipo.ingresarEquipo(nombre, pais, lugar))
                MessageBox.Show("Ingreso Correcto");
            else
                MessageBox.Show("Ingreso Incorrecto");
            cargarDataGridView();
        }

        private void btnHabilitarEquipo_Click(object sender, EventArgs e)
        {
            btnIngresarEquipo.Enabled = true;
            btnHabilitarEquipo.Enabled = false;
            btnModificarEquipo.Enabled = false;
            btnBorrarEquipo.Enabled = false;
            btnHabilitarModificaciones.Enabled = true;
            dgvEquipo.Enabled = false;            
            txtId.Clear();
            txtNombre.Clear();
            txtPais.Clear();
            txtLugar.Clear();
            cmbLugar.Enabled = false;
            cmbPais.Enabled = false;
        }

        private void btnHabilitarModificaciones_Click(object sender, EventArgs e)
        {
            btnHabilitarModificaciones.Enabled = false;
            btnIngresarEquipo.Enabled = false;
            btnHabilitarEquipo.Enabled = true;
            btnModificarEquipo.Enabled = true;
            btnBorrarEquipo.Enabled = true;
            dgvEquipo.Enabled = true;
            txtNombre.Clear();
            txtPais.Clear();
            txtLugar.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLugar.Enabled = true;
            string pais = cmbPais.SelectedText;
            cargarDataGridView(pais);
            cargarLugar(pais);
        }

        private void dgvEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvEquipo.CurrentRow.Cells["idEquipo"].Value.ToString();
            txtNombre.Text = (string)dgvEquipo.CurrentRow.Cells["nomEquipo"].Value;
            txtPais.Text= (string)dgvEquipo.CurrentRow.Cells["paisEquipo"].Value;
            txtLugar.Text = (string)dgvEquipo.CurrentRow.Cells["lugarEquipo"].Value;

        }

        private void cargarDataGridView()
        {
            try
            {
                ds = objN_Equipo.consultaEquipo();
                dgvEquipo.DataSource = ds;
                dgvEquipo.DataMember = "TblEquipo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar la informacion", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarDataGridView(string pais)
        {
            try
            {
                ds = objN_Equipo.consultaEquipo(pais);
                dgvEquipo.DataSource = ds;
                dgvEquipo.DataMember = "TblEquipo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar la informacion", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarDataGridView(string pais, string lugar)
        {
            try
            {
                ds = objN_Equipo.consultaEquipo(pais, lugar);
                dgvEquipo.DataSource = ds;
                dgvEquipo.DataMember = "TblEquipo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar la informacion", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarPais()
        {

            cmbPais.DataSource = objN_Equipo.N_consultaPais();
            cmbPais.ValueMember = "idEquipo";
            cmbPais.DisplayMember = "paisEquipo";
        }

        private void cargarLugar(string pais)
        {
            cmbLugar.DataSource = objN_Equipo.N_consutlaLugar();
            cmbLugar.ValueMember = "idEquipo";
            cmbLugar.DisplayMember = "lugarEquipo";
        }

        private void cmbLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pais = cmbPais.SelectedText;
            string lugar = cmbLugar.SelectedText;
            cargarDataGridView(pais, lugar);
        }

        private void btnAgregarFiltro_Click(object sender, EventArgs e)
        {
            cmbLugar.Enabled = true;
            cargarPais();
            cmbPais.Enabled = false;

        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            cmbLugar.Enabled = false;
            cmbPais.Enabled = false;
            cargarDataGridView();
        }
    }
}
