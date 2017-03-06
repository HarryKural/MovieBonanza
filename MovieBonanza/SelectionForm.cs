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
    public partial class SelectionForm : Form
    {
        // Create a reference to the previous form
        public Form previousForm;

        // Constructor
        public SelectionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method works according to the movie selected from the drop down list.
        /// Calls the _setInfo method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _currentMoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when any movie selected it enables the next button
            this.NextButton.Enabled = true;

            // sets the value of title text box = selected movie
            TitleTextBox.Text = CurrentMoviesListBox.Text.ToString();
            _setInfo();
        }

        /// <summary>
        /// This method sets the value of all textboxes according to the conditions provided
        /// </summary>
        /* -----------------------------------------------------------------------------------
         * This method contains too many if - else. It might be replaced by any
         * struct, dictionary or something in C# but I was unable to understand that and fix it.
         * -------------------------------------------------------------------------------------
         */
        private void _setInfo()
        {
            /*
             * Sets the category for all the movies according to each titles
             */
            if (TitleTextBox.Text == "Footloose" || TitleTextBox.Text == "Real Steel")
            {
                CategoryTextBox.Text = "New Release";
            }
            else if (TitleTextBox.Text == "The Dilemma" || TitleTextBox.Text == "No Strings Attached" ||
                     TitleTextBox.Text == "Cedar Rapids" || TitleTextBox.Text == "Just Go With It")
            {
                CategoryTextBox.Text = "Comedy";
            }
            else if (TitleTextBox.Text == "Company Men" || TitleTextBox.Text == "The Way Back" ||
                     TitleTextBox.Text == "Waiting For Forever")
            {
                CategoryTextBox.Text = "Drama";
            }
            else if (TitleTextBox.Text == "Season Of The Witch" || TitleTextBox.Text == "I Am Number Four")
            {
                CategoryTextBox.Text = "Sci-Fi";
            }
            else if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                CategoryTextBox.Text = "Family";
            }
            else if (TitleTextBox.Text == "The Rite")
            {
                CategoryTextBox.Text = "Horror";
            }
            else
            {
                CategoryTextBox.Text = "Action";
            }


            /*
             * Sets the cost of movies according to the category of movie
             */
            if (CategoryTextBox.Text == "Family")
            {
                CostTextBox.Text = "$ 0.99";
            }
            else if (CategoryTextBox.Text == "New Release")
            {
                CostTextBox.Text = "$ 4.99";
            }
            else if (CategoryTextBox.Text == "Action" || CategoryTextBox.Text == "Sci-Fi" || CategoryTextBox.Text == "Horror")
            {
                CostTextBox.Text = "$ 2.99";
            }
            else
            {
                CostTextBox.Text = "$ 1.99";
            }

            /*
             * Sets the picture of each movie according to the titles
             */
            if (TitleTextBox.Text == "Season of the Witch")
            {
                YourSelectionPictureBox.Image = Properties.Resources.SeasonOfTheWitch;
            }
            else if (TitleTextBox.Text == "The Green Hornet")
            {
                YourSelectionPictureBox.Image = Properties.Resources.TheGreenHornet;
            }
            else if (TitleTextBox.Text == "The Dilemma")
            {
                YourSelectionPictureBox.Image = Properties.Resources.TheDilemma;
            }
            else if (TitleTextBox.Text == "Death Race 2")
            {
                YourSelectionPictureBox.Image = Properties.Resources.DeathRace2;
            }
            else if (TitleTextBox.Text == "Company Men")
            {
                YourSelectionPictureBox.Image = Properties.Resources.CompanyMen;
            }
            else if (TitleTextBox.Text == "No Strings Attached")
            {
                YourSelectionPictureBox.Image = Properties.Resources.NoStringsAttached;
            }
            else if (TitleTextBox.Text == "The Way Back")
            {
                YourSelectionPictureBox.Image = Properties.Resources.TheWayBack;
            }
            else if (TitleTextBox.Text == "The Mechanic")
            {
                YourSelectionPictureBox.Image = Properties.Resources.TheMechanic;
            }
            else if (TitleTextBox.Text == "The Rite")
            {
                YourSelectionPictureBox.Image = Properties.Resources.TheRite;
            }
            else if (TitleTextBox.Text == "Sanctum")
            {
                YourSelectionPictureBox.Image = Properties.Resources.Sanctum;
            }
            else if (TitleTextBox.Text == "The Other Woman")
            {
                YourSelectionPictureBox.Image = Properties.Resources.TheOtherWoman;
            }
            else if (TitleTextBox.Text == "The Roommate")
            {
                YourSelectionPictureBox.Image = Properties.Resources.TheRoommate;
            }
            else if (TitleTextBox.Text == "Waiting for Forever")
            {
                YourSelectionPictureBox.Image = Properties.Resources.WaitingForForever;
            }
            else if (TitleTextBox.Text == "Cedar Rapids")
            {
                YourSelectionPictureBox.Image = Properties.Resources.CedarRapids;
            }
            else if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                YourSelectionPictureBox.Image = Properties.Resources.GnomeoAndJuliet;
            }
            else if (TitleTextBox.Text == "Just Go With It")
            {
                YourSelectionPictureBox.Image = Properties.Resources.JustGoWithIt;
            }
            else if (TitleTextBox.Text == "The Eagle")
            {
                YourSelectionPictureBox.Image = Properties.Resources.TheEagle;
            }
            else if (TitleTextBox.Text == "I am Number Four")
            {
                YourSelectionPictureBox.Image = Properties.Resources.IAmNumberFour;
            }
            else if (TitleTextBox.Text == "Footloose")
            {
                YourSelectionPictureBox.Image = Properties.Resources.Footloose;
            }
            else
            {
                YourSelectionPictureBox.Image = Properties.Resources.RealSteel;
            }
        } // End of _setInfo()

        /// <summary>
        /// This method works as event handler for the next button
        /// and perform its function by taking the user to next form (Order Form).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _NextButton_Click(object sender, EventArgs e)
        {
            // Instantiate an object to the next form
            OrderForm orderForm = new OrderForm();

            // Pass a reference to the current form to the next form
            orderForm.previousForm = this;

            // Setting the value of all the variables to their respective textBoxes & pictureBox
            OrderForm.title = TitleTextBox.Text;
            orderForm.category = CategoryTextBox.Text;
            orderForm.cost = CostTextBox.Text;
            orderForm.image = YourSelectionPictureBox.Image;

            // Calling the setInfo method from Order Form
            orderForm.setInfo();

            // Show the next form
            orderForm.Show();

            // Hide the form
            this.Hide();
        }
        
    } // End of Selection Form class
} // End of namespace
