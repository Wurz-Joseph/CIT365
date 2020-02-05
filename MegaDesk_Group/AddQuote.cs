using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Web.Helpers;
using Newtonsoft.Json;
using System.IO;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        DeskQuote DeskQuote = new DeskQuote();
        Desk Desk = new Desk();
        public List<DeskQuote> quoteCollection = new List<DeskQuote>();

        public AddQuote()
        {
            InitializeComponent();

            //import json file. Deserialize into a list of DeskQuote objects
            materialInput.DataSource = Enum.GetValues(typeof(Desk.Materials));
            String jsonFile = "quote.json";
            if (File.Exists(jsonFile))
            {
                String rawJson = File.ReadAllText("quote.json");
                quoteCollection = JsonConvert.DeserializeObject<List<DeskQuote>>(rawJson);
            }
        }


        public int GetDepth() { return Int32.Parse(depthInput.Text); }
        public int GetWidth() { return Int32.Parse(widthInput.Text); }
        private void NavMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMenu = (MainMenu)Tag;
            viewMenu.Show();
            Close();
        }

        private void DrawerInput_ValueChanged(object sender, EventArgs e)
        {
            if (drawerInput.Value > 7) drawerInput.Value = 7;
            if (drawerInput.Value < 0) drawerInput.Value = 0;

            decimal amount = drawerInput.Value * 50;
            drawerCost.Text = amount.ToString("N1");
            ChangeValues();
        }



        private void DepthInput_Validating(object sender, CancelEventArgs e)
        {
            if (!depthInput.Text.All(Char.IsDigit))
            {
                depthInput.Text = "";
                depthInput.Focus();
            }
            else if (depthInput.Text != "" || depthInput.Text != String.Empty)
            {
                int depth = GetDepth();
                if (depth < (int)Desk.DeskSize.minDepth) depthInput.Text = (int)Desk.DeskSize.minDepth + "";
                if (depth > (int)Desk.DeskSize.maxDepth) depthInput.Text = (int)Desk.DeskSize.maxDepth + "";

                if (widthInput.Text != "" || widthInput.Text != String.Empty)
                {
                    ChangeValues();
                }
            }
        }

        private void WidthInput_Validating(object sender, CancelEventArgs e)
        {
            if (!widthInput.Text.All(Char.IsDigit))
            {
                widthInput.Text = "";
                widthInput.Focus();
            }
            else if (widthInput.Text != "" || widthInput.Text != String.Empty)
            {
                int width = Int32.Parse(widthInput.Text);
                if (width < (int)Desk.DeskSize.minWidth) widthInput.Text = (int)Desk.DeskSize.minWidth + "";
                if (width > (int)Desk.DeskSize.maxWidth) widthInput.Text = (int)Desk.DeskSize.maxWidth + "";

                if (depthInput.Text != "" || depthInput.Text != String.Empty)
                {
                    ChangeValues();
                }

            }
        }

        private void getQuoteValue()
        {
            int depth = GetDepth();
            int width = GetWidth();
            areaOutput.Text =
                "Area: " + DeskQuote.AreaCalculate(depth, width) + " in\xB2";
            areaCost.Text =
                DeskQuote.AreaCost(depth, width).ToString("C2");
            shippingCost.Text =
                DeskQuote.ShippingCost(shippingInput.Text, DeskQuote.AreaCalculate(depth, width)).ToString("C2");
            materialCost.Text =
                Desk.DeskMaterialCost(materialInput.Text).ToString("C2");

            CalculateTotal();
        }

        private bool ChangeValues()
        {

            try
            {
                getQuoteValue();
            }
            catch (Exception ex)
            {
                ShowDialog("Please fill out the request and try again!");
                Console.WriteLine("{0} Exception caught.", ex);
                return false;
            }
            return true;
        }

        private void ShippingInput_Validating(object sender, CancelEventArgs e)
        {
            if (!shippingInput.Items.Contains(shippingInput.Text))
            {
                shippingInput.Text = "";
                shippingCost.Text = "$";
            }
            else
            {
                ChangeValues();
            }
        }

        private void MaterialInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Enum.IsDefined(typeof(Desk.Materials), materialInput.Text))
            {
                ShowDialog("Please enter a valid material");
                materialInput.Text = "";
                materialCost.Text = "$";
            }
            else
            {
                ChangeValues();
            }
        }

        private void CalculateTotal()
        {
            int area, drawers, shipping, materials;

            area = DeskQuote.AreaCost(GetDepth(), GetWidth());
            drawers = Int32.Parse(drawerInput.Text) * 50;
            shipping = DeskQuote.ShippingCost(shippingInput.Text, area);
            materials = Desk.DeskMaterialCost(materialInput.Text);

            int total = (area + drawers + shipping + materials);
            quoteTotal.Text = total.ToString("C2");
        }

        private void NameInput_Validating(object sender, CancelEventArgs e)
        {
            if (nameInput.Text == null || nameInput.Text == "")
            {
                nameInput.Text = "";
                nameInput.Focus();
            }
        }

        private void SubmitQuote_Click(object sender, EventArgs e)
        {

            bool val = ChangeValues();

            if (val)
            {
                //ShowDialog("Will be implemented next week!");
                DeskQuote DeskQuoteParse = new DeskQuote();

                DeskQuoteParse.id = Guid.NewGuid();
                //Changed from .Today to .Now so it sends time of day with date to json file.
                DeskQuoteParse.date = DateTime.Now;
                DeskQuoteParse.depth = Int32.Parse(depthInput.Text);
                DeskQuoteParse.width = Int32.Parse(widthInput.Text);
                DeskQuoteParse.drawers = Int32.Parse(drawerInput.Text);
                DeskQuoteParse.drawerCost = Int32.Parse(drawerInput.Text) * 50;
                DeskQuoteParse.area = Int32.Parse(depthInput.Text) * Int32.Parse(widthInput.Text);
                DeskQuoteParse.areaCost = DeskQuote.AreaCost(Int32.Parse(depthInput.Text), Int32.Parse(widthInput.Text));
                DeskQuoteParse.material = materialInput.Text;

                DeskQuoteParse.materialCost = Desk.DeskMaterialCost(materialInput.Text);
                DeskQuoteParse.customerName = nameInput.Text;
                DeskQuoteParse.rush = shippingInput.Text;
                DeskQuoteParse.shippingCost = DeskQuote.ShippingCost(shippingInput.Text, DeskQuoteParse.area);
                DeskQuoteParse.quote = (DeskQuoteParse.areaCost + DeskQuoteParse.drawerCost + DeskQuoteParse.shippingCost + DeskQuoteParse.materialCost);

                var json = JsonConvert.SerializeObject(DeskQuoteParse);

                if (json != null && json != "")
                {
                    SubmitQuote(json);
                }

                quoteCollection.Add(DeskQuoteParse);
                SaveToFile(quoteCollection);
            }
        }

        private void ShowDialog(string v)
        {
            MessageBox.Show(v, "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.materialInput.DataSource = Enum.GetValues(typeof(Desk.Materials));
        }

        private void getQuote_Click(object sender, EventArgs e)
        {
            ChangeValues();
        }

        private void SubmitQuote(string json)
        {
            MainMenu viewMenu = (MainMenu)Tag;
            viewMenu.navShowQuote_ref(json);
            Close();
        }

        public void SaveToFile(List<DeskQuote> json)
        {
            //open file stream
            using (StreamWriter file = File.CreateText("quote.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, json);
            }
        }
    }
}
