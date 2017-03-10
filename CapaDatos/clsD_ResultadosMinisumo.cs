using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_ResultadosMinisumo
    {
        MERRobotsDataContext bd = new MERRobotsDataContext();   
        public object D_ConsultaResutlados()
        {
            try
            {

                var rob1 = from r in bd.TblResultadoMinisumo
                           select new
                           {
                               Robot_Ganador = r.TblRobot.nomRobot,
                               Robot_1 = r.TblMinisumo.TblRobot.nomRobot,
                               Puntaje_1 = r.puntosUno,
                               Robot_2 = r.TblMinisumo.TblRobot1.nomRobot,
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
                TblResultadoMinisumo puntaje = new TblResultadoMinisumo { idBatalla = idBatalla, puntosUno = puntaje1, puntosDos = puntaje2, idGanador = ganador };
                bd.TblResultadoMinisumo.InsertOnSubmit(puntaje);
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
