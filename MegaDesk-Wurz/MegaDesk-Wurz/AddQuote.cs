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
    public partial class AddQuote : Form
    {
        
        public AddQuote()
        {
            InitializeComponent();
            MaterialsBox.Items.Add(Material.Laminiate);
            MaterialsBox.Items.Add(Material.Oak);
            MaterialsBox.Items.Add(Material.Pine);
            MaterialsBox.Items.Add(Material.Rosewood);
            MaterialsBox.Items.Add(Material.Veneer);
            
        }

        private void GenerateQuoteButton_Click(object sender, EventArgs e)
        {
            int width = int.Parse(WidthTextBox.Text);
            int depth = int.Parse(DepthTextBox.Text);
            int drawers = int.Parse(DrawersTextBox.Text);
            Desk desk = new Desk(width, depth, drawers, Material.Laminiate);

            String customerName = NameTextBox.Text;
            
            DateTime date = new DateTime();
            DeskQuote deskQuote = new DeskQuote(customerName, date,  );
            

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
    }
}
