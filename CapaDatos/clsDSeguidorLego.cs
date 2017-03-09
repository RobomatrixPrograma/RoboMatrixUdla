using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDSeguidorLego
    {
        MERRobotDataContext bd = new MERRobotDataContext();
        public object D_consultaLista()
        {
            try
            {
                var rob1 = from r in bd.TblSeguidorLegos
                           where r.estado != "SI"
                           select new { r.idRobot, r.TblRobot.nomRobot };
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public object D_consultaListaPresentacion()
        {
            try
            {
                var rob1 = from r in bd.TblSeguidorLegos
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

        public int D_consultaListaID()
        {
            try
            {
                int a = (from r in bd.TblSeguidorLegos
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
                TblSeguidorLego lab1 = bd.TblSeguidorLegos.First(r => r.idBatalla_SeguidorLego == id);
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
                string rob1 = (from r in bd.TblSeguidorLegos
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
                int a = (from r in bd.TblSeguidorLegos
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

        public bool ingresarOrden(int robot1)
        {

            try
            {
                TblSeguidorLego seguidor = new TblSeguidorLego { idRobot = robot1, estado = "SI" };
                bd.TblSeguidorLegos.InsertOnSubmit(seguidor);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int D_consultaListaIDBatalla()
        {
            try
            {
                int a = (from r in bd.TblSeguidorLegos
                         where r.estado != "SI"
                         select new { r.idBatalla_SeguidorLego }).FirstOrDefault().idBatalla_SeguidorLego;

                return a;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
