using System;
using System.Collections.Generic;

namespace homework5
{
    [Serializable]
    public class OrderDetails
    {
      

        public int goodsamount;
        public Goods goods;
        public double AmountPrice { get => goods.price * goodsamount; }

        public OrderDetails( int  goodsamount, Goods goods)
        {
            this.goodsamount = goodsamount;
            this.goods = goods;

        }

        public override string ToString()
        {
            return goods+""+"数量："+goodsamount+"总价："+AmountPrice;
        }


        public  bool Equals(OrderDetails odetails)
        {
            return (this.goodsamount==odetails.goodsamount)&&(goods==odetails.goods);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
