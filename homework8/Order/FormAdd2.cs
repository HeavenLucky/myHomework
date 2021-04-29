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
    public partial class FormAdd2 : Form
    {
        public FormAdd2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(textBox1.Text);
            Goods cake = new Goods("蛋糕", 20, 001);

            Goods apple = new Goods("苹果", 10, 002);
            Goods pen = new Goods("铅笔", 1, 003);
            Goods goods = apple;
            OrderDetails details = new OrderDetails(amount, goods);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    goods = apple;
                    break;
                    case 1:
                    goods = pen;
                    break;
                case 2:
                    goods = cake;
                    break;
            }




        }  
    }
}
