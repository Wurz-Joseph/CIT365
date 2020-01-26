using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Wurz
{
    public class DeskQuote
    {
        public String CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public int DeliveryOption { get; set; }
        public double QuoteTotal { get; set; }
        public Desk desk = new Desk();

        public int surfaceArea = 0;
        public const int BASE_PRICE = 200;
        public const int PRICE_PER_DRAWER = 50;
        public const int ADDED_SURFACE_PRICE = 1;
        public const int THREE_DAY_RUSH = 3;
        public const int FIVE_DAY_RUSH = 5;
        public const int SEVEN_DAY_RUSH = 7;

        public DeskQuote()
        {
        }
        public DeskQuote(String customerName, DateTime quoteDate, int width, int depth, int drawers, Material material, int deliveryOption)
        {
            CustomerName = customerName;
            QuoteDate = quoteDate;
            desk.Width = width;
            desk.Depth = depth;
            desk.Drawers = drawers;
            desk.Material = material;
            DeliveryOption = deliveryOption;

            surfaceArea = desk.Width * desk.Depth;
        }

        public double DrawerCost()
        {
            return PRICE_PER_DRAWER * desk.Drawers;
        }

        public double DeliveryCost()
        {
            switch (DeliveryOption)
            {
                case THREE_DAY_RUSH:
                    if (surfaceArea < 1000)
                    {
                        return 60;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        return 70;
                    else if (surfaceArea > 2000)
                        return 80;
                    break;
                case FIVE_DAY_RUSH:
                    if (surfaceArea < 1000)
                    {
                        return 40;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        return 50;
                    else if (surfaceArea > 2000)
                        return 60;
                    break;
                case SEVEN_DAY_RUSH:
                    if (surfaceArea < 1000)
                    {
                        return 30;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        return 35;
                    else if (surfaceArea > 2000)
                        return 40;
                    break;
                default:
                    return 0;
            }
            return -1;
        }
        public double SurfaceCost()
        {
            if (surfaceArea > 1000)
            {
                return (surfaceArea - 1000); 
            }
            else
            {
                return 0;
            }
        }
        public double CalcQuoteTotal(int material)
        {
            return BASE_PRICE + DrawerCost() + SurfaceCost() + DeliveryCost() + material;
    
        }

    }
}
