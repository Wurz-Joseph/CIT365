using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Wurz
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(String name, String width, String depth, String drawers, String surface, String delivery, String total)
        {
            InitializeComponent();
            NameLabel.Text = name;
            DateLabel.Text = DateTime.Now.ToString("dd MMMM yyyy");
            WidthLabel.Text = width;
            DepthLabel.Text = depth;
            DrawersLabel.Text = drawers;
            SurfaceLabel.Text = surface;
            DeliveryLabel.Text = delivery;
            PriceLabel.Text = "$"+total;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);

        }
    }
}
