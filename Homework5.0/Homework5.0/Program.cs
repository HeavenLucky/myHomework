using System;

namespace homework5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Goods cake = new Goods("蛋糕", 20, 001);

            Goods apple = new Goods("苹果", 10, 002);
            Goods pen = new Goods("铅笔", 1, 003);

            Customer customer1 = new Customer("shl", "武汉");
            Customer customer2= new Customer("lxy", "武汉");

            OrderDetails orderDetails1 = new OrderDetails(2, apple);
            OrderDetails orderDetails2 = new OrderDetails(2, pen);
            OrderDetails orderDetails3 = new OrderDetails(3, cake);


            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails3);
            Order order2 = new Order(2, customer2);
            order2.AddDetails(orderDetails2);
            OrderService orderService = new OrderService();

            orderService.orders.Add(order1);
            orderService.orders.Add(order2);
            Console.WriteLine("订单列表：");

            orderService.QueryAll().ForEach(
            o => Console.WriteLine(o));


            Console.WriteLine(orderService.QueryOrderById(1));
          


        }
    }
}
