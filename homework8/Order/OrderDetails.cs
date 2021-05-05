using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Order
{
    [Serializable]
    public class OrderDetails
    {public OrderDetails() { }


        public int GoodsAmount { get; set; }
        public Goods Goods { get; set; }
        public double AmountPrice { get => Goods.price * GoodsAmount; }

        public OrderDetails(int goodsamount, Goods goods)
        {
            this.GoodsAmount = goodsamount;
            this.Goods = goods;

        }

        public override string ToString()
        {
            return Goods + "" + "数量：" + GoodsAmount + "总价：" + AmountPrice;
        }


        public bool Equals(OrderDetails odetails)
        {
            return (this.GoodsAmount == odetails.GoodsAmount) && (Goods == odetails.Goods);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
