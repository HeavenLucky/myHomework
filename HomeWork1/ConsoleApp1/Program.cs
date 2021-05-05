using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = '0';
            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("输入第一个数!");

            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("输入第二个数");

            num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("输入运算符!");
            char1 = Char.Parse(Console.ReadLine());

            if (char1 == '+')
                Console.WriteLine($"num1+num2的结果是:{num1 + num2}");
            if (char1 == '-')
                Console.WriteLine($"num1-num2的结果是:{num1 - num2}");
            if (char1 == '/')
                if (num2 == 0) Console.WriteLine("除数不能为零");
                else
                    Console.WriteLine($"num1/num2的结果是:{num1 / num2}");
            if (char1 == '*')
                Console.WriteLine($"num1*num2的结果是:{num1 * num2}");





        }
    }
}
