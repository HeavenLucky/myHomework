using System;
namespace homework5
{
    [Serializable]
    public class   Customer
    {
        public String name;
        public String address;
        


        public Customer(String name,String address)
        {
            this.address = address;
            this.name = name;

        }
        public override string ToString()
        {
            return this.name+" "+address ;
        }
    }
}
