
using System;
using System.Collections.Generic;
using System.Linq;

namespace Order
{
    [Serializable]
    public class Ordera
    {
        public int orderID { get; set; }
        public Customer customer { get; set; }
        public DateTime time { get; set; }
        public List<OrderDetails> orderlist { get; set; } = new List<OrderDetails>();

        public double TotalAmount
        {
            get => orderlist.Sum(d => d.AmountPrice);
        }

        public void AddDetails(OrderDetails details)
        {
            orderlist.Add(details);
        }

        public Ordera() { }
        public Ordera(int orderID,
        Customer customer)

        {



            this.orderID = orderID;

            this.customer = customer;

        }

        public override string ToString()
        {
            String result = $"订单{orderID}, customer:{customer}";
            orderlist.ForEach(detail => result += "\n\t" + detail);
            return result;
        }
        public bool Equals(Ordera order)
        {
            return orderID == order.orderID;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
