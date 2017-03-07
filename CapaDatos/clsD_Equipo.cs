using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Equipo
    {
        MERRobotDataContext bd = new MERRobotDataContext();
        public bool ingresarEquipo(string nom, string pais, string lugar)
        {
            try
            {
                TblEquipo equi1 = new TblEquipo { nomEquipo = nom, paisEquipo = pais, lugarEquipo = lugar };
                bd.TblEquipos.InsertOnSubmit(equi1);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }

        public bool D_ActualizaEquipo(int id, string nomEquipo, string paisEquipo, string lugarEquipo)
        {
            try
            {
                TblEquipo equi1 = bd.TblEquipos.First(r => r.idEquipo == id);
                equi1.nomEquipo = nomEquipo;
                equi1.paisEquipo  = paisEquipo;
                equi1.lugarEquipo = lugarEquipo;
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public object D_consultaPais()
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;

            clsConexion.abrirConexion();

            string sql = "select distinct paisEquipo from TblEquipos ";

            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);

            adaptador.Fill(ds2, "TblEquipos");

            clsConexion.cerrarConexion();

            return ds2;
        }

        public DataSet D_consultaEquipo(string paisEquipo)
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;

            clsConexion.abrirConexion();

            string sql = "select * from TblEquipos where paisEquipo =" + paisEquipo;

            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);

            adaptador.Fill(ds2, "TblEquipos");

            clsConexion.cerrarConexion();

            return ds2;
        }

        public DataSet D_consultaEquipo(int idEquipo)
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;

            clsConexion.abrirConexion();

            string sql = "select * from TblEquipos where idEquipo =" + idEquipo;

            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);

            adaptador.Fill(ds2, "TblEquipos");

            clsConexion.cerrarConexion();

            return ds2;
        }

        public object D_consultaLugar()
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;

            clsConexion.abrirConexion();

            string sql = "select distinct lugarEquipo from TblEquipos ";

            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);

            adaptador.Fill(ds2, "TblEquipos");

            clsConexion.cerrarConexion();

            return ds2;
        }

        public DataSet D_consultaEquipo(string paisEquipo, string lugarEquipo)
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;

            clsConexion.abrirConexion();

            string sql = "select * from TblEquipos where paisEquipo =" + paisEquipo +" AND lugarEquipo = "+ lugarEquipo ;

            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);

            adaptador.Fill(ds2, "TblEquipos");

            clsConexion.cerrarConexion();

            return ds2;
        }

        public DataSet D_consultaEquipo()
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;

            clsConexion.abrirConexion();

            string sql = "select * from TblEquipos ";

            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);

            adaptador.Fill(ds2, "TblEquipos");

            clsConexion.cerrarConexion();

            return ds2;
        }

        public bool D_EliminarRobot(int id)
        {
            try
            {
                TblEquipo equi1 = bd.TblEquipos.First(r => r.idEquipo == id);

                bd.TblEquipos.DeleteOnSubmit(equi1);
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
