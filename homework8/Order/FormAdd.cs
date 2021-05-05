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
    {//order属性，主窗体有类的对象
        public Ordera Ordera { get; set; } = new Ordera();
      

        public OrderDetails Details { get; set; }
        public int Goodsamount { get; set; }
        public Goods Goods1 { get; set; }

        public FormManage()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //add detail
        private void buttonadd1_Click(object sender, EventArgs e)
        {
            Ordera.orderID = Int32.Parse(orderidtext.Text);
            string name = textBox2.Text;
            string address = textBox1.Text;
            Ordera.customer = new Customer(name, address);
          
            Goodsamount = Int32.Parse(textBox3.Text);
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
        //ok
        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(orderidtext.Text);
            string name = textBox2.Text;
            string address = textBox1.Text;
            Customer customer = new Customer(name, address);
            Ordera.orderID = id;
            Ordera.customer =customer;


        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
