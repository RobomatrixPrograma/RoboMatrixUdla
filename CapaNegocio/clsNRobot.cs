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
        public string lider { get; set; }
        public int idCat { get; set; }
        public int idEq { get; set; }

        clsDRobot D_objRobot = new clsDRobot();
        public object N_consultaRobotPresentacion()
        {
            var rob1 = D_objRobot.D_consultaRobotPresentacion();
            return rob1;
        }
        public object N_consultaRobot()
        {
            var rob1 = D_objRobot.D_consultaRobotPresentacion();
            return rob1;
        }
        public object N_consultaRobotPorNombre(string busqueda)
        {
            Nombre=busqueda;
            var rob1 = D_objRobot.D_consultaRobotPorNombre(Nombre);
            return rob1;
        }
        public bool N_IngresarRobot(int id, string nombre, string estado, string lid, int idC, int idE)
        {
            idRobot = id;
            Nombre = nombre;
            int e = int.Parse(estado);
            if(e == 0)
            {
                Estado = "AC";
            }
            else
            {
                Estado = "DC";
            }
            lider = lid;
            idCat = idC;
            idEq = idE;
            if (D_objRobot.D_ingresaRobot(idRobot, Nombre, Estado, lider, idCat, idEq))
                return true;
            else
                return false;
        }

        public bool N_ActualizarRobot(int id, string nombre, string estado, string lid, int idC, int idE)
        {
            idRobot = id;
            Nombre = nombre;
            int e = int.Parse(estado);
            if (e == 0)
            {
                Estado = "AC";
            }
            else
            {
                Estado = "DC";
            }
            lider = lid;
            idCat = idC;
            idEq = idE;
            if (D_objRobot.D_ActualizaRobot(idRobot, Nombre, Estado, lider, idCat, idEq))
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

        public string N_ConsultaEquipo(int robot1)
        {
            idRobot = robot1;
            return D_objRobot.consultaEquipo(idRobot);
        }

        public string N_ConsultaNombre(int robot1)
        {
            idRobot = robot1;
            return D_objRobot.D_consultaNombre(idRobot);
        }

        public object N_consultaRobotCat(int cat)
        {
            idCat = cat;
            return D_objRobot.D_consultaRobotCategoria(idCat);
        }
        public object N_consultaRobotExcepto(int idR, int idC)
        {
            idRobot = idR;
            idCat = idC;
            return D_objRobot.D_consultaRobotExcepto(idRobot, idC);
        }
    }
}
