using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Burton
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            buttonAddQuote addQuoteForm = new buttonAddQuote();
            addQuoteForm.Show();
            this.Hide();
        }
    }
}
