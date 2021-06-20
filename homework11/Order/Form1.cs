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
      
            
          public  OrderService OrderService { get; set; } = new OrderService();
      
           public string Keyword { get; set; }

        public Form1()
        {
            InitializeComponent();
       //  Goods cake = new Goods("蛋糕", 20, 001);
       //
       //  Goods apple = new Goods("苹果", 10, 002);
       //  Goods pen = new Goods("铅笔", 1, 003);
       //
       //  Customer customer1 = new Customer("shl", "武汉");
       //  Customer customer2 = new Customer("lxy", "武汉");
       //  Customer customer3 = new Customer("hxy", "江西");
       //  Customer customer4 = new Customer("hxz", "江西");
       //
       //derDetails orderDetails1 = new OrderDetails(2, apple);
       //
       //  OrderDetails orderDetails3 = new OrderDetails(3, cake);
       //
       //  OrderDetails orderDetails4 = new OrderDetails(10, pen);
       //
       //  Ordera order1 = new Ordera(1, customer1);
       //  order1.AddDetails(orderDetails1);
       //  order1.AddDetails(orderDetails3);
       //  Ordera order3 = new Ordera(3, customer4);
       //  Ordera order4 = new Ordera(4, customer2);
       //  order4.AddDetails(orderDetails4);
       //  order4.AddDetails(orderDetails1);
       //  OrderService.orders.Add(order1);
       //  OrderService.orders.Add(order4);
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
                    bindingSourceorder.DataSource = OrderService.orders;
                    break;
                case 1://根据ID查询
                  string orderID =textBox1.Text;
                   
                    Ordera order = OrderService.QueryOrderById(orderID);
                    List<Ordera> result = new List<Ordera>();
                    if (order != null) result.Add(order);
                    bindingSourceorder.DataSource = result;
                    break;
                case 2://根据客户查询

                    bindingSourceorder.DataSource = OrderService.QueryByCustomerName(Keyword);
                    bindingSourceorder.ResetBindings(false);
                    break;
                case 3://根据货物查询
                    bindingSourceorder.DataSource = OrderService.QueryByGoodsName(Keyword);
                    
                    break;
                
            }
            bindingSourceorder.ResetBindings(false);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
     
            FormManage fa = new FormManage();
           // fa.ShowDialog();
            if (fa.ShowDialog() == DialogResult.OK)
            {
                OrderService.AddOrder(fa.Ordera);
                bindingSourceorder.ResetBindings(false);
                bindingSourcegoods.ResetBindings(false);
                    

            }
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            FormDelete fd = new FormDelete();
           if(fd.ShowDialog() == DialogResult.OK)
            {
                OrderService.DeleteOrder(textBox1.Text);
            }
            bindingSourceorder.ResetBindings(false);
        }

        private void updbutton_Click(object sender, EventArgs e)
        {
            FormUpdate fu = new FormUpdate();
            if (fu.ShowDialog() == DialogResult.OK)
            {
                OrderService.Update(fu.Ordera);
            }






                


           bindingSourceorder.ResetBindings(false);
        }

        private void expbutton_Click(object sender, EventArgs e)
        {
         
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                String fileName = saveFileDialog1.FileName;
                OrderService.Export(fileName);
            }

        }

        private void impbutton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String fileName = openFileDialog1.FileName;
                OrderService.Import(fileName);
                OrderService.QueryAll();
                bindingSourceorder.ResetBindings(false);
            }
        }
    }
}
