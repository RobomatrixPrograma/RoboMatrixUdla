using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class clsNRobot
    {
        public int idRobot { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }

        clsDRobot D_objRobot = new clsDRobot();
        public object N_consultaRobot()
        {
            var rob1 = D_objRobot.D_consultaRobot();
            return rob1;
        }

        public bool N_IngresarRobot(string nombre, string estado)
        {
            Nombre = nombre;
            Estado = estado;
            if (D_objRobot.D_ingresaRobot(Nombre, Estado))
                return true;
            else
                return false;
        }

        public bool N_ActualizarRobot(int id, string nombre, string estado)
        {
            idRobot = id;
            Nombre = nombre;
            Estado = estado;
            if (D_objRobot.D_ActualizaRobot(idRobot, Nombre, Estado))
                return true;
            else
                return false;
        }

        public bool N_EliminarRobot(int id)
        {
            idRobot = id;

            return D_objRobot.D_EliminarRobot(idRobot);
        }
        public DataSet N_consultaRobot(int id)
        {
            idRobot = id;
            return D_objRobot.D_consultaRobot(idRobot);
        }
    }
}
