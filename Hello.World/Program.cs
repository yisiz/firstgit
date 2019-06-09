using System;

namespace Hello.World
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1, a = 0, b = 1; i <= n; i++  )
            { 
                if (i % 2 != 0)
                {
                    sum += a;
                    Console.WriteLine(a);
                    a = a + b;
                }
                else
                {
                    sum += b;
                    Console.WriteLine(b);
                    b = b + a;
                }
            }
            Console.WriteLine("sum: {0}", sum);
        }
    }
}
