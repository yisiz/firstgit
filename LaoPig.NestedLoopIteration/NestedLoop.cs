using System;

namespace LaoPig.NestedLoopIteration
{
    internal class NestedLoop
    {
        private readonly int n;
        private readonly int k;
        private int[] state;

        public NestedLoop(int n, int k)
        {
            this.n = n;
            this.k = k;
            state = new int[n];
            for (int i = 0; i < n; i++)
            {
                state[i] = -1;
            }
        }

        internal void Enumerate()
        {
            int c = n - 1;
            int count = 0;
            while (c < n)
            {
                if (c < 0)
                {
                    Console.WriteLine("{0} [{1}]", ++count, string.Join(',', state));
                    c++;
                }
                else
                {
                    if (state[c] + 1 < k)
                    {
                        state[c--] += 1;
                    }
                    else
                    {
                        state[c++] = -1;
                    }
                }
            }
        }
    }
}