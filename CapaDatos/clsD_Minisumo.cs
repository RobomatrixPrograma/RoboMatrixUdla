using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Minisumo
    {
        MERRobotDataContext bd = new MERRobotDataContext();
        public bool agregarBatalla(int robot1, int robot2)
        {

            try
            {
                TblMinisumo minis = new TblMinisumo { idRobotUno = robot1, idRobotDos = robot2, };
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
    }
}
