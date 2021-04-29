using System;
namespace shape
{
    public class Square :Rectangle
    {
        private double side;
        public Square() { }
        public Square(double side)
        {
            this.side = side;
        }
        public new  double GetArea()
        {
            return side * side;
        }
        
    }
}
