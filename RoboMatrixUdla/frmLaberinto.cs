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
    public partial class frmLaberinto : Form
    {
        clsNLaberinto N_objLaberinto = new clsNLaberinto();
        clsNPuntajeLaberinto N_objPuntajeLaberinto = new clsNPuntajeLaberinto();
        DataSet ds = new DataSet();
        int a = 0;
        int id = 0;
        public frmLaberinto()
        {
            InitializeComponent();
        }
        private void consultaLista()
        {
            dgvLista.DataSource = N_objLaberinto.N_consultaLista();

        }
        private void consultaPuntajes()
        {
            dgvPuntajes.DataSource = N_objPuntajeLaberinto.N_consultaLista();

        }
        private void btnEnviarTiempo_Click(object sender, EventArgs e)
        {
            if (a < 3)
            {
                a++;
            }
            if (a == 1)
            {
                lblTiempo1.Text = txtTiempo.Text;
            }
            else if(a==2)
            {
                lblTiempo2.Text = txtTiempo.Text;
            }
            else if( a==3)
            {
                lblTiempo3.Text = txtTiempo.Text;
                if (N_objPuntajeLaberinto.N_IngresarPuntaje(id, decimal.Parse(lblTiempo1.Text), decimal.Parse(lblTiempo2.Text), decimal.Parse(lblTiempo3.Text)))
                {
                    MessageBox.Show("PUNTAJE GUARDADO");
                }
                else
                {
                    MessageBox.Show("PUNTAJE NO GUARDADO");

                }
                consultaPuntajes();
            }
        }

        private void frmLaberinto_Load(object sender, EventArgs e)
        {
            consultaLista();
            consultaPuntajes();
        }

        private void btnNuevoParticipante_Click(object sender, EventArgs e)
        {
            id= N_objLaberinto.N_consultaListaID();
            lblCambiarNombre.Text = N_objLaberinto.N_consultaListaParticipante();
            lblCambiarEquipo.Text = N_objLaberinto.N_consultaListaParticipante2();

        }
    }
}
