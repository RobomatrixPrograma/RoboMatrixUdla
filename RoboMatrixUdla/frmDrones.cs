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
    public partial class frmDrones : Form
    {
        public frmDrones()
        {
            InitializeComponent();
        }
        clsNDron N_objDron = new clsNDron();
        clsNPuntajeDron N_objPuntajeDron = new clsNPuntajeDron();
        DataSet ds = new DataSet();
        int a = 0;
        int id = 0, idBatallla = 0;
        private void consultaLista()
        {
            dgvLista.DataSource = N_objDron.N_consultaLista();

        }
        private void consultaPuntajes()
        {
            dgvPuntajes.DataSource = N_objPuntajeDron.N_consultaLista();

        }

        private void btnNuevoParticipante_Click(object sender, EventArgs e)
        {
            try
            {
                id = N_objDron.N_consultaListaID();
                idBatallla = N_objDron.N_consultaListaIDBatalla();
                MessageBox.Show("Participante " + N_objDron.N_consultaListaParticipante() + " listo para comenzar");
                lblCambiarNombre.Text = N_objDron.N_consultaListaParticipante();
                lblCambiarEquipo.Text = N_objDron.N_consultaListaParticipante2();
                if (!(N_objDron.actualizarEstado(idBatallla)))
                {
                    MessageBox.Show("FALLA EN EL INGRESO DEL PARTICIPANTE");
                }
                consultaLista();
                btnEnviarTiempo.Enabled = true;
            }
            catch
            {
                MessageBox.Show("NO EXISTEN PARTICIPANTES EN COLA");
            }
        }

        private void btnEnviarTiempo_Click(object sender, EventArgs e)
        {
            if (txtTiempo.Text != "" && txtPuntaje.Text!="")
            {
                if (N_objPuntajeDron.N_IngresarPuntaje(idBatallla, decimal.Parse(txtTiempo.Text), int.Parse(txtPuntaje.Text)))
                {
                    MessageBox.Show("PUNTAJE GUARDADO");
                }
                else
                {
                    MessageBox.Show("PUNTAJE NO GUARDADO");

                }
                
                a = 0;
                btnEnviarTiempo.Enabled = false;
                consultaPuntajes();
                txtPuntaje.Clear();
                txtTiempo.Clear();
            }
            else
            {
                MessageBox.Show("TIEMPO INVÁLIDO");
            }
        }

        private void frmDrones_Load(object sender, EventArgs e)
        {
            consultaLista();
            consultaPuntajes();
            btnEnviarTiempo.Enabled = false;
        }
    }
}
