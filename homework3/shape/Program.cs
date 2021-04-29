using System;

namespace shape
{
    class Program
    {
   
        

        static void Main(string[] args)
        {

            Random rd = new Random();

           
            Shape shape =Factory.GetShape(rd.Next(1, 3) - 1,2,2,3,3);
            Shape shape2 = Factory.GetShape(rd.Next(1, 3) - 1, 2, 2, 3, 3);
            Shape shape3 = Factory.GetShape(rd.Next(1, 3) - 1, 2, 2, 3, 3);
            Shape shape4 = Factory.GetShape(rd.Next(1, 3) - 1, 2, 2, 3, 3);
            Shape shape5 = Factory.GetShape(rd.Next(1, 3) - 1, 2, 2, 3, 3);
            Shape shape6 = Factory.GetShape(rd.Next(1, 3) - 1, 2, 2, 3, 3);
            Shape shape7 = Factory.GetShape(rd.Next(1, 3) - 1, 3, 3, 3, 3);
            Shape shape8 = Factory.GetShape(rd.Next(1, 3) - 1, 3, 3, 3, 3);
            Shape shape9 = Factory.GetShape(rd.Next(1, 3) - 1, 3, 3, 3, 3);
            Shape shape10 = Factory.GetShape(rd.Next(1, 3) - 1, 3, 3, 3, 3);
            
           
            Console.WriteLine(shape.GetArea() + shape2.GetArea()+ shape3.GetArea()+ shape4.GetArea()+ shape5.GetArea() + shape6.GetArea() + shape7.GetArea() + shape8.GetArea() + shape9.GetArea() + shape10.GetArea());

        }

    }
}
