using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework5;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace homework5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        Goods cake = new Goods("蛋糕", 20, 001);

        Goods apple = new Goods("苹果", 10, 002);
        Goods pen = new Goods("铅笔", 1, 003);

        public static  Customer customer1 = new Customer("shl", "武汉");
        public static Customer customer2 = new Customer("lxy", "武汉");
        public static Customer customer3 = new Customer("hxy", "江西");
        public static Customer customer4 = new Customer("hxz", "江西");
        OrderService orderService = new OrderService();

        Order order1 = new Order(1, customer1);
        Order order3= new Order(3, customer4);
        Order order4 = new Order(4, customer2);
        public void Init() {
            OrderDetails orderDetails1 = new OrderDetails(2, apple);
            OrderDetails orderDetails3 = new OrderDetails(3, cake);
            OrderDetails orderDetails4 = new OrderDetails(10, pen);

          
            order4.AddDetails(orderDetails4);
            order4.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails3);
           
          

            orderService.orders.Add(order1);
            orderService.orders.Add(order4);

        }
     
      

      

        [TestMethod()]
        public void AddOrderTest()
        {
            OrderDetails orderDetails2 = new OrderDetails(2, pen);
            Order order2 = new Order(2, customer2);
            order2.AddDetails(orderDetails2);
            orderService.orders.Add(order2);
            Assert.AreEqual(2, order2.orderID);
         
           
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            orderService.DeleteOrder(1);
            List<Order> neworderlist = new List<Order>();
            neworderlist = orderService.orders;
            bool isContained = neworderlist.Exists( o=>o.orderID==1);
            Assert.IsFalse(isContained);
        }

        [TestMethod()]
        public void QueryOrderByIdTest()
        { Order order4 = new Order(4,customer1);
            orderService.AddOrder(order4);

         
         Order reorder = orderService.QueryOrderById(4);

            Assert.AreEqual(order4, reorder);
            
        }

       

        [TestMethod()]
        public void UpdateTest()
        {
            Order order3 = new Order(3, customer1);
            order3.AddDetails(new OrderDetails(3, apple));
            orderService.Update(order3);

            Assert.AreEqual(3,order3.orderID);
            Assert.AreEqual(order3.customer, customer1);
        }

        [TestMethod()]
        public void QueryByGoodsNameTest()
        {
            Assert.AreEqual(1, orderService.QueryByGoodsName("蛋糕").Count);

          
        }

      
      
        [TestMethod()]
       public void QueryByCustomerNameTest()
       {   
           Assert.AreEqual(1, orderService.QueryByCustomerName("hxz").Count);
       }
       
      
      

        [TestMethod()]
        public void ExportTest()
        {
            string file = "ex.xml";
            orderService.Export(file);
            string txt1 = File.ReadAllText(file);
          string expecttxt=File.ReadAllText("")；
            Assert.AreEqual(file,"");
        }

        [TestMethod()]
        public void ImportTest()
        {
            string file = "im.xml";
            orderService.Import(file);

            List<Order> expectlist =;
            //判断导入后的订单是否和期待的订单是一样的
            Assert.AreEqual(expectlist, orderService.orders);

          
        }
    }
}