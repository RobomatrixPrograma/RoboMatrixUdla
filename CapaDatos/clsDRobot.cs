﻿using System;
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
                var rob1 = from r in bd.TblRobot
                           select new { r.idRobot, r.nomRobot, r.estadoRobot, r.liderRobot, r.idCategoria, r.idEquipo };
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public bool D_ingresaRobot(int id, string nombre, string estado, string lider, int idC, int idE)
        {
            try
            {
                TblRobot rob1 = new TblRobot { idRobot=id, nomRobot = nombre, estadoRobot = estado, liderRobot = lider, idCategoria=idC, idEquipo=idE };
                bd.TblRobot.InsertOnSubmit(rob1);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public object D_consultaRobotPorNombre(string nombre)
        {
            int a = 0;
            try
            {
                a = int.Parse(nombre);

            }
            catch
            {
                a = -1;
            }
            try
            {
                var rob1 = from r in bd.TblRobot
                           where r.nomRobot==nombre || r.idRobot==a || r.estadoRobot == nombre || r.liderRobot == nombre || r.idCategoria==a || r.idEquipo ==a
                           select new { r.idRobot, r.nomRobot, r.estadoRobot, r.liderRobot, r.idCategoria, r.idEquipo };
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public bool D_ActualizaRobot(int id, string nombre, string estado, string lider, int idC, int idE)
        {
            try
            {
                TblRobot rob1 = bd.TblRobots.First(r => r.idRobot == id);
                rob1.nomRobot = nombre;
                rob1.estadoRobot = estado;
                rob1.liderRobot = lider;
                rob1.idCategoria = idC;
                rob1.idEquipo = idE;
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
