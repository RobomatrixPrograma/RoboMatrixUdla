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
        int idEquipo { get; set; }
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

        public object consultaEquipoPresentacion()
        {
            var cat1 = objD_Equipo.D_consultaEquipoPresentacion();
            return cat1;
        }

        public object consultaEquipo()
        {
            var equi =  (objD_Equipo.D_consultaEquipo());
            return equi;
        }

        public object N_consultaPais()
        {
            var equ1 = objD_Equipo.D_consultaPais();
            return equ1;
        }

        public DataSet consultaEquipo(string pais)
        {
            paisEquipo = pais;
            return (objD_Equipo.D_consultaEquipo(paisEquipo));
        }

        public DataSet consultaEquipo(string pais, string lugar)
        {
            paisEquipo = pais;
            lugarEquipo = lugar;
            return (objD_Equipo.D_consultaEquipo(paisEquipo, lugarEquipo));
        }

        public object N_consutlaLugar()
        {
            var equ1 = objD_Equipo.D_consultaLugar();
            return equ1;
        }

        public bool borrarEquipo(int id)
        {
            idEquipo = id;
            if (objD_Equipo.D_EliminarEquipo(idEquipo))
                return true;
            else
                return false;
        }

        public bool actualizarEquipo(int id, string nombre, string pais, string lugar)
        {
            idEquipo = id;
            nomEquipo = nombre;
            paisEquipo = pais;
            lugarEquipo = lugar;
            if (objD_Equipo.D_ActualizaEquipo(idEquipo,nomEquipo,paisEquipo,lugarEquipo))
                return true;
            else
                return false;
        }

        public object consultaPorNombre(string text)
        {
            nomEquipo = text;
            try
            {
                idEquipo = int.Parse(text);
            }
            catch
            {
                idEquipo = -1;
                Console.WriteLine("Id Equipo: " + idEquipo);
            }
            if (idEquipo ==-1)
            {
                var equi = objD_Equipo.D_consultaEquipoNombre(nomEquipo);
                return equi;
            }
            else
            {
                var equi = objD_Equipo.D_consultaEquipoId(idEquipo);
                return equi;
            }
        }
        
    }
}
