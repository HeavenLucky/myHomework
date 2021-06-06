using System;
using System.Collections.Generic;
using System.Linq;

namespace homework5
{
    [Serializable]
    public class Order
    {
        public int orderID;
        public Customer customer;
        public DateTime time;
        public List<OrderDetails> orderlist = new List<OrderDetails>();

        public double TotalAmount
        {
            get => orderlist.Sum(d => d.AmountPrice);
        }

     public void AddDetails(OrderDetails details)
        {
            orderlist.Add(details);
        }

        public Order(int orderID,
        Customer customer)

        {



            this.orderID = orderID;
          
           this. customer = customer;

        }

        public override string ToString()
        {
            String result = $"订单{orderID}, customer:{customer}";
            orderlist.ForEach(detail => result += "\n\t" + detail);
            return result;
        }
        public  bool Equals(Order order)
        {
            return orderID==order.orderID;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
