using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class clsNPuntajeLaberinto
    {
        clsDPuntajeLaberinto D_objPuntaje = new clsDPuntajeLaberinto();

        int idRobot { get; set; }
        decimal tiempo1 { get; set; }
        decimal tiempo2 { get; set; }
        decimal tiempo3 { get; set; }
        public bool N_IngresarPuntaje(int id, decimal t1, decimal t2, decimal t3)
        {
            idRobot = id;
            tiempo1 = t1;
            tiempo2 = t2;
            tiempo3 = t3;
            return D_objPuntaje.D_ingresarPuntaje(idRobot, tiempo1, tiempo2, tiempo3);
        }

        public object N_consultaLista()
        {
            var rob1 = D_objPuntaje.D_consultaLista();
            return rob1;
        }
      
    }
}
