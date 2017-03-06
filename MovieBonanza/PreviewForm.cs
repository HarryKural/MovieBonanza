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

// Found this from YouTube video that how to embed video in C# forms

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
    public partial class PreviewForm : Form
    {
        // Create a reference to the previous form
        public SelectionForm previousForm { get; set; }
        
        public string url { get; set; }

        public static string title { get; set; }

        public PreviewForm()
        {
            InitializeComponent();
        }

        public void url_youTube()
        {
            // string for all urls as basic
            string url_base = "https://www.youtube.com/v/";

            if (title == "Real Steel")
            {
                // id for each different movie
                string id_realSteel = "3S8a180uYBM";
                // add both to make url
                axShockwaveFlash.Movie = url_base + id_realSteel;
            }

            else if (title == "I am Number Four")
            {
                string id_realSteel = "g5djHG3hPu0&t=1s";
                axShockwaveFlash.Movie = url_base + id_realSteel;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }
    }
}
