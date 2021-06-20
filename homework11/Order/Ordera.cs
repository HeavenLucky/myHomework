
using System;
using System.Collections.Generic;
using System.Linq;

namespace Order
{
    [Serializable]
    public class Ordera
    {
        public string orderID { get; set; }
        public Customer customer { get; set; }
        public DateTime time { get; set; }
        public List<OrderDetails> orderlist { get; set; } 

     
        public string CusId { get; set; }


        public double TotalAmount
        {
            get => orderlist.Sum(d => d.AmountPrice);
        }

        public void AddDetails(OrderDetails details)
        {
            orderlist.Add(details);
        }

        public Ordera()
        {
            orderlist  = new List<OrderDetails>();
            orderID = Guid.NewGuid().ToString();
            time = DateTime.Now;
        }
        public Ordera(string orderID,
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
