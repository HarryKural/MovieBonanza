namespace MovieBonanza
{
    partial class StreamForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.ThankLabel = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.YourMovieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.White;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OKButton.Location = new System.Drawing.Point(175, 166);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(73, 27);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ThankLabel
            // 
            this.ThankLabel.AutoSize = true;
            this.ThankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ThankLabel.Location = new System.Drawing.Point(60, 36);
            this.ThankLabel.Name = "ThankLabel";
            this.ThankLabel.Size = new System.Drawing.Size(294, 20);
            this.ThankLabel.TabIndex = 8;
            this.ThankLabel.Text = "Thank You for choosing Movie Bonanza!";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(104, 79);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(207, 17);
            this.GrandTotalLabel.TabIndex = 9;
            this.GrandTotalLabel.Text = "Your credit card will be charged";
            // 
            // YourMovieLabel
            // 
            this.YourMovieLabel.AutoSize = true;
            this.YourMovieLabel.Location = new System.Drawing.Point(118, 113);
            this.YourMovieLabel.Name = "YourMovieLabel";
            this.YourMovieLabel.Size = new System.Drawing.Size(177, 17);
            this.YourMovieLabel.TabIndex = 10;
            this.YourMovieLabel.Text = "will begin streaming shortly";
            // 
            // StreamForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(415, 219);
            this.ControlBox = false;
            this.Controls.Add(this.YourMovieLabel);
            this.Controls.Add(this.GrandTotalLabel);
            this.Controls.Add(this.ThankLabel);
            this.Controls.Add(this.OKButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Movie is about to start!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label ThankLabel;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label YourMovieLabel;
    }
}