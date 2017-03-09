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
                TblMegasumo megas = new TblMegasumo { idRobotUno = robot1, idRobotDos = robot2, };
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
                            select new { m.idBatalla_megasumo };
                return megas;
            }
            catch
            {
                throw new NotImplementedException();
            }

        }
    }
}
