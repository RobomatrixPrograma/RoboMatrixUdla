using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDLaberinto
    {
        MERRobotDataContext bd = new MERRobotDataContext();
        public object D_consultaLista()
        {
            try
            {
                var rob1 = from r in bd.TblLaberintos
                           select new { r.idRobot };
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public string D_consultaListaParticipante()
        {
            try
            {
                int a = (from r in bd.TblLaberintos
                           select new { r.idRobot }).FirstOrDefault().idRobot;
                string rob1 = (from r in bd.TblRobots
                               where r.idRobot==a
                               select new { r.nomRobot }).FirstOrDefault().nomRobot;
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
                int a = (from r in bd.TblLaberintos
                         select new { r.idRobot }).FirstOrDefault().idRobot;
                
                return a;
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
                int a = (from r in bd.TblLaberintos
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
    }
}
