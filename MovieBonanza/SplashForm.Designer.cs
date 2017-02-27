namespace MovieBonanza
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.MovieBonanzaLabel = new System.Windows.Forms.Label();
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MovieBonanzaLabel
            // 
            this.MovieBonanzaLabel.AutoSize = true;
            this.MovieBonanzaLabel.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold);
            this.MovieBonanzaLabel.Location = new System.Drawing.Point(291, 122);
            this.MovieBonanzaLabel.Name = "MovieBonanzaLabel";
            this.MovieBonanzaLabel.Size = new System.Drawing.Size(228, 31);
            this.MovieBonanzaLabel.TabIndex = 0;
            this.MovieBonanzaLabel.Text = "Movie Bonanza";
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.MovieBonanzaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieBonanzaLabel;
        private System.Windows.Forms.Timer SplashFormTimer;
    }
}