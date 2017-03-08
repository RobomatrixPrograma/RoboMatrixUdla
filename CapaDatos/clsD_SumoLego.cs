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
        public bool agregarBatalla(int robot1, string nom1, int robot2, string nomRobot2)
        {

            try
            {
                TblLegosumo legos = new TblLegosumo { idRobotUno = robot1, idRobotDos = robot2, };
                bd.TblLegosumo.InsertOnSubmit(legos);
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
