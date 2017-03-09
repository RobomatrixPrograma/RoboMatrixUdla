using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class clsD_ResultadosMinisumo
    {
        MERRobotDataContext bd = new MERRobotDataContext();
        
        public object D_ConsultaResutlados()
        {
            try
            {
                var rob1 = from r in bd.TblResultadoMinisumos
                           select new {
                           };
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
