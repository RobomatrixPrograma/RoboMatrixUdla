using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaDatos
{
    public class clsD_Legosumo
    {
        MERRobotsDataContext bd = new MERRobotsDataContext();
        public bool agregarBatalla(int robot1, int robot2)
        {

            try
            {
                TblLegosumo legos = new TblLegosumo { idRobotUno = robot1, idRobotDos = robot2, estado = "NO" };
                bd.TblLegosumos.InsertOnSubmit(legos);
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
                var legos = from m in bd.TblLegosumos
                            select new
                            {
                                Batalla = m.idBatalla_Legosumo,
                                Robot_1 = m.TblRobot.nomRobot,
                                Equipo_1 = m.TblRobot.TblEquipo.nomEquipo,
                                Robot_2 = m.TblRobot1.nomRobot,
                                Equipo_2 = m.TblRobot1.TblEquipo.nomEquipo
                            };
                return legos;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public object cargarParticipantes()
        {
            var legos = from m in bd.TblLegosumos
                        where m.estado != "SI"
                        select new
                        {
                            N_Batalla = m.idBatalla_Legosumo,
                            Nombre_1 = m.TblRobot.nomRobot,
                            Equipo_1 = m.TblRobot.TblEquipo.nomEquipo,
                            Nombre_2 = m.TblRobot1.nomRobot,
                            Equipo_2 = m.TblRobot1.TblEquipo.nomEquipo,
                        };
            return legos;
        }

        public bool D_actualizarEstado(int idBatalla, string estado)
        {
            try
            {
                TblLegosumo legos = bd.TblLegosumos.First(r => r.idBatalla_Legosumo == idBatalla);
                legos.estado = estado;
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
            var legos = from m in bd.TblLegosumos
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
            return legos;
        }
        public int D_consultaListaID()
        {
            try
            {
                int a = (from r in bd.TblLegosumos
                         where r.estado != "SI"
                         select new { r.idBatalla_Legosumo }).FirstOrDefault().idBatalla_Legosumo;

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
                int a = (from r in bd.TblLegosumos
                         where r.estado != "SI" && r.idBatalla_Legosumo == idB
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
                int a = (from r in bd.TblLegosumos
                         where r.estado != "SI" && r.idBatalla_Legosumo == idB
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

