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
        public bool ingresarEquipo(string nom, string pais, string lugar)
        {
            try
            {
                TblEquipo equi1 = new TblEquipo { nomEquipo = nom, paisEquipo = pais, lugarEquipo = lugar };
                bd.TblEquipo.InsertOnSubmit(equi1);
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
                TblEquipo equi1 = bd.TblEquipo.First(r => r.idEquipo == id);
                equi1.nomEuqipo = nomEquipo;
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

        public DataSet D_consultaEquipo(int idEquipo)
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;

            clsConexion.abrirConexion();

            string sql = "select * from TblEquipo where idEquipo" + idEquipo;

            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);

            adaptador.Fill(ds2, "TblEquipo");

            clsConexion.cerrarConexion();

            return ds2;
        }

        public DataSet D_consultaEquipo()
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;

            clsConexion.abrirConexion();

            string sql = "select * from TblEquipo ";

            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);

            adaptador.Fill(ds2, "TblEquipo");

            clsConexion.cerrarConexion();

            return ds2;
        }

        public bool D_EliminarRobot(int id)
        {
            try
            {
                TblEquipo equi1 = bd.TblEquipo.First(r => r.idEquipo == id);

                bd.TblEquipo.DeleteOnSubmit(equi1);
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
