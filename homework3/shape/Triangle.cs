using System;
namespace shape
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;
       public Triangle() { }
        public Triangle(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
           
        }
        public bool IsTriange()
        {

            if ((a + b > c) && (a + c > b) && (b + c > a)) { return true; }
            return false;

        }
        public  override double GetArea()
        {
            double p = (a + b + c) / 2;
            double area= Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return area;
        }

        
    }
}
