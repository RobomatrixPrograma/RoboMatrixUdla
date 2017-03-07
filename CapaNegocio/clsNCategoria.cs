using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class clsNCategoria
    {
        clsDCategoria D_objCategoria = new clsDCategoria();
        int idCategoria { get; set; }
        string nombre { get; set; }
        string descripcion { get; set; }
        public object consultaCategoria()
        {
            var cat1 = D_objCategoria.D_consultaCategoria();
            return cat1;
        }

        public string consultaCategoria(int id)
        {
            idCategoria = id;
            return D_objCategoria.D_consultaCategoria(idCategoria);
        }
    }
}
