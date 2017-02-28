﻿namespace MovieBonanza
{
    partial class OrderForm
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
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.YourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.YourOrderPictureBox = new System.Windows.Forms.PictureBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.AdditionalChargeTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalChargeLabel = new System.Windows.Forms.Label();
            this.OrderFormMenuStrip.SuspendLayout();
            this.MovieSelectedGroupBox.SuspendLayout();
            this.YourOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourOrderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(704, 27);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "OrderFormMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintToolStripMenuItem,
            this.toolStripSeparator1,
            this.StreamToolStripMenuItem,
            this.toolStripSeparator2,
            this.CancelToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.PrintToolStripMenuItem.Text = "&Print";
            // 
            // StreamToolStripMenuItem
            // 
            this.StreamToolStripMenuItem.Name = "StreamToolStripMenuItem";
            this.StreamToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.StreamToolStripMenuItem.Text = "Strea&m";
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.CancelToolStripMenuItem.Text = "Canc&el";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.YourOrderPictureBox);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryLabel);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleLabel);
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(35, 50);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(288, 394);
            this.MovieSelectedGroupBox.TabIndex = 1;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movie Selected";
            // 
            // YourOrderGroupBox
            // 
            this.YourOrderGroupBox.Controls.Add(this.AdditionalChargeTextBox);
            this.YourOrderGroupBox.Controls.Add(this.AdditionalChargeLabel);
            this.YourOrderGroupBox.Controls.Add(this.checkBox1);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourOrderGroupBox.Controls.Add(this.SubTotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.SubTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.CostTextBox);
            this.YourOrderGroupBox.Controls.Add(this.CostLabel);
            this.YourOrderGroupBox.Location = new System.Drawing.Point(355, 50);
            this.YourOrderGroupBox.Name = "YourOrderGroupBox";
            this.YourOrderGroupBox.Size = new System.Drawing.Size(312, 295);
            this.YourOrderGroupBox.TabIndex = 2;
            this.YourOrderGroupBox.TabStop = false;
            this.YourOrderGroupBox.Text = "Your Order";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.Color.White;
            this.TitleTextBox.ForeColor = System.Drawing.Color.Black;
            this.TitleTextBox.Location = new System.Drawing.Point(31, 45);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(234, 23);
            this.TitleTextBox.TabIndex = 4;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(28, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 17);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.Color.White;
            this.CostTextBox.ForeColor = System.Drawing.Color.Black;
            this.CostTextBox.Location = new System.Drawing.Point(134, 45);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 23);
            this.CostTextBox.TabIndex = 10;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(92, 48);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(36, 17);
            this.CostLabel.TabIndex = 9;
            this.CostLabel.Text = "Cost";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.BackColor = System.Drawing.Color.White;
            this.CategoryTextBox.ForeColor = System.Drawing.Color.Black;
            this.CategoryTextBox.Location = new System.Drawing.Point(31, 96);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(234, 23);
            this.CategoryTextBox.TabIndex = 8;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(28, 75);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(65, 17);
            this.CategoryLabel.TabIndex = 7;
            this.CategoryLabel.Text = "Category";
            // 
            // YourOrderPictureBox
            // 
            this.YourOrderPictureBox.BackColor = System.Drawing.Color.White;
            this.YourOrderPictureBox.Location = new System.Drawing.Point(31, 136);
            this.YourOrderPictureBox.Name = "YourOrderPictureBox";
            this.YourOrderPictureBox.Size = new System.Drawing.Size(234, 240);
            this.YourOrderPictureBox.TabIndex = 9;
            this.YourOrderPictureBox.TabStop = false;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.BackColor = System.Drawing.Color.White;
            this.SubTotalTextBox.ForeColor = System.Drawing.Color.Black;
            this.SubTotalTextBox.Location = new System.Drawing.Point(134, 108);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 23);
            this.SubTotalTextBox.TabIndex = 12;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(59, 111);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(65, 17);
            this.SubTotalLabel.TabIndex = 11;
            this.SubTotalLabel.Text = "SubTotal";
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.BackColor = System.Drawing.Color.White;
            this.SalesTaxTextBox.ForeColor = System.Drawing.Color.Black;
            this.SalesTaxTextBox.Location = new System.Drawing.Point(134, 150);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 23);
            this.SalesTaxTextBox.TabIndex = 14;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(16, 153);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(112, 17);
            this.SalesTaxLabel.TabIndex = 13;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.BackColor = System.Drawing.Color.White;
            this.GrandTotalTextBox.ForeColor = System.Drawing.Color.Black;
            this.GrandTotalTextBox.Location = new System.Drawing.Point(134, 182);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.ReadOnly = true;
            this.GrandTotalTextBox.Size = new System.Drawing.Size(100, 23);
            this.GrandTotalTextBox.TabIndex = 16;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(44, 185);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(84, 17);
            this.GrandTotalLabel.TabIndex = 15;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 246);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(300, 21);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Order the DVD (adds $10.00 to your order)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackButton.Location = new System.Drawing.Point(355, 417);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(73, 27);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelButton.Location = new System.Drawing.Point(513, 417);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(73, 27);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // StreamButton
            // 
            this.StreamButton.BackColor = System.Drawing.Color.White;
            this.StreamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StreamButton.Location = new System.Drawing.Point(594, 417);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(73, 27);
            this.StreamButton.TabIndex = 7;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = false;
            // 
            // AdditionalChargeTextBox
            // 
            this.AdditionalChargeTextBox.BackColor = System.Drawing.Color.White;
            this.AdditionalChargeTextBox.ForeColor = System.Drawing.Color.Black;
            this.AdditionalChargeTextBox.Location = new System.Drawing.Point(134, 77);
            this.AdditionalChargeTextBox.Name = "AdditionalChargeTextBox";
            this.AdditionalChargeTextBox.ReadOnly = true;
            this.AdditionalChargeTextBox.Size = new System.Drawing.Size(100, 23);
            this.AdditionalChargeTextBox.TabIndex = 19;
            // 
            // AdditionalChargeLabel
            // 
            this.AdditionalChargeLabel.AutoSize = true;
            this.AdditionalChargeLabel.Location = new System.Drawing.Point(8, 80);
            this.AdditionalChargeLabel.Name = "AdditionalChargeLabel";
            this.AdditionalChargeLabel.Size = new System.Drawing.Size(120, 17);
            this.AdditionalChargeLabel.TabIndex = 18;
            this.AdditionalChargeLabel.Text = "Additional Charge";
            // 
            // OrderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.ControlBox = false;
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.YourOrderGroupBox);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Order";
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedGroupBox.PerformLayout();
            this.YourOrderGroupBox.ResumeLayout(false);
            this.YourOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourOrderPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StreamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.GroupBox YourOrderGroupBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.PictureBox YourOrderPictureBox;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.TextBox AdditionalChargeTextBox;
        private System.Windows.Forms.Label AdditionalChargeLabel;
    }
}