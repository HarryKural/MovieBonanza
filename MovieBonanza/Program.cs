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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    public static class Program
    {
        // Declared public static form - Application GLOBAL
        public static SplashForm MySplashForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize SplashForm and SelectionForm
            Program.MySplashForm = new SplashForm();

            // It will run the Splash Form when application is started
            Application.Run(Program.MySplashForm);
        }
    }
}
