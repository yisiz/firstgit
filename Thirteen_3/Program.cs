using System;

namespace Thirteen_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //input string
            string name = Console.ReadLine();
            int counter1 = 0;
           

            //loop through with two counter
            for(int i = 0; i < name.Length; i++)
            {
                if (name[i] == '(')
                {
                    counter1++;
                } else if (name[i] == ')')
                {
                    counter1--;
                }

                if (counter1 < 0)
                {
                    break;
                }
            }

            //if - true or false
            if (counter1 == 0)
            {
                Console.WriteLine("correct");

            } else
            {
                Console.WriteLine("incorrect");
            }
        } 
    }
}
