using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDPuntajeDron
    {
        MERRobotsDataContext bd = new MERRobotsDataContext();
        public object D_consultaLista()
        {
            try
            {
                var rob1 = from r in bd.TblPuntajeDrones
                           select new { r.TblDrone.TblRobot.nomRobot, r.puntaje, r.tiempo1 };
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public bool D_ingresarPuntaje(int id, decimal t1, int punt)
        {
            try
            {
                TblPuntajeDrone p1 = new TblPuntajeDrone { idBatalla = id, tiempo1 = t1, puntaje=punt };
                bd.TblPuntajeDrones.InsertOnSubmit(p1);
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
