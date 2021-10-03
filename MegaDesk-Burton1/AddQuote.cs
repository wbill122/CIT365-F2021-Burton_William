using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MegaDesk_Burton1
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            comboBoxRushOrder.Items.Add("Normal (14 Days)");
            comboBoxRushOrder.Items.Add("7 Days");
            comboBoxRushOrder.Items.Add("5 Days");
            comboBoxRushOrder.Items.Add("3 Days");
        }

        private void Width_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Depth_Keypress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonSaveQuote_Click(object sender, EventArgs e)
        {

        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }

        private void CustomerName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void buttonDisplayQuote_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}