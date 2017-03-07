using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public static class clsConexion
    {
        public static string rutaBD = @"Data Source=JUANMAVIANA;Initial Catalog=dbRoboMatrixUdla;Integrated Security=True";
        public static SqlConnection conexion = new SqlConnection(rutaBD);
        public static void abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }
        public static void cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
