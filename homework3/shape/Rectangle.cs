using System;
namespace shape
{
    public class Rectangle : Shape
    {
        private double edgea;
        private double edgeb;
        private double edgec;
        private double edged;
        public Rectangle() { }
        public Rectangle(double a, double b, double c, double d)
        {
            this.edgea = a;
            this.edgeb = b;
            this.edgec = c;
            this.edged = d;

        }
        public bool IsRectangle()
        {
            if ((edgea == edgeb && edgec == edged) || (edgea == edgec && edgeb == edgec)) { return true; }
            return false;

        }

        public override double GetArea()
        {
            if (IsRectangle())
            {
                return (edgea == edgeb) && (edgec == edged) ? edgea * edgec : edgea * edgeb;
            }
            return 0;

        }


    }
}