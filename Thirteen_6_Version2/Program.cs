using System;

namespace Thirteen_6
{
    class Program
    {
        //revursive OR string builder
        static void ToUpperCase(string quote)
        {


            //double index

            int index1 = quote.IndexOf("<upcase>");
            int index2 = quote.IndexOf("</upcase>");
            //while (index1 != -1 && index2 != -1)
            //{
            //stringbuider. cut out. uppercase. insert
            string change = quote.Substring(index1, index2 + 9 - index1);
            string change2 = change.Substring(8, index2 - index1 - 8);
            string change3 = change2.ToUpper();
            string fixedquote = quote.Replace(change, change3);

            index1 = quote.IndexOf("<upcase>", index1 + 1);
            index2 = quote.IndexOf("</upcase>", index2 + 1);
            //}

            //output
            return " ";
        }

        static void Main(string[] args)
        {
            //input string
            string quote = "The main <upcase>intent of</upcase> the \"Intro C#\"" +
            " book is to introduce the C# programming to newbies.";
            ToUpperCase(quote);
            string fixedquote;
            Console.WriteLine(fixedquote);
        }
    }
}
