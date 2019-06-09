using System;

namespace Six_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int common_divisor = 1;
            int i = 1;
            while (i <= a )
            {
                if (a % i == 0 && b % i == 0)
                {
                    common_divisor = i;
                }
                i++;
            }
            Console.WriteLine(common_divisor);
            Console.WriteLine(a * b / common_divisor);
        }
    }
}
