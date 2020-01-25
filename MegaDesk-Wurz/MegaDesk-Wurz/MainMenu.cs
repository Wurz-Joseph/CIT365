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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //change view to AddNewQuote form
        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuoteForm = new AddQuote();
            viewAddQuoteForm.Tag = this;
            viewAddQuoteForm.Show(this);
            Hide();
        }

        //change view to viewAllQuotes form
        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Tag = this;
            viewAllQuotesForm.Show(this);
            Hide();

        }

        //change view to searchQuotes form
        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotesForm = new SearchQuotes();
            viewSearchQuotesForm.Tag = this;
            viewSearchQuotesForm.Show(this);
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
