using System;
namespace shape
{
    public abstract class Shape
    {
        public Shape()
        {
        }
        private double width;
        private double height;
        public void SetWidth(double w) {width = w; }
        public void SetHeight(double h) { height = h; }

        public abstract double GetArea();
    }
}
