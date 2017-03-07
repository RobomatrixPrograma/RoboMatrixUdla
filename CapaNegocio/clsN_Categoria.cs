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

        }
    }
}
