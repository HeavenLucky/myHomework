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
    public partial class FormManage : Form
    {
        OrderService orderService;
        public FormManage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonadd1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(orderidtext.Text);
            string name = textBox2.Text;
            string address = textBox1.Text;
            Customer customer = new Customer(name, address);
            Ordera order = new Ordera(id, customer);
            orderService.orders.Add(order);
            FormAdd2 fa2 = new FormAdd2();
            this.Hide();
            fa2.Show();

        }
    }
}
