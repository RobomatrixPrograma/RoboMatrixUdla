using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Minisumo
    {
        clsD_Minisumo D_Minisumo = new clsD_Minisumo();
        public int idBatalla { get; set; }
        public int idRobot1 { get; set; }
        public int idRobot2 { get; set; }
        public string  estado { get; set; }
        public int N_ConsultaIdBatalla()
        {
            return D_Minisumo.D_consultaListaID();
        }

        public int N_ConsultaRobot1(int idB)
        {
            idBatalla = idB;
            return D_Minisumo.D_consultaRobot1(idBatalla);
        }

        public int N_ConsultaRobot2(int idB)
        {
            idBatalla = idB;
            return D_Minisumo.D_consultaRobot2(idBatalla);
        }
        
        public bool actualizarEstado(int idB)
        {
            idBatalla = idB;
            estado = "SI";
            return D_Minisumo.D_actualizarEstado(idBatalla, estado);
        }
    }
}
