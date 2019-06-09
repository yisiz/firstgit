using System;

namespace Six_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A decimal number = ");
            int n = int.Parse(Console.ReadLine());

            int maxDegree = 0;
            while ( Math.Pow(16, maxDegree+1) <= n ) 
            {
                maxDegree++;
            }
            //Console.WriteLine(maxDegree);

            for ( int i = maxDegree; i > -1; i--)
            {
                int temp =  n / (int) Math.Pow(16, i) ;
                if(temp < 10)
                {
                    Console.Write(temp);
                } else
                {
                    switch (temp)
                    {
                        case 10:
                            Console.Write("A");
                            break;
                        case 11:
                            Console.Write("B");
                            break;
                        case 12:
                            Console.Write("C");
                            break;
                        case 13:
                            Console.Write("D");
                            break;
                        case 14:
                            Console.Write("E");
                            break;
                        case 15:
                            Console.Write("F");
                            break;
                    }
                }

                n -= temp * (int)Math.Pow(16, i);
            }

            
        }
    }
}
