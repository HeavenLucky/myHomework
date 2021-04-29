using System;
namespace shape
{
    public class Factory
    {

        public Factory()
        {
        }
        
        public static Shape GetShape(int  rand,double a, double b,double c,double d)
        {
          

            switch(rand)
            {
                case 0:
                    return new Rectangle(a, b, c, d);
                case 1:
                    return new Triangle(a,b,c);
                   
                case 2:
                    return new Square(a);
                   
                default:
                    return null;
            }
        }
        
    }
}