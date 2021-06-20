using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
namespace Order
{
    [Serializable]
    public class OrderService
    {
       // public List<Ordera> orders = new List<Ordera>();

        public OrderService()
        {
            using (var orderContext
                = new OrderContext())
            {
                if (orderContext.Goods.Count() == 0)
                {
                    orderContext.Goods.Add(new Goods("apple", 10,"1"));
                    orderContext.Goods.Add(new Goods("pen", 2,"2"));
                    orderContext.SaveChanges();
                }
                if (orderContext.Customers.Count() == 0)
                {
                    orderContext.Customers.Add(new Customer("shl","wuhan"));
                    orderContext.Customers.Add(new Customer("hxy","jiangxi"));
                    orderContext.SaveChanges();
                }
            }

        }
        public List<Ordera> orders
        {
            get
            {
                using (var orderContext = new OrderContext())
                {
                    return orderContext.Orders.Include (o => o.orderlist.Select(d => d.Goods)).Include("customer").
             ToList<Ordera>();
                }
            }
        }
        //避免级联添加或修改Customer和Goods
        private static void FixOrder(Ordera newOrder)
        {
            newOrder.CusId = newOrder.customer.CusId;
            newOrder.customer = null;
            newOrder.orderlist.ForEach(d => {
                d.GoodsId = d.Goods.goodsid;
                d.Goods = null;
            });
        }
        public void AddOrder(Ordera order)
        {
            //  if (orders.Contains(order))
            //      throw new ApplicationException($"添加错误: 订单已经存在了!");
            //  orders.Add(order);
            FixOrder(order);
            using (var orderContext = new OrderContext())
            {
                orderContext.Entry(order).State = EntityState.Added;
                orderContext.SaveChanges();
            }
        }

        public void DeleteOrder(string orderID)
        {
            //  orders.RemoveAll(o => o.orderID == orderID);
            using (var orderContext = new OrderContext())
            {
                var order = orderContext.Orders.Include("orderlist").SingleOrDefault(o => o.orderID == orderID);
                if (order == null) return;
                orderContext.OrderDetails.RemoveRange(order.orderlist);
                orderContext.Orders.Remove(order);
                orderContext.SaveChanges();
            }
        }

        public Ordera QueryOrderById(string orderId)
        {
            //????
            //  return orders.Where(o => o.orderID == orderId).FirstOrDefault();
           
                using (var orderContext = new OrderContext())
                {
                    return orderContext.Orders.Include(o => o.orderlist.Select(d => d.Goods)).Include("customer")
                      .SingleOrDefault(o => o.orderID == orderId);
                }
            

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
            //foreach(Ordera order in temp){
            //if(!orders.contains(order){
          //  orders.Add(order); }
        }

    }
    
}