using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Wurz
{
    class DeskQuote
    {
        String customerName;
        DateTime quoteDate;
        decimal quoteTotal;
        public const int BASE_PRICE = 200;
        public const int DRAWER_PRICE = 50;


        public DeskQuote()
        {
        }
        public DeskQuote(String customerName, DateTime quoteDate, decimal quoteTotal)
        {
            this.customerName = customerName;
            this.quoteDate = quoteDate;
            this.quoteTotal = quoteTotal;
        }


        public decimal MaterialCost()
        {
            selectedMaterial
        }

        //public decimal rushedordercost()
        //{

        //}

        //public decimal drawercost()
        //{

        //}
        //public decimal quotetotalcost()
        //{

        //}
    }
}
