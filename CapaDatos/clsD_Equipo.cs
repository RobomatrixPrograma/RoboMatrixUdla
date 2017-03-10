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
        MERRobotsDataContext bd = new MERRobotsDataContext();
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
                equi1.nomEquipo = nomEquipo;
                equi1.paisEquipo = paisEquipo;
                equi1.lugarEquipo = lugarEquipo;
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }
        public bool D_EliminarEquipo(int id)
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

        public object D_consultaEquipoPresentacion()
        {
            try
            {
                var equ1 = from e in bd.TblEquipo
                           select new
                           {
                               Código_Equipo = e.idEquipo,
                               Nombre = e.nomEquipo,
                               País = e.paisEquipo,
                               Universidad = e.lugarEquipo,
                               Logo = e.imgEquipo,
                           };
                return equ1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public object D_consultaPais()
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;
            clsConexion.abrirConexion();
            string sql = "select distinct paisEquipo from TblEquipo ";
            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
            adaptador.Fill(ds2, "TblEquipo");
            clsConexion.cerrarConexion();
            return ds2;
        }

        public object D_consultaEquipoId(int idEquipo)
        {
            var equ1 = from e in bd.TblEquipo
                      where e.idEquipo == idEquipo
                      select new
                      {
                          Código_Equipo = e.idEquipo,
                          Nombre = e.nomEquipo,
                          País = e.paisEquipo,
                          Universidad = e.lugarEquipo,
                          Logo = e.imgEquipo,
                      };
            return equ1;
        }

        public object D_consultaEquipoNombre(string nombre)
        {
            Console.WriteLine(nombre);
            var equ1= from r in bd.TblEquipo
                      where r.nomEquipo.Contains(nombre) || r.paisEquipo.Contains(nombre) || r.lugarEquipo.Contains(nombre)
                      select new
                      {
                          Código_Equipo = r.idEquipo,
                          Nombre = r.nomEquipo,
                          País = r.paisEquipo,
                          Universidad = r.lugarEquipo,
                          Logo = r.imgEquipo,
                      };
            return equ1;
        }

        public object D_consultaLugar()
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;
            clsConexion.abrirConexion();
            string sql = "select distinct lugarEquipo from TblEquipo ";
            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
            adaptador.Fill(ds2, "TblEquipo");
            clsConexion.cerrarConexion();
            return ds2;
        }

        public DataSet D_consultaEquipo(string paisEquipo)
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;
            clsConexion.abrirConexion();
            string sql = "select * from TblEquipo where paisEquipo = " + paisEquipo;
            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
            adaptador.Fill(ds2, "TblEquipo");
            clsConexion.cerrarConexion();
            return ds2;
        }

        public DataSet D_consultaEquipo(string paisEquipo, string lugarEquipo)
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter adaptador;
            clsConexion.abrirConexion();
            string sql = "select * from TblEquipo where paisEquipo =" + paisEquipo + " AND lugarEquipo = " + lugarEquipo;
            adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
            adaptador.Fill(ds2, "TblEquipo");
            clsConexion.cerrarConexion();
            return ds2;
        }


        public object D_consultaEquipo()
        {
            try
            {
                var equ1 = from e in bd.TblEquipo
                           select new
                           {
                               e.idEquipo,
                               e.nomEquipo,
                               e.paisEquipo,
                               e.lugarEquipo,
                               e.imgEquipo,
                           };
                return equ1;
            }
            catch
            {
                throw new NotImplementedException();
            }

        }
    }
}
