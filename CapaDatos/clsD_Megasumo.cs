using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Megasumo
    {
        MERRobotDataContext bd = new MERRobotDataContext();
        public bool agregarBatalla(int robot1, int robot2)
        {

            try
            {
                TblMegasumo megas = new TblMegasumo { idRobotUno = robot1, idRobotDos = robot2, estado = "NO" };
                bd.TblMegasumos.InsertOnSubmit(megas);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public object consultaMegasumo()
        {
            try
            {
                var megas = from m in bd.TblMegasumos
                            select new
                            {
                                N_Batalla = m.idBatalla_megasumo,
                                Robot_1 = m.TblRobot.nomRobot,
                                Equipo_1 = m.TblRobot.TblEquipo.nomEquipo,
                                Robot_2 = m.TblRobot1.nomRobot,
                                Equipo_2 = m.TblRobot1.TblEquipo.nomEquipo,
                            };
                return megas;
            }
            catch
            {
                throw new NotImplementedException();
            }

        }

        public object comprobar(int robot1, int robot2)
        {
            var megas = from m in bd.TblMegasumos
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
            return megas;
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
    }
}
