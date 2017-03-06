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
    public partial class StreamForm : Form
    {
        // Instantiate variable as a string
        public string grandTotal { get; set; }

        // Constructor
        public StreamForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is used to set the value of empty
        /// text labels to show cost and title of the movie.
        /// </summary>
        public void info()
        {
            GrandTotalLabel.Text = grandTotal;
            YourMovieLabel.Text = OrderForm.title;
        }

        /// <summary>
        /// This event handler exits the program by clicking the OK button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
