using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_SumoLego
    {
        MERRobotDataContext bd = new MERRobotDataContext();
        public bool agregarBatalla(int robot1, int robot2)
        {

            try
            {
                TblLegosumo legos = new TblLegosumo { idRobotUno = robot1, idRobotDos = robot2, estado = "NO" };
                bd.TblLegosumo.InsertOnSubmit(legos);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public object consultaLegoSumo()
        {
            try
            {
                var legos = from l in bd.TblLegosumo
                            select new {
                                N_Batalla = l.idBatalla_Legosumo,
                                Robot_1 = l.TblRobot.nomRobot,
                                Equipo_1 = l.TblRobot.TblEquipo.nomEquipo,
                                Robot_2 = l.TblRobot1.nomRobot,
                                Equipo_2 = l.TblRobot1.TblEquipo.nomEquipo,
                            };
                return legos;
            }
            catch
            {
                throw new NotImplementedException();
            }

        }

        public object comprobar(int robot1, int robot2)
        {
            var legos = from m in bd.TblLegosumo
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
                int a = (from r in bd.TblLegosumo
                         where r.estado != "SI"
                         select new { r.idBatalla_Legosumo }).FirstOrDefault().idBatalla_Legosumo;

                return a;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
