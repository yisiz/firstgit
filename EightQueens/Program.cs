// Problem: i3 doesn't run -- for can not be inside if?
// i3 still never change

using System;

namespace EightQueens
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =0; i <64; i++)
            {

                int[] arr = new int[8];
                arr[0] = -1;
                arr[1] = -1;
                arr[2] = -1;

                // Determine Queen Num 1
                arr[0] = i;

                // Determine Queen Num 2
                for (int i2 = 0; i2 < 64; i2++)
                {
                    int x = i2 % 8;
                    int y = i2 / 8;
                    if (x != arr[0] % 8 && y != arr[0] / 8 && x - (arr[0] % 8) != y - (arr[0] / 8) && y - (arr[0] / 8) != x - arr[0] % 8)
                    {
                        arr[1] = i2;
                    }

                    // Determine Queen Num 3
                    int i3 = 0;
                    while (i3 < 64) 
                    //for (int i3 = 0; i3 < 64; i3++)
                    {

                        //Avoid running without new i2
                        if (arr[1] == -1)
                        {

                            break;
                        }
                        //Loop for relation b/t Q1/Q3 + Q2/Q3
                        for (int u = 0; u < 2; u++)
                        {

                            int x3 = i3 % 8;
                            int y3 = i3 / 8;
                            if (x3 != arr[u] % 8 && y3 != arr[u] / 8 && x3 - (arr[u] % 8) != y3 - (arr[u] / 8) && y3 - (arr[u] / 8) != x3 - arr[u] % 8)
                            {

                                if (u == 1)
                                {

                                    arr[u + 1] = i3;

                                }
                            } 
                            else //Change to a new i3 if the fisrt arr[u=0] is not qualified
                            { //If that is qualified, the second would run
                                break;
                            }
                        }
                        // Avoid running without new i2
                        arr[1] = -1;
                        i3 = i3 + 1;
                        Console.Write(i3);
                    } 
                }

                /* if (Q1 == -1)
                {
                    Q1 = i;
                }

                if (Q1 != -1 && Q2 == -1)
                {

                    if (x != Q1 % 8 && y != Q1 / 8 && x - (Q1 % 8) != y - (Q1 / 8) && y - (Q1 / 8) != x - Q1 % 8)
                    {
                        Q2 = i;
                    }

                }

                if (Q1 != -1 && Q2 != -1 && Q3 == -1)
                {
                    if (x != Q1 % 8 && y != Q1 / 8 && x - (Q1 % 8) != y - (Q1 / 8) && y - Q1 / 8 !=  Q1 % 8 - x)
                    {
                        if (x != Q2 % 8 && y != Q2 / 8 && x - (Q2 % 8) != y - (Q2 / 8) && y - Q2 / 8 != Q2 % 8 - x)
                        {
                            Q3 = i;
                        }

                    }

                } */
                int som = 0;
            }
        }
    }
}
