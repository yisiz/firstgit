using System;

namespace Five_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your Number = ");
            int num = int.Parse(Console.ReadLine());
            string[] zeroToNine =  { "zero","one", "two","three","four","five","six","seven","eight","nine" };
            string[] twentyToNinety = { "twenty", "thirty","forty","fifty","sixty","seventy","eighty","ninty" };
            string[] elevenToNineteen = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            if (num/100 != 0)
            {
                Console.Write(zeroToNine[num / 100] + " hundred ");
                if (num/10 % 10 <2)
                {
                    Console.Write("and ");
                }
            }
            if(num/10 % 10 > 1)
            {
                Console.Write(twentyToNinety[num / 10 % 10 - 2] + " ");
            }
            if(num/10 % 10== 1)
            {
                Console.Write(elevenToNineteen[num % 10 - 1]);
            }
            if(num/10 % 10 != 1 && num %10 != 0)
            {
                Console.Write(zeroToNine[num % 10]);
            }

            if(num == 0)
            {
                Console.Write("zero");
            }

        }
    }
}
