using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
namespace Order
{
    [Serializable]
    public class OrderService
    {
        public List<Ordera> orders = new List<Ordera>();

        public OrderService()
        {

        }
        public void AddOrder(Ordera order)
        {
            if (orders.Contains(order))
                throw new ApplicationException($"添加错误: 订单已经存在了!");
            orders.Add(order);
        }

        public void DeleteOrder(int orderID)
        {
            orders.RemoveAll(o => o.orderID == orderID);
        }

        public Ordera QueryOrderById(int orderId)
        {
            //????
            return orders.Where(o => o.orderID == orderId).FirstOrDefault();

        }
       


        public List<Ordera> QueryAll()
        {
            return orders;
        }

        public void Update(Ordera order)
        {
            DeleteOrder(order.orderID);
            orders.Add(order);
        }

        public IEnumerable<Ordera> Query(Predicate<Ordera> condition)
        {
            return orders.Where(o => condition(o));
        }

        public List<Ordera> QueryByGoodsName(string goodsName)
        {
            var query = orders.Where(
              o => o.orderlist.Any(d => d.Goods.goodsname == goodsName));
            return query.ToList();
        }

        public List<Ordera> QueryByTotalAmount(double totalAmount)
        {
            var query = orders.Where(o => o.TotalAmount >= totalAmount);
            return query.ToList();
        }

        public List<Ordera> QueryByCustomerName(string customerName)
        {
            var query = orders
                .Where(o => o.customer.name == customerName);
            return query.ToList();
        }


        public void Sort(Comparison<Ordera> comparison)
        {
            orders.Sort(comparison);
        }
        //将订单序列化为xml！！
        public void Export(String path)

        {
            FileStream fs = File.Create(path);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Ordera>));

            xmlSerializer.Serialize(fs, orders);


        }
        //xml转order！！
        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Ordera>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Ordera> temp = (List<Ordera>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!orders.Contains(order))
                    {
                        orders.Add(order);
                    }
                });
            }
        }

    }
    
}