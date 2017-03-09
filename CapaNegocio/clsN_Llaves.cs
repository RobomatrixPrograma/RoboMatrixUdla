using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Llaves
    {
        clsD_Minisumo D_Minisumo = new clsD_Minisumo();
        clsD_Megasumo D_Megasumo = new clsD_Megasumo();
        clsD_SumoLego D_Sumolego = new clsD_SumoLego();
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
                case 2:
                    if (D_Minisumo.agregarBatalla(robot1, robot2))
                        return true;
                    else
                        return false; 
                case 1:
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

        public object consultaCategorias(int cat)
        {
            switch (cat)
            {
                case 2:
                    var minis = D_Minisumo.consultaMinisumo();
                        return minis;
                case 1:
                    var megas = D_Megasumo.consultaMegasumo();
                        return megas;
                case 3:
                    var legos = D_Sumolego.consultaLegoSumo();
                        return legos;
                default:
                    return null;
            }
        }
    }
}
