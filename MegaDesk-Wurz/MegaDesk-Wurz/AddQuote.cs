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
        String deliveryString = "";
        
        
        public AddQuote()
        {
            InitializeComponent();
            List<Material> MaterialsList = Enum.GetValues(typeof(Material)).Cast<Material>().ToList();
            MaterialsBox.DataSource = MaterialsList;

        }

        private void GenerateQuoteButton_Click(object sender, EventArgs e)
        {
            String name = NameTextBox.Text;
            String widthString = WidthTextBox.Text;
            int width = int.Parse(WidthTextBox.Text);
            String depthString = DepthTextBox.Text;
            int depth = int.Parse(DepthTextBox.Text);
            String drawersString = DrawersTextBox.Text;
            int drawers = int.Parse(DrawersTextBox.Text);
            String materialString = MaterialsBox.SelectedItem.ToString();
            Material selectedMaterial = (Material)Enum.Parse(typeof(Material), MaterialsBox.SelectedItem.ToString());
            int materialCost = (int)selectedMaterial;

            if (RadioButton3Day.Checked)
            {
                delivery = DeskQuote.THREE_DAY_RUSH;
                deliveryString = "3 Day Rush";
            }
            else if (RadioButton5Day.Checked)
            {
                delivery = DeskQuote.FIVE_DAY_RUSH;
                deliveryString = "5 Day Rush";
            }
            else if (RadioButton7Day.Checked)
            {
                delivery = DeskQuote.SEVEN_DAY_RUSH;
                deliveryString = "7 Day Rush";
            }
            else
            {
                delivery = 14;
                deliveryString = "Standard";
            }



            DeskQuote deskQuote = new DeskQuote(name, DateTime.Now, width, depth, drawers, selectedMaterial, delivery);
            String stringQuoteTotal = deskQuote.CalcQuoteTotal(materialCost).ToString();
            DisplayQuote showQuote = new DisplayQuote(name, widthString, depthString, drawersString, materialString, deliveryString, stringQuoteTotal );
            showQuote.Show();
            this.Close();

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        //Only allow input of numerics
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
            if (WidthTextBox.Text != "")
            {
                try
                {
                    int tryWidth = Convert.ToInt32(WidthTextBox.Text);
                    if (tryWidth < Desk.MIN_WIDTH || tryWidth > Desk.MAX_WIDTH)
                    {
                        MessageBox.Show($"Width must be between {Desk.MIN_WIDTH} and {Desk.MAX_WIDTH} inches.");
                        WidthTextBox.Text = "";
                        e.Cancel = true;
                        WidthTextBox.BackColor = Color.Red;
                    }
                    else
                    {
                        WidthTextBox.BackColor = Color.LightGreen;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
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
            if (DepthTextBox.Text != "")
            {
                try
                {
                    int tryDepth = Convert.ToInt32(DepthTextBox.Text);
                    if (tryDepth < Desk.MIN_DEPTH || tryDepth > Desk.MAX_DEPTH)
                    {
                        MessageBox.Show($"Depth must be between {Desk.MIN_WIDTH} and {Desk.MAX_WIDTH} inches.");
                        DepthTextBox.Text = "";
                        e.Cancel = true;
                        DepthTextBox.BackColor = Color.Red;
                    }
                    else
                    {
                        DepthTextBox.BackColor = Color.LightGreen;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void DrawersTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (DrawersTextBox.Text != "")
            {
                try
                {
                    int tryDrawers = Convert.ToInt32(DrawersTextBox.Text);
                    if (tryDrawers > 7)
                    {
                        MessageBox.Show($"You can have a maximum of 7 Drawers.");
                        DrawersTextBox.Text = "";
                        e.Cancel = true;
                        DrawersTextBox.BackColor = Color.Red;
                    }
                    else
                    {
                        DrawersTextBox.BackColor = Color.LightGreen;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }
        }
    }
}