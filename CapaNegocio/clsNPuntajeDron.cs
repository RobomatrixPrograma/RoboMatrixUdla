using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class clsNPuntajeDron
    {
        clsDPuntajeDron D_objPuntaje = new clsDPuntajeDron();

        int idRobot { get; set; }
        decimal tiempo1 { get; set; }
        int puntaje { get; set; }
        public object N_consultaLista()
        {
            var rob1 = D_objPuntaje.D_consultaLista();
            return rob1;
        }

        public bool N_IngresarPuntaje(int id, decimal t1, int punt)
        {
            idRobot = id;
            tiempo1 = t1;
            puntaje = punt;
            return D_objPuntaje.D_ingresarPuntaje(idRobot, tiempo1, puntaje);
        }
    }
}
