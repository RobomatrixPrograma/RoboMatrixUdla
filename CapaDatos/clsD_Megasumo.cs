using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Megasumo
    {
        MERRobotsDataContext bd = new MERRobotsDataContext();
        public bool agregarBatalla(int robot1, int robot2)
        {

            try
            {
                TblMegasumo minis = new TblMegasumo { idRobotUno = robot1, idRobotDos = robot2, estado = "NO" };
                bd.TblMegasumos.InsertOnSubmit(minis);
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
                var minis = from m in bd.TblMegasumos
                            select new
                            {
                                Batalla = m.idBatalla_megasumo,
                                Robot_1 = m.TblRobot.nomRobot,
                                Equipo_1 = m.TblRobot.TblEquipo.nomEquipo,
                                Robot_2 = m.TblRobot1.nomRobot,
                                Equipo_2 = m.TblRobot1.TblEquipo.nomEquipo
                            };
                return minis;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public object cargarParticipantes()
        {
            var minis = from m in bd.TblMegasumos
                        where m.estado != "SI"
                        select new
                        {
                            N_Batalla = m.idBatalla_megasumo,
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
                TblMegasumo minis = bd.TblMegasumos.First(r => r.idBatalla_megasumo == idBatalla);
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
            var minis = from m in bd.TblMegasumos
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

        public object consultaMegasumo()
        {
        
            try
            {
                var minis = from m in bd.TblMegasumos
                            select new
                            {
                                Batalla = m.idBatalla_megasumo,
                                Robot_1 = m.TblRobot.nomRobot,
                                Equipo_1 = m.TblRobot.TblEquipo.nomEquipo,
                                Robot_2 = m.TblRobot1.nomRobot,
                                Equipo_2 = m.TblRobot1.TblEquipo.nomEquipo
                            };
                return minis;
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
                int a = (from r in bd.TblMegasumos
                         where r.estado != "SI"
                         select new { r.idBatalla_megasumo }).FirstOrDefault().idBatalla_megasumo;

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
                int a = (from r in bd.TblMegasumos
                         where r.estado != "SI" && r.idBatalla_megasumo == idB
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
                int a = (from r in bd.TblMegasumos
                         where r.estado != "SI" && r.idBatalla_megasumo == idB
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
