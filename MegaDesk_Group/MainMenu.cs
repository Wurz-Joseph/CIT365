using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void navAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote newquote = new AddQuote();
            newquote.Tag = this;
            newquote.Show(this);
            Hide();
        }

        private void NavViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewquote = new ViewAllQuotes();
            viewquote.Tag = this;
            viewquote.Show(this);
            Hide();
        }

        private void navSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes findquote = new SearchQuotes();
            findquote.Tag = this;
            findquote.Show(this);
            Hide();
        }

        public void navShowQuote_ref(string json)
        {
            DisplayQuote viewquote = new DisplayQuote(json);
            viewquote.Tag = this;
            viewquote.Show(this);
            Hide();
        }

        private void navExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
