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
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        DeskQuote DeskQuote = new DeskQuote();
        AddQuote q = new AddQuote();
        public SearchQuotes()
        {
            InitializeComponent();

            materialInput.DataSource = Enum.GetValues(typeof(Desk.Materials));

        }


        private void NavMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMenu = (MainMenu)Tag;
            viewMenu.Show();
            Close();
        }


        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.materialInput.DataSource = Enum.GetValues(typeof(Desk.Materials));
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            displayQuotes();
        }

        private void displayQuotes()
        {
            //create columns for data table
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Date Created");
            dt.Columns.Add("Depth");
            dt.Columns.Add("Width");
            dt.Columns.Add("Drawers");
            dt.Columns.Add("Shipping");
            dt.Columns.Add("Total");
            dataGridView.DataSource = dt;


            Desk.Materials selectedMaterial = (Desk.Materials)Enum.Parse(typeof(Desk.Materials), materialInput.SelectedItem.ToString());
            foreach (DeskQuote quote in q.quoteCollection)
                if (selectedMaterial == (Desk.Materials)Enum.Parse(typeof(Desk.Materials), quote.material))
                {
                    //populates rows for datatable
                    dt.Rows.Add(new object[] { quote.customerName,
                                               quote.date.ToString("MM/dd/yyyy h:mm tt"),
                                               quote.depth,
                                               quote.width,
                                               quote.drawers,
                                               quote.rush,
                                               quote.quote.ToString("C2") });
                }
        }
    }
}
