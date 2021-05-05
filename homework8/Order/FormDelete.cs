using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{    
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }

        public int Orderid { get;  set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Orderid = Int32.Parse(textBox1.Text);

        }
    }
}
