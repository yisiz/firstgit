using System;

namespace Six_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int q = i; q < i+n; q++)
                {
                    Console.Write(q+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
