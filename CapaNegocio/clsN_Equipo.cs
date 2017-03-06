using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using static System.Net.Mime.MediaTypeNames;
using System.Data;

namespace CapaNegocio
{
    public class clsN_Equipo
    {
        clsD_Equipo objD_Equipo = new clsD_Equipo();
        string nomEquipo { get; set; }
        string paisEquipo { get; set; }
        string lugarEquipo { get; set; }

        public bool ingresarEquipo(string nombre, string pais, string lugar)
        {
            nomEquipo = nombre;
            paisEquipo = pais;
            lugarEquipo = lugar;
            if (objD_Equipo.ingresarEquipo(nomEquipo, paisEquipo, lugarEquipo))
                return true;
            else
                return false;
        }

        public DataSet consultaEquipo()
        {
            return (objD_Equipo.D_consultaEquipo());
        }
    }
}
