using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_ResultadoMinisumo
    {
        clsD_ResultadosMinisumo D_ResultadoMinisumo = new clsD_ResultadosMinisumo();
        public int idB { get; set; }
        public int puntaje1 { get; set; }
        public int puntaje2 { get; set; }
        public int ganador { get; set; }
        public bool N_IngresarPuntaje(int idBatalla, int v1, int v2, int ganador)
        {
            idB = idBatalla;
            puntaje1 = v1;
            puntaje2 = v2;
            this.ganador = ganador;
            return D_ResultadoMinisumo.D_ingresarPuntaje(idBatalla, puntaje1, puntaje2,this.ganador);
        }

        public object N_consultarPuntaje()
        {
            var minis = D_ResultadoMinisumo.D_ConsultaResutlados();
            return minis;
        }
    }
}
