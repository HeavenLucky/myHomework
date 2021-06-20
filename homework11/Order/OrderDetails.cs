using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Order
{
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public int Number { get; set; } //序号

        public string GoodsId { get; set; }

        public String GoodsName { get => Goods != null ? this.Goods.goodsname : ""; }
        public double Price
        {
            get => Goods != null ?  this.Goods.price:0;
        }

        public string OrderId { get; set; }
        public int GoodsAmount { get; set; }
        public Goods Goods { get; set; }
        public double AmountPrice { get => Goods != null ? Goods.price * GoodsAmount : 0; }

        public OrderDetails(int number,int goodsamount, Goods goods)
        {
            this.GoodsAmount = goodsamount;
            this.Goods = goods;
            this.Number = number;

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
