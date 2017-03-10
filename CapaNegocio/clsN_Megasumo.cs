using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Megasumo
    {
        clsD_Megasumo D_Megasumo = new clsD_Megasumo();
        public int idBatalla { get; set; }
        public int idRobot1 { get; set; }
        public int idRobot2 { get; set; }
        public string  estado { get; set; }

        public int N_ConsultaIdBatalla()
        {
            return D_Megasumo.D_consultaListaID();
        }

        public int N_ConsultaRobot1(int idB)
        {
            idBatalla = idB;
            return D_Megasumo.D_consultaRobot1(idBatalla);
        }

        public int N_ConsultaRobot2(int idB)
        {
            idBatalla = idB;
            return D_Megasumo.D_consultaRobot2(idBatalla);
        }
        
        public bool actualizarEstado(int idB)
        {
            idBatalla = idB;
            estado = "SI";
            return D_Megasumo.D_actualizarEstado(idBatalla, estado);
        }

        public object cargarParticipantes()
        {
            return (D_Megasumo.cargarParticipantes());
        }
    }
}
