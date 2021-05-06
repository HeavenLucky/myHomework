using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
namespace homework5
{
    [Serializable]
    public class OrderService
    {
        public List<Order> orders = new List<Order>();

        public OrderService()
        {

        }
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void DeleteOrder(int orderID)
        {
            orders.RemoveAll(o => o.orderID == orderID);
        }

        public Order QueryOrderById(int orderId)
        {
            //????
            return orders.Where(o => o.orderID == orderId).FirstOrDefault();
            
        }
        //排序不会～～
      

        public List<Order> QueryAll()
        {
            return orders;
        }

        public void Update(Order order)
        {
            DeleteOrder(order.orderID);
            orders.Add(order);
        }

        public IEnumerable<Order> Query(Predicate<Order> condition)
        {
            return orders.Where(o => condition(o));
        }

        public List<Order> QueryByGoodsName(string goodsName)
        {
            var query = orders.Where(
              o => o.orderlist.Any(d => d.goods.goodsname == goodsName));
            return query.ToList();
        }

        public List<Order> QueryByTotalAmount(double totalAmount)
        {
            var query = orders.Where(o => o.TotalAmount >= totalAmount);
            return query.ToList();
        }

        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orders
                .Where(o => o.customer.name == customerName);
            return query.ToList();
        }


        public void Sort(Comparison<Order> comparison)
        {
            orders.Sort(comparison);
        }
        //将订单序列化为xml！！
        public void Export(String path)

        {
            FileStream fs = File.Create(path);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));

            xmlSerializer.Serialize(fs, orders);


        }
        //xml转order！！
        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using FileStream fs = new FileStream(path, FileMode.Open);
            List<Order> listtemp = (List<Order>)xs.Deserialize(fs);
            foreach(var order in listtemp)
            {
                if (!orders.Contains(order))
                {
                    orders.Add(order);
                }
            };

        }
    }
}