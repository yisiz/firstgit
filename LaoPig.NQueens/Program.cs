using System;

namespace LaoPig.NQueens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            var nQueens = new NQueensRecursion(n);
            nQueens.Solve();
        }
    }
}
