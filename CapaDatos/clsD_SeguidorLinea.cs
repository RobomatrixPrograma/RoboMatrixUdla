﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    
    public class clsD_SeguidorLinea
    {
        MERRobotsDataContext bd = new MERRobotsDataContext();
        public bool ingresarOrden(int robot1)
        {

            try
            {
                TblSeguidorLinea seguidor = new TblSeguidorLinea{ idRobot = robot1, estado = "NO" };
                bd.TblSeguidorLineas.InsertOnSubmit(seguidor);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public object D_consultaListaParticipante()
        {
            throw new NotImplementedException();
        }

        public object D_consultaLista()
        {
            try
            {
                var rob1 = from r in bd.TblSeguidorLineas
                           select new {
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
