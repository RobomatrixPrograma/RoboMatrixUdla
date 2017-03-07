using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDCategoria
    {
        MERRobotDataContext bd = new MERRobotDataContext();
        public object D_consultaCategoria()
        {
            try
            {
                var cat1 = from c in bd.TblCategorias
                           select new { c.idCat, c.nomCat, c.descripcion };
                return cat1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public string D_consultaCategoria(int idCategoria)
        {
            try
            {
                var cat1 = (from c in bd.TblCategorias
                           where c.idCat==idCategoria
                           select new {c.nomCat }).FirstOrDefault().nomCat.ToString();
                return cat1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
