using System;

namespace LaoPig.NestedLoopIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int k = 2;
            var nestedLoop = new NestedLoop(n, k);
            nestedLoop.Enumerate();
        }
    }
}
