namespace MovieBonanza
{
    partial class SelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.CurrentMoviesLabel = new System.Windows.Forms.Label();
            this.CurrentMoviesListBox = new System.Windows.Forms.ListBox();
            this.YourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.YourSelectionPictureBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.YourSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourSelectionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ChooseLabel.Location = new System.Drawing.Point(36, 26);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(398, 18);
            this.ChooseLabel.TabIndex = 0;
            this.ChooseLabel.Text = "Choose the movie you wish to STREAM from the list below";
            // 
            // CurrentMoviesLabel
            // 
            this.CurrentMoviesLabel.AutoSize = true;
            this.CurrentMoviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CurrentMoviesLabel.Location = new System.Drawing.Point(74, 79);
            this.CurrentMoviesLabel.Name = "CurrentMoviesLabel";
            this.CurrentMoviesLabel.Size = new System.Drawing.Size(103, 17);
            this.CurrentMoviesLabel.TabIndex = 1;
            this.CurrentMoviesLabel.Text = "Current Movies";
            // 
            // CurrentMoviesListBox
            // 
            this.CurrentMoviesListBox.FormattingEnabled = true;
            this.CurrentMoviesListBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.CurrentMoviesListBox.Location = new System.Drawing.Point(57, 107);
            this.CurrentMoviesListBox.Name = "CurrentMoviesListBox";
            this.CurrentMoviesListBox.Size = new System.Drawing.Size(133, 277);
            this.CurrentMoviesListBox.Sorted = true;
            this.CurrentMoviesListBox.TabIndex = 2;
            this.CurrentMoviesListBox.SelectedIndexChanged += new System.EventHandler(this._currentMoviesListBox_SelectedIndexChanged);
            // 
            // YourSelectionGroupBox
            // 
            this.YourSelectionGroupBox.Controls.Add(this.CostTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CostLabel);
            this.YourSelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.YourSelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.TitleLabel);
            this.YourSelectionGroupBox.Controls.Add(this.YourSelectionPictureBox);
            this.YourSelectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.YourSelectionGroupBox.Location = new System.Drawing.Point(244, 107);
            this.YourSelectionGroupBox.Name = "YourSelectionGroupBox";
            this.YourSelectionGroupBox.Size = new System.Drawing.Size(411, 174);
            this.YourSelectionGroupBox.TabIndex = 3;
            this.YourSelectionGroupBox.TabStop = false;
            this.YourSelectionGroupBox.Text = "Your Selection";
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.Color.White;
            this.CostTextBox.ForeColor = System.Drawing.Color.Black;
            this.CostTextBox.Location = new System.Drawing.Point(321, 135);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(74, 23);
            this.CostTextBox.TabIndex = 6;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(318, 114);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(36, 17);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.BackColor = System.Drawing.Color.White;
            this.CategoryTextBox.ForeColor = System.Drawing.Color.Black;
            this.CategoryTextBox.Location = new System.Drawing.Point(164, 135);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(136, 23);
            this.CategoryTextBox.TabIndex = 4;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(161, 114);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(65, 17);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.Color.White;
            this.TitleTextBox.ForeColor = System.Drawing.Color.Black;
            this.TitleTextBox.Location = new System.Drawing.Point(161, 43);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(234, 23);
            this.TitleTextBox.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(158, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 17);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // YourSelectionPictureBox
            // 
            this.YourSelectionPictureBox.BackColor = System.Drawing.Color.White;
            this.YourSelectionPictureBox.InitialImage = null;
            this.YourSelectionPictureBox.Location = new System.Drawing.Point(23, 22);
            this.YourSelectionPictureBox.Name = "YourSelectionPictureBox";
            this.YourSelectionPictureBox.Size = new System.Drawing.Size(105, 136);
            this.YourSelectionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YourSelectionPictureBox.TabIndex = 0;
            this.YourSelectionPictureBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.White;
            this.NextButton.Enabled = false;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NextButton.Location = new System.Drawing.Point(582, 357);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(73, 27);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this._NextButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.YourSelectionGroupBox);
            this.Controls.Add(this.CurrentMoviesListBox);
            this.Controls.Add(this.CurrentMoviesLabel);
            this.Controls.Add(this.ChooseLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanza - Your Online Streaming Service";
            this.YourSelectionGroupBox.ResumeLayout(false);
            this.YourSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourSelectionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.Label CurrentMoviesLabel;
        private System.Windows.Forms.ListBox CurrentMoviesListBox;
        private System.Windows.Forms.GroupBox YourSelectionGroupBox;
        private System.Windows.Forms.PictureBox YourSelectionPictureBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Button NextButton;
    }
}

