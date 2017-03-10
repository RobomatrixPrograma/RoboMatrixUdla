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
                           orderby r.puntaje
                           select new { Nombre_Robot=r.TblDrone.TblRobot.nomRobot, Puntaje=r.puntaje, Tiempo=r.tiempo1 };
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
