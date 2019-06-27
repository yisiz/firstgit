using System;

namespace Nine_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array
            Console.Write("Length:");
            int n = int.Parse(Console.ReadLine()); 
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Index:");
            int index = int.Parse(Console.ReadLine());
            Console.Write(CheckNeighbor(index, array));
        }

        static bool CheckNeighbor (int index_given, int[] array)
        {
            if(array[index_given] > array[index_given-1] && array[index_given] > array[index_given+1])
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
