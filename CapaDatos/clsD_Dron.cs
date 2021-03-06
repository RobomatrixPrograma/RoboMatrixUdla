﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Dron
    {
        MERRobotsDataContext bd = new MERRobotsDataContext();
        public bool ingresarOrden(int robot1)
        {
            try
            {
                TblDrone dron = new TblDrone { idRobot = robot1 , estado="NO" };
                bd.TblDrones.InsertOnSubmit(dron);
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
                var rob1 = from r in bd.TblDrones
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
