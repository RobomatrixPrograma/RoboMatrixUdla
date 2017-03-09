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
                TblLegosumo legos = new TblLegosumo { idRobotUno = robot1, idRobotDos = robot2, };
                bd.TblLegosumos.InsertOnSubmit(legos);
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
                var legos = from l in bd.TblLegosumos
                            select new { l.idBatalla_Legosumo };
                return legos;
            }
            catch
            {
                throw new NotImplementedException();
            }

        }
    }
}
