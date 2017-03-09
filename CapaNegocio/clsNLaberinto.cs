using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class clsNLaberinto
    {
        clsDLaberinto D_objLaberinto = new clsDLaberinto();
        public int idBatalla { get; set; }
        public int idRobot { get; set; }
        public string estado { get; set; }


        public object N_consultaLista()
        {
            var rob1 = D_objLaberinto.D_consultaLista();
            return rob1;
        }

        public string N_consultaListaParticipante()
        {
            return D_objLaberinto.D_consultaListaParticipante();
        }

        public string N_consultaListaParticipante2()
        {
            return D_objLaberinto.D_consultaListaParticipante2();
        }

        public int N_consultaListaID()
        {
            return D_objLaberinto.D_consultaListaID();
        }

        public bool actualizarEstado(int id)
        {
           
            idBatalla = id;
            estado = "SI";
            if (D_objLaberinto.D_ActualizarEstado(idBatalla,estado))
                return true;
            else
                return false;
        }

        public int N_consultaListaIDBatalla()
        {
            return D_objLaberinto.D_consultaListaIDBatalla();
        }
    }
}
