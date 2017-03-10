using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Minisumo
    {
        MERRobotsDataContext bd = new MERRobotsDataContext();
        public bool agregarBatalla(int robot1, int robot2)
        {

            try
            {
                TblMinisumo minis = new TblMinisumo { idRobotUno = robot1, idRobotDos = robot2, estado= "NO"};
                bd.TblMinisumos.InsertOnSubmit(minis);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public object consultaMinisumo()
        {
            try
            {
                var minis = from m in bd.TblMinisumos
                            select new
                            {
                                Batalla = m.idBatalla_minisumo,
                                Robot_1 = m.TblRobot.nomRobot,
                                Equipo_1 = m.TblRobot.TblEquipo.nomEquipo,
                                Robot_2 = m.TblRobot1.nomRobot,
                                Equipo_2 = m.TblRobot1.TblEquipo.nomEquipo
                            };
                return minis ;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public object cargarParticipantes()
        {
            var minis = from m in bd.TblMinisumos
                        where m.estado !="SI"
                        select new
                        {
                            N_Batalla = m.idBatalla_minisumo,
                            Nombre_1 = m.TblRobot.nomRobot,
                            Equipo_1 = m.TblRobot.TblEquipo.nomEquipo,
                            Nombre_2 = m.TblRobot1.nomRobot,
                            Equipo_2 = m.TblRobot1.TblEquipo.nomEquipo,
                        };
            return minis;
        }

        public bool D_actualizarEstado(int idBatalla, string estado)
        {
            try
            {
                TblMinisumo minis = bd.TblMinisumos.First(r => r.idBatalla_minisumo == idBatalla);
                minis.estado = estado;
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public object comprobar(int robot1, int robot2)
        {
            var minis = from m in bd.TblMinisumos
                        where m.idRobotUno == robot1 && m.idRobotDos == robot2 || 
                        m.idRobotUno == robot2 && m.idRobotDos == robot1
                        group m by                     
                        new
                         {
                             m.idRobotUno,
                             m.idRobotDos,
                        } into grp
                        where grp.Count() > 1
                         select grp.Key;
            return minis;
        }
        public int D_consultaListaID()
        {
            try
            {
                int a = (from r in bd.TblMinisumos
                         where r.estado != "SI"
                         select new { r.idBatalla_minisumo }).FirstOrDefault().idBatalla_minisumo;

                return a;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public int D_consultaRobot1(int idB)
        {
            try
            {
                int a = (from r in bd.TblMinisumos
                         where r.estado != "SI" && r.idBatalla_minisumo == idB
                         select new { r.idRobotUno }).FirstOrDefault().idRobotUno;

                return a;
            }
            catch
            {
                throw new NotImplementedException();
            }

        }

        public int D_consultaRobot2(int idB)
        {
            try
            {
                int a = (from r in bd.TblMinisumos
                         where r.estado != "SI" && r.idBatalla_minisumo == idB
                         select new { r.idRobotDos }).FirstOrDefault().idRobotDos;

                return a;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
