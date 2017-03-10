using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Categoria
    {
        MERRobotsDataContext bd = new MERRobotsDataContext();

        public object D_consultaCategoria()
        {
            try
            {
                var Cat = from c in bd.TblCategorias
                          select new
                          {
                              c.idCat,
                              c.nomCat,
                              c.tipoCat
                          };
                return Cat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object D_consultaCategoriaOpcion(int opcion)
        {
            try
            {
                var Cat = from c in bd.TblCategorias
                          where c.tipoCat == opcion
                          select new
                          {
                              c.idCat,
                              c.nomCat,
                              c.tipoCat
                          };
                return Cat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string D_consultaCategoria(int idCategoria)
        {
            try
            {
                var cat1 = (from c in bd.TblCategorias
                            where c.idCat == idCategoria
                            select new { c.nomCat }).FirstOrDefault().nomCat.ToString();
                return cat1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }



    }
}
