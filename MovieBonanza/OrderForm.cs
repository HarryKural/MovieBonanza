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
    public partial class OrderForm : Form
    {
        // Create a reference to the previous form
        public SelectionForm previousForm { get; set; }

        public OrderForm()
        {
            InitializeComponent();
        }
    }
}
