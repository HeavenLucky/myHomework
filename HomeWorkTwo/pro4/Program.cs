using System;
//如果矩阵上每一条由左上到右下的对角线上的元素都相同，那么这个矩阵是托普利茨矩阵
//。给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True。

namespace pro4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            Program pro = new Program();
            bool b = pro.IsMatrix(arr);
            Console.WriteLine(b);
        }
        public bool IsMatrix(int[,] arr)
        {
            int M = arr.GetLength(0);//3
            int N = arr.GetLength(1);//4

            int i = 0;
            int j = 0;
            for (i = 1; i < M; i++)
            {

                for (j = 1; j < N; j++)
                {
                    if (arr[i, j] != arr[i - 1, j - 1])
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
