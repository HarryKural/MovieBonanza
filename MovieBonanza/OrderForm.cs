﻿using System;
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
        
        public string title { get; set; }

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
        }

        private void _buttonClickHandler(object sender, EventArgs e)
        {
            Button ClickHandler = sender as Button;

            switch (ClickHandler.Tag.ToString())
            {
                case "Stream":
                    StreamForm streamForm = new StreamForm();
                    streamForm.Show();
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
        
    }
}
