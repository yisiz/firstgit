using System;
using System.Collections.Generic;

namespace LaoPig.NQueens
{
    internal class NQueensRecursion
    {
        private readonly int n;
        private int[] state;
        private int count;

        public NQueensRecursion(int n)
        {
            this.n = n;
            this.state = new int[n];
            this.count = 0;
        }

        public void Solve()
        {
            SolveRecursion(n - 1);
        }

        private void SolveRecursion(int c)
        {
            if (c < 0)
            {
                PrintASolution();
            }
            else
            {
                for (int i = n * c; i < n * c + n; i++)
                {
                    state[c] = i;
                    if (test(c))
                    {
                        SolveRecursion(c - 1);
                    }
                }
            }
        }

        // check if the queen at position pos fits all the others state[pos] vs state[pos + 1:]
        private bool test(int pos)
        {
            int x1 = state[pos] % n;
            int y1 = state[pos] / n;
            for (int pos2 = pos + 1; pos2 < n; pos2++)
            {
                int x2 = state[pos2] % n;
                int y2 = state[pos2] / n;
                if (x1 == x2 || y1 == y2 || x1 - y1 == x2 - y2 || x1 + y1 == x2 + y2)
                    return false;
            }
            return true;
        }

        public void PrintASolution()
        {
            Console.WriteLine("{0}: [{1}]", ++count, String.Join(',', state));
        }

    }
}