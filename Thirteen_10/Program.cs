using System;

namespace Thirteen_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string paragraph = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string keyword = "in";
            string[] paraArray = paragraph.Split('.');
            foreach (string sentence in paraArray)
            {
                string[] wordArray = sentence.Split(' ');
                foreach (string word in wordArray)
                {
                    if(word == keyword)
                    {
                      
                        Console.WriteLine(sentence.Trim()+ '.');
                        break;
                    }
                }
            }
                /* count = 0
                 * f = open('pig.txt')
                   f.close()          
                 * for line in f:
                    q = 0
                    a = True
                    w = line[q:]
                    while a == True:
                        w = w[q:]
                        if w.find('life') != -1:
                            a = True
                            print(w)
                            count += 1
                            q = w.find('life') + 4
                        else: a = False


                print(count)*/
        }
    }
}
