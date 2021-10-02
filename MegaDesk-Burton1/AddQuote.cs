using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Burton1
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            comboBoxNumberOfDrawers.Items.AddRange(Enum.GetNames(typeof(DesktopMaterial)));
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
            if (ValidateChildren(ValidationConstraints.None))
            {
                try
                {
                    DisplayQuote displayQuote = new DisplayQuote();
                    Desk myDesk = new Desk(int.Parse(TextBoxDeskWidth.Text), int.Parse(TextBoxDeskDepth.Text), int.Parse(TextBoxNumberOfDrawers.Text), ComboBoxDesktopMaterial.Text);
                    DeskQuote myQuote = new DeskQuote(myDesk, ComboBoxRushOrder.Text, TextBoxCustomerName.Text, DateTimePickerOrderDate.Value);
                    displayQuote.MyDeskQuote = myQuote;
                    displayQuote.Show();
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error creating DisplayQuote. Check values and try again.");
                }
            }
    }
}
