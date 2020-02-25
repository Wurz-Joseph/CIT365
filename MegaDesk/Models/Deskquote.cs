using System;
using System.Collections.Generic;
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
        public int Depth { get; set; }
        public int Width { get; set; }
        public int Drawers { get; set; }
        public int DrawerCost { get; set; }
        public int Area { get; set; }
        public int AreaCost { get; set; }
        public int MaterialCost { get; set; }
        public int ShippingCost { get; set; }
        public string Material { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public double Quote { get; set; }
        public string Rush { get; set; }
    }
}
