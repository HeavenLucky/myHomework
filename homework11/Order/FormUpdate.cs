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
    public partial class FormUpdate : Form
    {
        public Ordera Ordera { get; set; } = new Ordera();
        public int Orderid { get; set; }
        public OrderDetails Details { get; set; }
        public int Goodsamount { get; set; }
        public Goods Goods1 { get; set; }
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ordera.orderID = Int32.Parse(textBox1.Text);
          
            string name = textBox3.Text;
            string address = textBox4.Text;
            Customer customer = new Customer(name, address);
          
            Ordera.customer = customer;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Ordera.orderID = Int32.Parse(textBox1.Text);
            string name = textBox3.Text;
            string address = textBox4.Text;
            Ordera.customer = new Customer(name, address);

            Goodsamount = Int32.Parse(textBox2.Text);
            Goods cake = new Goods("蛋糕", 20, 001);

            Goods apple = new Goods("苹果", 10, 002);
            Goods pen = new Goods("铅笔", 1, 003);
            Goods1 = apple;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Goods1 = apple;
                    break;
                case 1:
                    Goods1 = pen;
                    break;
                case 2:
                    Goods1 = cake;
                    break;
            }
            Details = new OrderDetails(Goodsamount, Goods1);
            Ordera.AddDetails(Details);
        }
    }
}
