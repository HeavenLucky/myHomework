using System;
//编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。

namespace pro2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 2, 3, 77, 4, 5, 6, 2 };

            Program pro = new Program();
            pro.Count(a);

        }
        public void Count(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            double ave = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];

                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                sum = sum + arr[i];

            }
            ave = (double)sum / arr.Length;
            Console.WriteLine($"最小值为{min}");
            Console.WriteLine("最大值为" + max);
            Console.WriteLine("和为" + sum);
            Console.WriteLine("平均值" + ave);


        }
    }

}