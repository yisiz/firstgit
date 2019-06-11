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
            int commonDivisor = Math.Min(a, b);
            while (!(a % commonDivisor == 0 && b % commonDivisor == 0))
                commonDivisor--;
            Console.WriteLine(commonDivisor);
            Console.WriteLine(a * b / commonDivisor);
        }
    }
}
