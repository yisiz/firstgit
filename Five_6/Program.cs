using System;

namespace Five_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            double temp = b * b - 4 * a * c;
            if (temp > 0)
            {
                double root1 = (b + Math.Pow(temp, 1 / 2)) / (-2 * a);
                double root2 = (b - Math.Pow(temp, 1 / 2)) / (-2 * a);
                Console.WriteLine("There are 2 real distinct roots.");
                Console.WriteLine("They are respectively {0} and {1}", root1, root2);
            }
            else if ((int)temp == 0)
            {
                double root1 = b / (-2 * a);
                Console.WriteLine("There are 1 real distinct roots.");
                Console.WriteLine("It is {0}", root1);
            }
            else
            {
                Console.WriteLine("There is no real roots.");
            }     
        }
    }
}
