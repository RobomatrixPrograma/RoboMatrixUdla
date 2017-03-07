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
        public int robot1 { get; set; }
        public int robot2 { get; set; }
        public string nomRobot1 { get; set; }
        public string nomRobot2 { get; set; }
        public bool N_ingresarCategoria(string cat, int idr1, int idr2, string nom1, string nom2)
        {
            robot1 = idr1;
            robot2 = idr2;
            nomRobot1 = nom1;
            nomRobot2 = nom2;
            switch(cat)
            {
                case "Minisumo":
                    break;
                case "Megasumo":
                    break;
                case "Sumo Lego":
                    break;
            }
        }
    }
}
