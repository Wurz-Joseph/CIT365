using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        DeskQuote DeskQuoteParse = new DeskQuote();
        Desk Desk = new Desk();

        public DisplayQuote(string json)
        {
            InitializeComponent();
            DeskQuoteParse = JsonConvert.DeserializeObject<DeskQuote>(json);
            parsefields(DeskQuoteParse);
            Console.WriteLine(json);

        }

        private void parsefields(DeskQuote DeskQuoteParse)
        {
            dateDisplay.Text = (DeskQuoteParse.date).ToString("dddd, dd MMMM yyyy");
            quoteInput.Text = DeskQuoteParse.id.ToString();

            depthInput.Text = DeskQuoteParse.depth.ToString();
            widthInput.Text = DeskQuoteParse.width.ToString();

            drawerCost.Text = (DeskQuoteParse.drawerCost).ToString("C2");
            drawerInput.Value = DeskQuoteParse.drawers;

            materialInput.Text = DeskQuoteParse.material;
            materialCost.Text = (DeskQuoteParse.materialCost).ToString("C2");

            nameInput.Text = DeskQuoteParse.customerName;
            areaCost.Text = (DeskQuoteParse.areaCost).ToString("C2");
            areaOutput.Text = "Area: " + (DeskQuoteParse.area).ToString() + " in\xB2";

            shippingCost.Text = (DeskQuoteParse.shippingCost).ToString("C2");
            shippingInput.Text = DeskQuoteParse.rush;

            quoteTotal.Text = (DeskQuoteParse.quote).ToString("C2");
        }

        private void NavMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMenu = (MainMenu)Tag;
            viewMenu.Show();
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }
       
    }
}
