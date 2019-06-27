using System;

namespace Seven_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Length:");
            int n = int.Parse(Console.ReadLine()); 
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }*/

            int[] array = { 3, 4, 2, 3, 4, 5, 2, 2, 4 };


            int maxLength =  1;
            int start = 0;
            int tempstart = 0;
            int tempLength = 1;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] + 1 == array[i + 1])
                {
                    if (tempstart == 0) {
                        tempstart = i;
          
                    }

                    tempLength++;

                    if (tempLength > maxLength)
                    {
                        maxLength = tempLength;
                        start = tempstart;

                    }
                }
                else
                {
                    tempstart = 0;
                    tempLength = 1;
                }


            }


            for (int index = start; index < start + maxLength; index++)
            {
                // Print each element on a separate line
                Console.WriteLine("Element[{0}] = {1}", index, array[index]);
            }

        }
    }
}
