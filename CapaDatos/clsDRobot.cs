using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class clsDRobot
    {
        MERRobotDataContext bd = new MERRobotDataContext();

        public object D_consultaRobot()
        {
            try
            {
                var rob1 = from r in bd.tTblRobot
                           select new { r.idRobot, r.nomRobot, r.estadoRobot };
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public bool D_ingresaRobot(string nombre, string estado)
        {
            try
            {
                TblRobot rob1 = new TblRobot { nomRobot = nombre, estadoRobot = estado };
                bd.TblRobots.InsertOnSubmit(rob1);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool D_ActualizaRobot(int id, string nombre, string estado)
        {
            try
            {
                TblRobot rob1 = bd.TblRobot.First(r => r.idRobot == id);
                rob1.nomRobot = nombre;
                rob1.estadoRobot = estado;
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public DataSet D_consultaRobot(int idRobot)
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;

            clsConexion.abrirConexion();

            string sql = "select * from TblRobot where idRobot=" + idRobot;

            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);

            adaptador.Fill(ds2, "TblRobot");

            clsConexion.cerrarConexion();

            return ds2;
        }

        public bool D_EliminarRobot(int id)
        {
            try
            {
                TblRobot rob1 = bd.TblRobot.First(r => r.idRobot == id);

                bd.TblRobot.DeleteOnSubmit(rob1);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }
    }
}
