using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Wurz
{


    public class Desk
    {
        //max in min values for desk in inches.
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public Material Material { get; set; }

        public Desk()
        {

        }
        public Desk(int width, int depth, int numberOfDrawers, Material desktopMaterial)
        {
            Width = width;
            Depth = depth;
            Drawers = numberOfDrawers;
            Material = desktopMaterial;

        }

        public int SurfaceArea()
        {
            return Width * Depth;
        }
   
    }
    public enum Material
    {
        Pine = 50,
        Laminate = 100,
        Veneer = 125,
        Oak = 200,
        Rosewood = 300
    };
}
