using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    [Serializable]
    public class Customer
    {
        public String name { get; set; }
        public String address { get; set; }



        public Customer(String name, String address)
        {
            this.address = address;
            this.name = name;

        }
        public override string ToString()
        {
            return this.name + " " + address;
        }
    }
}
