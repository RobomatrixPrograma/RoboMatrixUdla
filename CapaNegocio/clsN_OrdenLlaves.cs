using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_OrdenLlaves
    {
        clsD_Minisumo D_Minisumo = new clsD_Minisumo();
        clsD_Megasumo D_Megasumo = new clsD_Megasumo();
        clsD_SumoLego D_Sumolego = new clsD_SumoLego();
        clsDLaberinto D_Laberinto = new clsDLaberinto();
        clsD_Dron D_Dron = new clsD_Dron();
        clsD_SeguidorLinea D_SeguidorLinea = new clsD_SeguidorLinea();
        clsDSeguidorLego D_SeguidorLego = new clsDSeguidorLego();
        public int robot1 { get; set; }
        public int robot2 { get; set; }
        public string nomRobot1 { get; set; }
        public string nomRobot2 { get; set; }
        public bool N_ingresarCategoria(int cat, int idr1, int idr2)
        {
            robot1 = idr1;
            robot2 = idr2;
            Console.WriteLine(cat);
            switch(cat)
            {
                case 1:
                    if (D_Minisumo.agregarBatalla(robot1, robot2))
                        return true;
                    else
                        return false; 
                case 2:
                    if (D_Megasumo.agregarBatalla(robot1, robot2))
                        return true;
                    else
                        return false;
                case 3:
                    if (D_Sumolego.agregarBatalla(robot1, robot2))
                        return true;
                    else
                        return false;
                default:
                    return false;
            }
        }
        public bool N_ingresarCategoria(int cat, int idr1)
        {
            robot1 = idr1;
            Console.WriteLine(cat);
            switch (cat)
            {
                case 4:
                    if (D_SeguidorLinea.ingresarOrden(robot1))
                        return true;
                    else
                        return false;
                case 6:
                    if (D_Dron.ingresarOrden(robot1))
                        return true;
                    else
                        return false;
                case 5:
                    if (D_SeguidorLego.ingresarOrden(robot1))
                        return true;
                    else
                        return false;
                case 7:
                    if (D_Laberinto.ingresarOrden(robot1))
                        return true;
                    else
                        return false;
                default:
                    return false;
            }
        }

        public object consultaCategorias(int cat)
        {
            switch (cat)
            {
                case 1:
                    var minis = D_Minisumo.consultaMinisumo();
                    return minis;
                case 2:
                    var megas = D_Megasumo.consultaMegasumo();
                    return megas;
                case 3:
                    var legos = D_Sumolego.consultaLegoSumo();
                     return legos;
                case 4:
                    var seguidor = D_SeguidorLinea.D_consultaLista();
                    return seguidor;
                case 6:
                    var dron = D_Dron.D_consultaLista();
                    return dron;
                case 5:
                    var seguidorLego = D_SeguidorLego.D_consultaListaPresentacion();
                    return seguidorLego;
                case 7:
                    var laberinto = D_Laberinto.D_consultaListaPresentacion();
                    return laberinto;
                default:
                    return null;
            }
        }

        public bool comprobar(int id1, int id2, int cat)
        {
            robot1 = id1;
            robot2 = id2;           
            switch (cat)
            {
                case 1:
                    var minis = D_Minisumo.comprobar(robot1, robot2);
                    if (minis != null)
                        return false;
                    else
                        return true;
                case 2:
                    var megas = D_Megasumo.comprobar(robot1, robot2);
                    if (megas != null)
                        return false;
                    else
                        return true;
                case 3:
                    var legos = D_Sumolego.comprobar(robot1, robot2);
                    if (legos != null)
                        return false;
                    else
                        return true;
                default:
                    return false;
            }
        }
    }
}
