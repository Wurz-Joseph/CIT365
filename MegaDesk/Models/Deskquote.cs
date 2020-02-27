using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk.Models
{
    public class Deskquote
    {
        public Guid ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Depth is required")]
        [RegularExpression(@"^[1-4][2-8]", ErrorMessage = "A range of 12-48 is required")]
        [DisplayName("Depth (12-48)")]
        public int Depth { get; set; }
        [RegularExpression(@"^[2-9][4-6]", ErrorMessage = "A range of 24-96 is required")]
        [Required(ErrorMessage = "Width is required")]
        [DisplayName("Width (24-96)")]
        public int Width { get; set; }
        [RegularExpression(@"^[0-7]", ErrorMessage = "A range of 0-7 is required")]
        [DisplayName("Width (0-7)")]
        public int Drawers { get; set; }
        public int DrawerCost { get; set; }
        public int Area { get; set; }
        public int AreaCost { get; set; }
        public int MaterialCost { get; set; }
        public int ShippingCost { get; set; }
        public string Material { get; set; }
        [Required(ErrorMessage = "Customer Name is required")]
        public string CustomerName { get; set; }
        public double Quote { get; set; }
        public string Rush { get; set; }

        public const int BASE_PRICE = 200;
        public const int COST_PER_DRAWER = 50;
        
        public enum Materials
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125,
        }

        public int CalculateArea()
        {
            Area = Width * Depth;
            return Area;
        }

        public int CalculateAreaCost()
        {
            if (Area > 1000)
            {
                AreaCost = 200 + (Area - 1000);
                return AreaCost;
            }
            return 200;
        }

        public int CalculateShippingCost(string shipping, int area)
        {
            switch (shipping)
            {
                case "3 Day":
                    if (area < 1000) return 60;
                    if (area >= 1000 && area <= 2000) return 70;
                    if (area > 2000) return 80;
                    return 0;
                case "5 Day":
                    if (area < 1000) return 40;
                    if (area >= 1000 && area <= 2000) return 50;
                    if (area > 2000) return 60;
                    return 0;
                case "7 Day":
                    if (area < 1000) return 30;
                    if (area >= 1000 && area <= 2000) return 35;
                    if (area > 2000) return 40;
                    return 0;
                default:
                    return 0;
            }
        }

        public int CalculateMaterialCost(string material)
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

        public double CalculateQuoteTotal()
        {
            return BASE_PRICE + DrawerCost + MaterialCost + ShippingCost + MaterialCost;

        }

    }
}

