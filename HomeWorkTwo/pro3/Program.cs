using System;

//用“埃氏筛法”求2~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，再去掉4的倍数，以此类推...最后剩下的就是素数
//设置一个针对2～100的数组，每次筛选过后不合格的数字都被赋值为0；最后得到的数组输出时只要排除0即可
namespace pro3
{
    class Program
    {


        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.GetNum();

        }
        public void GetNum()
        {
            int[] arr = new int[99];
            for (int i = 0; i < 99; i++)
            {
                arr[i] = i + 2;

            }
            for (int n = 2; n < 101; n++)
            {
                for (int j = 0; j < 99; j++)
                {
                    if ((arr[j] % n == 0) && (arr[j] != n)) { arr[j] = 0; }
                }
            }

            for (int m = 0; m < 99; m++)
            {
                if (arr[m] != 0)
                    Console.WriteLine(arr[m]);

            }


        }
    }
}

