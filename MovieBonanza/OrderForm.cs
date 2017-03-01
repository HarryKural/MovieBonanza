using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    public partial class OrderForm : Form
    {
        // Create a reference to the previous form
        public SelectionForm previousForm { get; set; }
        
        public static string title { get; set; }

        public string category { get; set; }

        public string cost { get; set; }

        public Image image { get; set; }

        public OrderForm()
        {
            InitializeComponent();
            this.ActiveControl = TitleLabel;
        }

        public void setInfo()
        {
            TitleTextBox.Text = title;
            CategoryTextBox.Text = category;
            CostTextBox.Text = cost;
            YourOrderPictureBox.Image = image;
            _calculateTotal(DVDChargesCheckBox.Checked);
        }

        private void _buttonClickHandler(object sender, EventArgs e)
        {
            Button ClickHandler = sender as Button;

            switch (ClickHandler.Tag.ToString())
            {
                case "Stream":
                    StreamForm streamForm = new StreamForm();
                    streamForm.Show();
                    streamForm.grandTotal = GrandTotalTextBox.Text;
                    title = TitleTextBox.Text;
                    streamForm.info();
                    this.Hide();
                    break;

                case "Cancel":
                    // showing up confirm message when cancel button clicked
                    DialogResult result = MessageBox.Show("Are You Sure you want to exit?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    break;

                case "Back":
                    previousForm.Show();
                    this.Hide();
                    break;
            }
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CancelButton.PerformClick();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing... Your ticket is in process.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1. Create a new Form
            AboutForm aboutForm = new AboutForm();

            // Step 2. Show the About Form with Show Dialog (a model method to display the form)
            aboutForm.ShowDialog();
        }

        private void StreamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StreamButton.PerformClick();
        }

        private void _calculateTotal(bool DVDCharges)
        {
            if (DVDCharges)
            {
                DVDChargesLabel.Visible = true;
                DVDChargesTextBox.Visible = true;

                double subTotal = Double.Parse(cost.Replace("$", "")) + 10.00;
                double salesTax = subTotal * 0.13;
                double grandTotal = subTotal + salesTax;

                DVDChargesTextBox.Text = "$ 10.00";
                SubTotalTextBox.Text = "$ " + subTotal.ToString();
                SalesTaxTextBox.Text = "$ " + Math.Round(salesTax, 2).ToString();
                GrandTotalTextBox.Text = "$ " + Math.Round(grandTotal, 2).ToString();
            }
            else
            {
                DVDChargesLabel.Visible = false;
                DVDChargesTextBox.Visible = false;

                double subTotal = Double.Parse(cost.Replace("$", ""));
                double salesTax = subTotal * 0.13;
                double grandTotal = subTotal + salesTax;

                SubTotalTextBox.Text = "$ " + subTotal.ToString();
                SalesTaxTextBox.Text = "$ " + Math.Round(salesTax, 2).ToString();
                GrandTotalTextBox.Text = "$ " + Math.Round(grandTotal, 2).ToString();
            }
        }

        private void DVDChargesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._calculateTotal(DVDChargesCheckBox.Checked);
        }
    }
}
