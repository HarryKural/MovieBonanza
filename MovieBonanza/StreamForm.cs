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
        public string grandTotal { get; set; }

        public StreamForm()
        {
            InitializeComponent();
        }

        public void info()
        {
            GrandTotalLabel.Text = grandTotal;
            YourMovieLabel.Text = OrderForm.title;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
