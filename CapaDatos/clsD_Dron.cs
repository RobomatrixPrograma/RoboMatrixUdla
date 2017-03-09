using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Dron
    {
        MERRobotDataContext bd = new MERRobotDataContext();
        public bool ingresarOrden(int robot1)
        {
            throw new NotImplementedException();
        }
        

        public object D_consultaLista()
        {
            try
            {
                var rob1 = from r in bd.TblDrones
                           where r.estado != "SI"
                           select new
                           {
                               Código_Robot = r.idRobot,
                               Nombre = r.TblRobot.nomRobot,
                               Equipo = r.TblRobot.TblEquipo.nomEquipo,
                           };
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
