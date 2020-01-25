using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Wurz
{


    class Desk
    {
        //max in min values for desk in inches.
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        private int width;
        private int depth;
        private int numberOfDrawers;
        private Material desktopMaterial;

        public Desk()
        {

        }
        public Desk(int width, int depth, int numberOfDrawers, Material desktopMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.numberOfDrawers = numberOfDrawers;
            this.desktopMaterial = desktopMaterial;
        }

        public int SurfaceArea()
        {
            return width * depth;
        }
        //getters and setters
        #region
        public int GetWidth()
        {
            return width;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        }

        public int GetDepth()
        {
            return depth;
        }
        public void SetDepth(int depth)
        {
            this.depth = depth;
        }
        public int GetDrawers()
        {
            return numberOfDrawers;
        }
        public void SetDrawers(int drawers)
        {
            this.numberOfDrawers = drawers;
        }
        public Material GetMaterial()
        {
            return desktopMaterial;
        }
        public void SetMaterial(Material material)
        {
            this.desktopMaterial = material;
        }
        #endregion
    }
    public enum Material
    {
        Oak = 1,
        Laminiate = 2,
        Pine = 3,
        Rosewood = 4,
        Veneer = 5
    }
}
