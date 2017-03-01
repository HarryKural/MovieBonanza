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
            this.CreditCardLabel = new System.Windows.Forms.Label();
            this.StreamLabel = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.YourMovieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.White;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OKButton.Location = new System.Drawing.Point(204, 169);
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
            this.ThankLabel.Location = new System.Drawing.Point(79, 35);
            this.ThankLabel.Name = "ThankLabel";
            this.ThankLabel.Size = new System.Drawing.Size(294, 20);
            this.ThankLabel.TabIndex = 8;
            this.ThankLabel.Text = "Thank You for choosing Movie Bonanza!";
            // 
            // CreditCardLabel
            // 
            this.CreditCardLabel.AutoSize = true;
            this.CreditCardLabel.Location = new System.Drawing.Point(89, 78);
            this.CreditCardLabel.Name = "CreditCardLabel";
            this.CreditCardLabel.Size = new System.Drawing.Size(207, 17);
            this.CreditCardLabel.TabIndex = 9;
            this.CreditCardLabel.Text = "Your credit card will be charged";
            // 
            // StreamLabel
            // 
            this.StreamLabel.AutoSize = true;
            this.StreamLabel.Location = new System.Drawing.Point(27, 113);
            this.StreamLabel.Name = "StreamLabel";
            this.StreamLabel.Size = new System.Drawing.Size(284, 17);
            this.StreamLabel.TabIndex = 10;
            this.StreamLabel.Text = "Following movie will begin streaming shortly:";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(296, 78);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(0, 17);
            this.GrandTotalLabel.TabIndex = 11;
            // 
            // YourMovieLabel
            // 
            this.YourMovieLabel.AutoSize = true;
            this.YourMovieLabel.Location = new System.Drawing.Point(311, 113);
            this.YourMovieLabel.Name = "YourMovieLabel";
            this.YourMovieLabel.Size = new System.Drawing.Size(0, 17);
            this.YourMovieLabel.TabIndex = 12;
            // 
            // StreamForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(464, 219);
            this.ControlBox = false;
            this.Controls.Add(this.YourMovieLabel);
            this.Controls.Add(this.GrandTotalLabel);
            this.Controls.Add(this.StreamLabel);
            this.Controls.Add(this.CreditCardLabel);
            this.Controls.Add(this.ThankLabel);
            this.Controls.Add(this.OKButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label CreditCardLabel;
        private System.Windows.Forms.Label StreamLabel;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label YourMovieLabel;
    }
}