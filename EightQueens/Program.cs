// Problem: i3 doesn't run -- for can not be inside if?
// i3 still never change
// make a function of verify if 2 is for 3 ... 

using System;

namespace EightQueens
{
    class Program
    {
        static int n = 9;
        static int N;
        static int K;
        static int[] loops;
        static int numOfCombination = 0;

        /* Function to print an array */
        static void printArray(int[] A, int size)
        {
            int i;
            for (i = 0; i < size; i++)
               Console.Write(A[i] + " ");
            Console.Write("\n");
        }

        static void NestedLoops (int currentLoop)
        {
            if(currentLoop == N)
            {
                printArray(loops,loops.Length);
                numOfCombination++;
                return;
            }
            for(int counter=0; counter<=K-1; counter++)
            {
                loops[currentLoop] = counter;
                int x = counter % n;
                int y = counter / n;
                bool goodOrBad = true;

                if(y != currentLoop)
                {
                    goodOrBad = false;
                } else { 
                    for(int q = 0; q<currentLoop; q++ )
                    {
                        if (!(  x != loops[q] % n && y != loops[q] / n && x - (loops[q] % n) != y - (loops[q] / n) && -1*(x - (loops[q] % n)) != y - (loops[q] / n))  )
                        {
                            goodOrBad = false;
                        } 
                    }
                }

                if (goodOrBad == true)
                {
                    NestedLoops(currentLoop + 1);
                }
            }
        }

        static void Main(string[] args)
        {
        
            N = n;
            K = n * n;
            loops = new int[N];
            NestedLoops(0);
            Console.Write(numOfCombination);
        }
    }
}
