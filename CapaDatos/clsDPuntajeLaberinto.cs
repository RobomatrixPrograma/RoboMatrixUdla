using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDPuntajeLaberinto
    {
        MERRobotDataContext bd = new MERRobotDataContext();
        public bool D_ingresarPuntaje(int id, decimal t1, decimal t2, decimal t3)
        {
            try
            {
                TblPuntajeLaberinto p1 = new TblPuntajeLaberinto { idRobot = id, timepo1=t1, tiempo2=t2, tiempo3=t3  };
                bd.TblPuntajeLaberintos.InsertOnSubmit(p1);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public object D_consultaLista()
        {
            try
            {
                var rob1 = from r in bd.TblPuntajeLaberintos
                           select new { r.idRobot, r.timepo1, r.tiempo2, r.tiempo3 };
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
