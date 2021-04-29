using System;
//输出给定数据的所有素数（质数）因子
namespace pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个数");
            Program pro = new Program();
            int num = int.Parse(Console.ReadLine());
            pro.GetPrimeFactor(num);

        }
        public bool IsPrime(int num)
        {
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }

            }
            return true;

        }
        public void GetPrimeFactor(int num)
        {
            for (int n = 2; n <= num; n++)
            {
                bool b = IsPrime(n);

                if ((num % n == 0) && (b == true))
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
