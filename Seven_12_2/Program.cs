using System;

namespace Seven_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of the matrices:");
            int n = int.Parse(Console.ReadLine());
            int[,] matrices = new int[n, n];

            int num = 1;
            for(int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrices[j, i] = num;
                        num++;
                    }
                }
                else
                {
                    for (int j = 3; j >= 0; j--)
                    {
                        matrices[j, i] = num;
                        num++;
                    }
                }

            }

            for (int row = 0; row < matrices.GetLength(0); row++)
            {
                for (int col = 0; col < matrices.GetLength(1); col++)
                {
                    Console.Write(matrices[row, col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
