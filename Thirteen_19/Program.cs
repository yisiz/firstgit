using System;

namespace Thirteen_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string paragraph = "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b."+' ';

            //

            string[] paraArray = paragraph.Split(". ");
            foreach (string sentence in paraArray)
            {
                string[] wordArray = sentence.Split(' ');
                foreach (string word in wordArray)
                {
                    if (word.IndexOf("@")!=-1)
                    {
                        if (word[0] != '@')
                        {
                            Console.WriteLine(word);
                        }
                        // how to filter out a@a.b?? 

                    }
                }
            }
        }
    }
}
