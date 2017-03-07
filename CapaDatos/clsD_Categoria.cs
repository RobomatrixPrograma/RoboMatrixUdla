﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Categoria
    {
        MERRobotDataContext bd = new MERRobotDataContext();

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

        public object D_consultaCategoria(int opcion)
        {
            try
            {
                var Cat = from c in bd.TblCategorias
                          where tipoCat == opcion
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


    }
}