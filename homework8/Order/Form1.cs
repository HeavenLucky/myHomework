using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Order
{
    public partial class Form1 : Form
    {
      
            
          public  OrderService orderService { get; set; } = new OrderService();
      
           public string Keyword { get; set; }
       
        public Form1()
        {
            InitializeComponent();
          
            Goods cake = new Goods("蛋糕", 20, 001);

            Goods apple = new Goods("苹果", 10, 002);
            Goods pen = new Goods("铅笔", 1, 003);

            Customer customer1 = new Customer("shl", "武汉");
            Customer customer2 = new Customer("lxy", "武汉");

            OrderDetails orderDetails1 = new OrderDetails(2, apple);
            OrderDetails orderDetails2 = new OrderDetails(2, pen);
            OrderDetails orderDetails3 = new OrderDetails(3, cake);


            Ordera order1 = new Ordera(1, customer1);
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails3);
            Ordera order2 = new Ordera(2, customer2);
            order2.AddDetails(orderDetails2);
            
            orderService.orders.Add(order1);
            orderService.orders.Add(order2);
            bindingSourceorder.DataSource = orderService.orders;

            textBox1.DataBindings.Add("Text", this, "Keyword");
            comboBox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quebutton_Click(object sender, EventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0://所有订单
                    bindingSourceorder.DataSource = orderService.orders;
                    break;
                case 1://根据ID查询
                  int orderID =Int32.Parse(textBox1.Text);
                   
                    Ordera order = orderService.QueryOrderById(orderID);
                    List<Ordera> result = new List<Ordera>();
                    if (order != null) result.Add(order);
                    bindingSourceorder.DataSource = result;
                    break;
                case 2://根据客户查询

                    bindingSourceorder.DataSource = orderService.QueryByCustomerName(Keyword);
                    bindingSourceorder.ResetBindings(false);
                    break;
                case 3://根据货物查询
                    bindingSourceorder.DataSource = orderService.QueryByGoodsName(Keyword);
                    
                    break;
                
            }
            bindingSourceorder.ResetBindings(false);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManage fa = new FormManage();
            fa.Show();
        }
    }
}
