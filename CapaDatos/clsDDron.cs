using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDDron
    {
        MERRobotsDataContext bd = new MERRobotsDataContext();
        public object D_consultaLista()
        {
            try
            {
                var rob1 = from r in bd.TblDrones
                           where r.estado != "SI"
                           select new { Código_Robot = r.idRobot, Nombre_Robot = r.TblRobot.nomRobot };
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public int D_consultaListaID()
        {
            try
            {
                int a = (from r in bd.TblDrones
                         where r.estado != "SI"
                         select new { r.idRobot }).FirstOrDefault().idRobot;

                return a;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public bool D_ActualizarEstado(int id, string estado)
        {
            try
            {
                TblDrone lab1 = bd.TblDrones.First(r => r.idBatalla_Drones == id);
                lab1.estado = estado;
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public string D_consultaListaParticipante()
        {
            try
            {
                string rob1 = (from r in bd.TblDrones
                               where r.estado != "SI"
                               select new { r.TblRobot.nomRobot }).FirstOrDefault().nomRobot;

                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public string D_consultaListaParticipante2()
        {
            try
            {
                int a = (from r in bd.TblDrones
                         select new { r.idRobot }).FirstOrDefault().idRobot;
                string rob1 = (from r in bd.TblRobots
                               where r.idRobot == a
                               select new { r.TblEquipo.nomEquipo }).FirstOrDefault().nomEquipo;
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public int D_consultaListaIDBatalla()
        {
            try
            {
                int a = (from r in bd.TblDrones
                         where r.estado != "SI"
                         select new { r.idBatalla_Drones }).FirstOrDefault().idBatalla_Drones;

                return a;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
