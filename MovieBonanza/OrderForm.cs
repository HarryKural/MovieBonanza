// ______________________________________________________________________________________________
// App name:           Movie Bonanza
// Author's name:      Harshit Sharma
// Student Number#:    200333254
// App Creation Date:  Feb 27, 2017
// Last Modified Date: March 05, 2017
// Professor:          Tom Tsiliopoulos
// Rapid Application Development - Assignment 3
// App description:    This is a multi-form application that allows
//                     user to select a Movie to view from an online video streaming
//                     service called “Movie Bonanza”. It will calculate the cost + taxes
//                     of movie according to the movie category, also provides option to buy DVD.
// ________________________________________________________________________________________________

// using pre-existing libraries
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
        
        // an instance property for title, category, cost as string type
        public static string title { get; set; }

        public string category { get; set; }

        public string cost { get; set; }

        // an instance property for image as Image type
        public Image image { get; set; }

        // Constructor of OrderForm
        public OrderForm()
        {
            InitializeComponent();
            // setting the focus to title label when OrderForm opens
            this.ActiveControl = TitleLabel;
        }

        /// <summary>
        /// This method sets the text fields of textboxes &
        /// image of the pictureBox to invoke accessor.
        /// It calls the _calculateTotal method
        /// </summary>
        public void setInfo()
        {
            TitleTextBox.Text = title;
            CategoryTextBox.Text = category;
            CostTextBox.Text = cost;
            YourOrderPictureBox.Image = image;
            _calculateTotal(DVDChargesCheckBox.Checked);
        }

        /// <summary>
        /// This method handlers all events when any button
        /// is clicked, tagging buttons according to each case.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonClickHandler(object sender, EventArgs e)
        {
            Button ClickHandler = sender as Button;

            switch (ClickHandler.Tag.ToString())
            {
                /*
                 * Stream case creates a new object for StreamForm & shows the Form.
                 * It sets the value of grandTotal, title to the TextBoxes fields.
                 * Calls the info method then Hides the Order Form.
                 */
                case "Stream":
                    StreamForm streamForm = new StreamForm();
                    streamForm.Show();
                    streamForm.grandTotal = GrandTotalTextBox.Text;
                    title = TitleTextBox.Text;
                    streamForm.info();
                    this.Hide();
                    break;

                /*
                 * Cancel case displays a message box showing confirm meesage of exiting the program
                 */
                case "Cancel":
                    // showing up confirm message when cancel button clicked
                    DialogResult result = MessageBox.Show("Are You Sure you want to exit?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    // Closes the program if OK clicked
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    break;

                /*
                 * Back case takes user to the previous form (Selection Form)
                 * Hides the Order Form
                 */
                case "Back":
                    previousForm.Show();
                    this.Hide();
                    break;
            }
        } // End of _buttonClickHandler

        /// <summary>
        /// This method performs the same function as of 'Cancel' case in switch statement.
        /// It generates a Click event of Cancel Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CancelButton.PerformClick();
        }

        /// <summary>
        /// This method displays a message box with Print message
        /// when print is clicked from menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing... Your ticket is in process.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// This method works when about is clicked from menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new object for About Form
            AboutForm aboutForm = new AboutForm();

            // Show the About Form with Show Dialog (a model method to display the form)
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// This method performs same function as Stream button perform.
        /// Using PerformClick which generates click of Stream button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _StreamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StreamButton.PerformClick();
        }

        /// <summary>
        /// This method is used for calculations such as calculating
        /// taxes on subTotal then calculates grandTotal.
        /// </summary>
        /// <param name="DVDCharges"> DVDCharges as a bool</param>
        private void _calculateTotal(bool DVDCharges)
        {
            /*
             * if the checkBox for DVD is checked this parts works
             * and do all the calculations by adding additional cost of 10 dollars.
             */
            if (DVDCharges)
            {
                // Shows the Label & TextBox for DVD.
                // Setting the visible property of Label and TextBox to true.
                DVDChargesLabel.Visible = true;
                DVDChargesTextBox.Visible = true;

                // Instantiate the subTotal, parsing to double.
                // It replaces the $ sign with empty string for calculating purpose, adding 10.00 to subTotal 
                double subTotal = Double.Parse(cost.Replace("$", "")) + 10.00;

                // calculating tax
                double salesTax = subTotal * 0.13;

                // calculating value of grandTotal as sum of total and tax
                double grandTotal = subTotal + salesTax;

                // Setting the value of Text in TextBoxes to the calculated value
                // Converting to ToString(), Math.Round rounds the value to 2 decimal places
                DVDChargesTextBox.Text = "$ 10.00";
                SubTotalTextBox.Text = "$ " + subTotal.ToString();
                SalesTaxTextBox.Text = "$ " + Math.Round(salesTax, 2).ToString();
                GrandTotalTextBox.Text = "$ " + Math.Round(grandTotal, 2).ToString();
            }
            // It will work if the DVD checkBox is unchecked
            else
            {
                // Hides the Label & TextBox
                DVDChargesLabel.Visible = false;
                DVDChargesTextBox.Visible = false;

                double subTotal = Double.Parse(cost.Replace("$", ""));
                double salesTax = subTotal * 0.13;
                double grandTotal = subTotal + salesTax;

                SubTotalTextBox.Text = "$ " + subTotal.ToString();
                SalesTaxTextBox.Text = "$ " + Math.Round(salesTax, 2).ToString();
                GrandTotalTextBox.Text = "$ " + Math.Round(grandTotal, 2).ToString();
            }
        } // End of _calculateTotal

        /// <summary>
        /// This method works as event handler for the CheckBox
        /// by using the _calcutingTotal method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _DVDChargesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._calculateTotal(DVDChargesCheckBox.Checked);
        }
    } // End of OrderForm class
} // End of namespace
