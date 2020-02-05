using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class Desk
    {
        public enum Materials
        {
            Oak         = 200,
            Laminate    = 100,
            Pine        = 50,
            Rosewood    = 300,
            Veneer      = 125,
        }

        public enum DeskSize
        {
            minWidth = 24,
            maxWidth = 96,
            minDepth = 12,
            maxDepth = 48,
        }

        public int DeskMaterialCost(string material)
        {
            switch (Enum.Parse(typeof(Materials), material))
            {
                case Materials.Oak:
                    return (int)Materials.Oak;
                case Materials.Laminate:
                    return (int)Materials.Laminate;
                case Materials.Pine:
                    return (int)Materials.Pine;
                case Materials.Rosewood:
                    return (int)Materials.Rosewood;
                case Materials.Veneer:
                    return (int)Materials.Veneer;
                default:
                    return 0;
            }
        }
    }
}
