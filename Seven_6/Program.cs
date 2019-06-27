using System;

namespace Seven_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given array
            int[] arr = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };

            int[] max_arr = new int[arr.Length];
            int max_length = 1;

            for (int k = 0; k < arr.Length-1; k++)
            {
                int end = arr[k];
                int length = 1;
                int[] temp_arr = new int[arr.Length];
                temp_arr[0] = arr[k];
                int index = 0;
                for (int i = k; i < arr.Length; i++)
                { 
                    if ( end < arr[i])
                    {
                        length++;
                        index++;
                        temp_arr[index] = arr[i];
                        end = arr[i];
                    }
                }
                if (length > max_length)
                {
                    for (int i = 0; i <arr.Length;i++)
                    {
                        max_arr[i] = temp_arr[i];
                    }
                }
            }


            printArray(max_arr, max_arr.Length);

            /* Function to print an array */
            void printArray(int[] A, int size)
            {
                int i;
                for (i = 0; i < size; i++)
                    if(A[i] != 0)
                    Console.Write(A[i] + " ");
                Console.Write("\n");
            }
        }




    }
}
