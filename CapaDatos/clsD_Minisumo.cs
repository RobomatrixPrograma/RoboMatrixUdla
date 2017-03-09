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
                           select new { m.idBatalla_minisumo};
                return minis ;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
