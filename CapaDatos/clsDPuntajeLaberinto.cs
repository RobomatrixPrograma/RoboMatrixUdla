﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDPuntajeLaberinto
    {
        MERRobotsDataContext bd = new MERRobotsDataContext();
        public bool D_ingresarPuntaje(int id, decimal t1, decimal t2, decimal t3, decimal mejor)
        {
            try
            {
                TblPuntajeLaberinto p1 = new TblPuntajeLaberinto { idBatalla = id, tiempo1 = t1, tiempo2 = t2, tiempo3 = t3, mejorTiempo = mejor  };
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
                           orderby r.mejorTiempo

                           select new { Nombre_Robot=r.TblLaberinto.TblRobot.nomRobot, Mejor_Tiempo=r.mejorTiempo, Tiempo_1=r.tiempo1, Tiempo_2 = r.tiempo2, Tiempo_3 = r.tiempo3};
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
