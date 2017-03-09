﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDLaberinto
    {
        MERRobotDataContext bd = new MERRobotDataContext();
        public object D_consultaLista()
        {
            try
            {
                var rob1 = from r in bd.TblLaberintos
                           where r.estado != "SI"
                           select new { r.idRobot, r.TblRobot.nomRobot};
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public string D_consultaListaParticipante()
        {
            try
            {
                string rob1 = (from r in bd.TblLaberintos
                         where r.estado!="SI"
                         select new { r.TblRobot.nomRobot }).FirstOrDefault().nomRobot;
                
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public bool D_ActualizarEstado(int id, string estado)
        {
            try
            {
                TblLaberinto lab1 = bd.TblLaberintos.First(r => r.idBatalla_Laberinto == id);
                lab1.estado = estado;             
                bd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public int D_consultaListaIDBatalla()
        {
            try
            {
                int a = (from r in bd.TblLaberintos
                         where r.estado != "SI"
                         select new { r.idBatalla_Laberinto }).FirstOrDefault().idBatalla_Laberinto;

                return a;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public int D_consultaListaID()
        {
            try
            {
                int a = (from r in bd.TblLaberintos
                         where r.estado != "SI"
                         select new { r.idRobot }).FirstOrDefault().idRobot;
                
                return a;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public string D_consultaListaParticipante2()
        {
            try
            {
                int a = (from r in bd.TblLaberintos
                         select new { r.idRobot }).FirstOrDefault().idRobot;
                string rob1 = (from r in bd.TblRobots
                               where r.idRobot == a
                               select new { r.TblEquipo.nomEquipo }).FirstOrDefault().nomEquipo;
                return rob1;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}