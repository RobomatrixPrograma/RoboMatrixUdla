using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDPuntajeSeguidorLego
    {
        MERRobotDataContext bd = new MERRobotDataContext();
        public object D_consultaLista()
        {
            try
            {
                var rob1 = from r in bd.TbPuntajeSeguidorLegos
                           select new { r.TblSeguidorLego.TblRobot.nomRobot, r.mejorTiempo, r.tiempo1, r.tiempo2, r.tiempo3 };
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public bool D_ingresarPuntaje(int id, decimal t1, decimal t2, decimal t3, decimal mejor)
        {
            try
            {
                TbPuntajeSeguidorLego p1 = new TbPuntajeSeguidorLego{ idBatalla = id, tiempo1 = t1, tiempo2 = t2, tiempo3 = t3, mejorTiempo = mejor };
                bd.TbPuntajeSeguidorLegos.InsertOnSubmit(p1);
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
