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
    public partial class frmMinisumo : Form
    {
        clsN_Minisumo N_Minisumo = new clsN_Minisumo();
        clsN_Equipo N_Equipo = new clsN_Equipo();
        clsNRobot N_Robot = new clsNRobot();
        clsN_ResultadoMinisumo N_PuntajeMinisumo = new clsN_ResultadoMinisumo();
        int idBatalla = 0;
        int robot1 = 0;
        int robot2 = 0;
        public frmMinisumo()
        {
            InitializeComponent();
        }

        private void lblBatallas_Click(object sender, EventArgs e)
        {

        }

        private void frmMinisumo_Load(object sender, EventArgs e)
        {
            terminarBatalla();
            nudRobot1.Maximum = 3;
            nudRobot1.Minimum = 0;
            nudRobot2.Maximum = 3;
            nudRobot2.Minimum = 0;
            btnSiguiente.Enabled = true;
            ocultarLbl();
        }

        private void terminarBatalla()
        {
            nudRobot2.Enabled = false;
            nudRobot1.Enabled = false;
            nudRobot1.Value = 0;
            nudRobot2.Value = 0;
            btnTerminar.Enabled = false;
            cargarParticipantes();
            cargarResultados();
        }

        private void empezarBatalla()
        {
            nudRobot2.Enabled = true;
            nudRobot1.Enabled = true;
            btnSiguiente.Enabled = false;
            btnTerminar.Enabled = true;
        }

        private void cargarParticipantes()
        {
            dgvParticipantes.DataSource = N_Minisumo.cargarParticipantes();
        }

        private void cargarResultados()
        {
            dgvResultados.DataSource = N_PuntajeMinisumo.N_consultarPuntaje();
        }
        private void ocultarLbl()
        {
            lblRobot2.Enabled = false;
            lblRobot1.Enabled = false;
            lblEquipo1.Enabled = false;
            lblEquipo2.Enabled = false;
            lblVs.Enabled = false;
        }

        private void mostrarLbl()
        {
            lblRobot2.Enabled = true;
            lblRobot1.Enabled = true;
            lblEquipo1.Enabled = true;
            lblEquipo2.Enabled = true;
            lblVs.Enabled = true;
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                empezarBatalla();
                idBatalla = N_Minisumo.N_ConsultaIdBatalla();
                robot1 = N_Minisumo.N_ConsultaRobot1(idBatalla);
                robot2 = N_Minisumo.N_ConsultaRobot2(idBatalla);
                string nom1 = N_Robot.N_ConsultaNombre(robot1);
                string nom2 = N_Robot.N_ConsultaNombre(robot2);
                string equi1 = N_Robot.N_ConsultaEquipo(robot1);
                string equi2 = N_Robot.N_ConsultaEquipo(robot2);
                MessageBox.Show("Siguiente Batalla: " + nom1 + " vs " + nom2);
                lblRobot1.Text = nom1;
                lblRobot2.Text = nom2;
                lblEquipo1.Text = equi1;
                lblEquipo2.Text = equi2;
                mostrarLbl();
                if (!(N_Minisumo.actualizarEstado(idBatalla)))
                {
                    MessageBox.Show("FALLA EN EL INGRESO DEL PARTICIPANTE");
                }
                cargarParticipantes();

            }
            catch
            {
                MessageBox.Show("NO EXISTEN PARTICIPANTES EN COLA");
            }
        }        

        private void btnTerminar_Click_1(object sender, EventArgs e)
        {
            int ganador = 0;
            if (int.Parse(nudRobot1.Value.ToString()) > int.Parse(nudRobot2.Value.ToString()))
                ganador = robot1;
            else
                ganador = robot2;
            if (N_PuntajeMinisumo.N_IngresarPuntaje(idBatalla, int.Parse(nudRobot1.Value.ToString()), int.Parse(nudRobot2.Value.ToString()), ganador))
            {
                MessageBox.Show("PUNTAJE GUARDADO");
            }
            else
            {
                MessageBox.Show("PUNTAJE NO GUARDADO");

            }
            dgvResultados.DataSource = N_PuntajeMinisumo.N_consultarPuntaje();
            terminarBatalla();

        }
    }
}
