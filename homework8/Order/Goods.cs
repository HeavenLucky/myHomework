using System;
using System.Collections.Generic;

namespace Order
{
    [Serializable]
    public class Goods
    {
        public int goodsid { get; set; }
        public String goodsname { get; set; }
        public double price { get; set; }




        public Goods(String goodsname, double price, int goodsid)
        {
            this.goodsid = goodsid;

            this.goodsname = goodsname;
            this.price = price;

        }
        public override string ToString()
        {
            return " " + goodsname + "单价： " + price;

        }

       

        public bool Equals(Goods go)
        {
            return this.goodsid == go.goodsid;
        }
    }
}