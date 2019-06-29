using System;

namespace Thirteen_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //input string
            string quote = "The main <upcase>intent of</upcase> the \"Intro C#\"" +
            " book is to <upcase>2intent of</upcase> introduce the C# programming to newbies.";
            //string fixedquote=string.Empty;

            //double index
            int index1 = quote.IndexOf("<upcase>");
            int index2 = -1;
            if (index1 > -1)
                index2 = quote.IndexOf("</upcase>", index1);
            while (index1 != -1 && index2 != -1)
            {
                //stringbuider. cut out. uppercase. insert
                string change = quote.Substring(index1, index2 + 9 - index1);
                string change2 = change.Substring(8, index2 - index1 - 8);
                string change3 = change2.ToUpper();
                quote = quote.Replace(change, change3);

                index1 = quote.IndexOf("<upcase>");
                if (index1 > -1)
                    index2 = quote.IndexOf("</upcase>", index1);
            }

            //output
            Console.WriteLine(quote); 
            //how to swith to string builder
        }
    }
}
