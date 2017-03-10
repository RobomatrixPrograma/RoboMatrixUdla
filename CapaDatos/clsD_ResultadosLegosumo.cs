using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_ResultadosLegosumo
    {
        MERRobotsDataContext bd = new MERRobotsDataContext();
        public object D_ConsultaResutlados()
        {
            try
            {

                var rob1 = from r in bd.TblResultadoLegosumos
                           select new
                           {
                               Robot_Ganador = r.TblRobot.nomRobot,
                               Robot_1 = r.TblLegosumo.TblRobot.nomRobot,
                               Puntaje_1 = r.puntosUno,
                               Robot_2 = r.TblLegosumo.TblRobot1.nomRobot,
                               Puntaje_2 = r.puntosDos,
                           };
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public bool D_ingresarPuntaje(int idBatalla, int puntaje1, int puntaje2, int ganador)
        {
            try
            {
                TblResultadoLegosumo puntaje = new TblResultadoLegosumo{ idBatalla = idBatalla, puntosUno = puntaje1, puntosDos = puntaje2, idGanador = ganador };
                bd.TblResultadoLegosumos.InsertOnSubmit(puntaje);
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
