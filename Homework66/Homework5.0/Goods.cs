using System;
using System.Collections.Generic;

namespace homework5
{
    [Serializable]
    public class Goods
    {
        public int goodsid;
        public String goodsname;
        public double price;
     
       

            
        public Goods(String goodsname, double price,int goodsid)
        {
            this.goodsid = goodsid;
          
            this.goodsname = goodsname;
            this.price = price;

        }
        public override string ToString()
        {
            return  " " + goodsname + "单价： " + price;

        }
        public  bool Equals(Goods go)
        {
            return this.goodsid == go.goodsid;
        }
    }
}
