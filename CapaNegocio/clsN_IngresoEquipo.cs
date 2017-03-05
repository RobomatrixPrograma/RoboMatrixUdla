using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using static System.Net.Mime.MediaTypeNames;

namespace CapaNegocio
{
    public class clsN_IngresoEquipo
    {
        clsD_IngresarEquipo objD_IngresarEquipo = new clsD_IngresarEquipo();
        string nomEquipo { get; set; }
        string paisEquipo { get; set; }
        string lugarEquipo { get; set; }

        public bool ingresarEquipo(string nombre, string pais, string lugar, System.Drawing.Image logo)
        {
            throw new NotImplementedException();
        }
    }
}
