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
    public partial class frmSeguidorLego : Form
    {
        public frmSeguidorLego()
        {
            InitializeComponent();
        }
        clsNSeguidorLego N_objSeguidor = new clsNSeguidorLego();
        clsNPuntajeSeguidorLego N_objPuntajeSeguidor = new clsNPuntajeSeguidorLego();
        DataSet ds = new DataSet();
        int a = 0;
        int id = 0;
        int idBatallla = 0;
        private void consultaLista()
        {
            dgvLista.DataSource = N_objSeguidor.N_consultaLista();

        }
        private void consultaPuntajes()
        {
            dgvPuntajes.DataSource = N_objPuntajeSeguidor.N_consultaLista();

        }
        private void frmSeguidorLego_Load(object sender, EventArgs e)
        {
            consultaLista();
            consultaPuntajes();
            btnEnviarTiempo.Enabled = false;
        }

        private void btnEnviarTiempo_Click(object sender, EventArgs e)
        {
            if (txtTiempo.Text != "")
            {
                if (a < 3)
                {
                    a++;
                }
                if (a == 1)
                {
                    lblTiempo1.Text = txtTiempo.Text;
                }
                else if (a == 2)
                {
                    lblTiempo2.Text = txtTiempo.Text;
                }
                else if (a == 3)
                {
                    lblTiempo3.Text = txtTiempo.Text;
                    if (N_objPuntajeSeguidor.N_IngresarPuntaje(idBatallla, decimal.Parse(lblTiempo1.Text), decimal.Parse(lblTiempo2.Text), decimal.Parse(lblTiempo3.Text)))
                    {
                        MessageBox.Show("PUNTAJE GUARDADO");
                    }
                    else
                    {
                        MessageBox.Show("PUNTAJE NO GUARDADO");

                    }
                    lblTiempo3.Text = "";
                    lblTiempo1.Text = "";
                    lblTiempo2.Text = "";
                    a = 0;
                    btnEnviarTiempo.Enabled = false;
                    consultaPuntajes();
                }
                txtTiempo.Clear();
            }
            else
            {
                MessageBox.Show("TIEMPO INVÁLIDO");
            }

        }

        private void btnNuevoParticipante_Click(object sender, EventArgs e)
        {
            try
            {
                id = N_objSeguidor.N_consultaListaID();
                idBatallla = N_objSeguidor.N_consultaListaIDBatalla();
                MessageBox.Show("Participante " + N_objSeguidor.N_consultaListaParticipante() + " listo para comenzar");
                lblCambiarNombre.Text = N_objSeguidor.N_consultaListaParticipante();
                lblCambiarEquipo.Text = N_objSeguidor.N_consultaListaParticipante2();
                if (!(N_objSeguidor.actualizarEstado(idBatallla)))
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
    }
}
