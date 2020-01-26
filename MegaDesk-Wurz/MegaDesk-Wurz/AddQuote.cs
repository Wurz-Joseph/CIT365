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
        int delivery = 0;
        public AddQuote()
        {
            InitializeComponent();
            List<Material> MaterialList = Enum.GetValues(typeof(Material)).Cast<Material>().ToList();
            MaterialsBox.DataSource = MaterialList;
        }

        private void GenerateQuoteButton_Click(object sender, EventArgs e)
        {
            String name = NameTextBox.Text;
            int width = int.Parse(WidthTextBox.Text);
            int depth = int.Parse(DepthTextBox.Text);
            int drawers = int.Parse(DrawersTextBox.Text);
            Material selectedMaterial = (Material)Enum.Parse(typeof(Material), MaterialsBox.SelectedItem.ToString());
            int materialCost = (int)selectedMaterial;

            if (RadioButton3Day.Checked)
            {
                delivery = DeskQuote.THREE_DAY_RUSH;
            }
            else if (RadioButton5Day.Checked)
            {
                delivery = DeskQuote.FIVE_DAY_RUSH;
            }
            else if (RadioButton7Day.Checked)
            {
                delivery = DeskQuote.SEVEN_DAY_RUSH;
            }
            else
            {
                delivery = 14;
            }



            DeskQuote deskQuote = new DeskQuote(name, DateTime.Now, width, depth, drawers, selectedMaterial, delivery);
            DisplayQuote showQuote = new DisplayQuote(name, deskQuote.CalcQuoteTotal(materialCost).ToString());
            showQuote.Show();
            this.Close();

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void WidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void WidthTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(WidthTextBox.Text))
            {
                e.Cancel = true;
                WidthTextBox.Focus();
            }

            if (int.Parse(WidthTextBox.Text) < Desk.MIN_WIDTH || int.Parse(WidthTextBox.Text) > Desk.MAX_WIDTH)
            {
                MessageBox.Show($"Width must be between {Desk.MIN_WIDTH} AND {Desk.MAX_WIDTH} inches.");
                WidthTextBox.BackColor = Color.Red;
                e.Cancel = true;
                WidthTextBox.Text = "";
                WidthTextBox.Focus();
            }
            else
            {
                WidthTextBox.BackColor = Color.LightGreen;
            }


        }

        private void DepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }



        private void DepthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(DepthTextBox.Text) < Desk.MIN_DEPTH || int.Parse(DepthTextBox.Text) > Desk.MAX_DEPTH)
            {
                MessageBox.Show($"Depth must be between {Desk.MIN_DEPTH} AND {Desk.MAX_DEPTH} inches.");
                DepthTextBox.BackColor = Color.Red;
                e.Cancel = true;
                DepthTextBox.Text = "";
                DepthTextBox.Focus();
            }
            else
            {
                DepthTextBox.BackColor = Color.LightGreen;

            }
        }
    }
}