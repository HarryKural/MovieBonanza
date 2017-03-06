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
    public partial class SplashForm : Form
    {
        // Constructor
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is used to display the selection form and hide splash form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            // Instantiate the next form
            SelectionForm selectionForm = new SelectionForm();

            // Pass a reference to the current form to the next form
            selectionForm.previousForm = this;

            // Stopping the timer by setting it to false
            this.SplashFormTimer.Enabled = false;

            // Showing the Selection Form
            selectionForm.Show();

            // Hiding the Splash Form
            this.Hide();
        }
    }
}
