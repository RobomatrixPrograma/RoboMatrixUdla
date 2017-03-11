using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDPuntajeSeguidorLinea
    {
        MERRobotsDataContext bd = new MERRobotsDataContext();
        public object D_consultaLista()
        {
            try
            {
                var rob1 = from r in bd.TblPuntajeSeguidorLineas
                           orderby r.mejorTiempo
                           select new { Nombre_Robot=r.TblSeguidorLinea.TblRobot.nomRobot, Mejor_tiempo = r.mejorTiempo, Tiempo_1 = r.tiempo1, Tiempo_2 = r.tiempo2, Tiempo_3 = r.tiempo3 };
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
                TblPuntajeSeguidorLinea p1 = new TblPuntajeSeguidorLinea{ idBatalla = id, tiempo1 = t1, tiempo2 = t2, tiempo3 = t3, mejorTiempo = mejor };
                bd.TblPuntajeSeguidorLineas.InsertOnSubmit(p1);
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
