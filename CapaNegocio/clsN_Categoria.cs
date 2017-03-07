using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Categoria
    {
        clsD_Categoria objD_Categoria = new clsD_Categoria();
        public int idCat { get; set; }
        public string nomCat { get; set; }
        public int tipoCat { get; set; }

        public object N_consultaCategoria()
        {
            var Cat1 = objD_Categoria.D_consultaCategoria();
            return Cat1;

        }
        public object N_consultaCategoria(int tipo)
        {
            tipoCat = tipo;
            var Cat1 = objD_Categoria.D_consultaCategoria(tipoCat);
            return Cat1;

        }

        public object GenerarOrden(int id, string nom)
        {
            idCat = id;
            nomCat = nom;
            switch (nomCat)
            {
                case "Minisumo":
                    break;
                case "Microsumo":
                    break;
                case "Legosumo":
                    break;
                case "Seguidor de Linea":
                    var cat1 = objD_Categoria.generarSeguidor();
                    return cat1;
                    break;
                case "Lego Seguidor de Linea":
                    var cat2 = objD_Categoria.generarSeguidorLego();
                    return cat2;
                    break;
                case "Laberinto":
                    var cat3 = objD_Categoria.generarLaberinto();
                    return cat3;
                    break;
                case "Dron":
                    var cat4 = objD_Categoria.generarDron();
                    return cat4;
                    break;
                case "Robotopia":
                    var cat5 = objD_Categoria.generarRobotopia();
                    return cat5;
                    break;
            }
        }
    }
}
