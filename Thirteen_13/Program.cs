using System;

namespace Thirteen_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string URL = "http://www.cnn.com/video";

            //everything before //
            //between// and first /
            //everything left
            string protocol = URL.Substring(0, URL.IndexOf("//")-1);
            Console.WriteLine(protocol);
            string server = URL.Substring(URL.IndexOf("//") + 2, URL.IndexOf("/", URL.IndexOf("//") + 2) - URL.IndexOf("//") - 2);
            Console.WriteLine(server);
            string resourse = URL.Substring(URL.IndexOf("/", URL.IndexOf("//") + 2));
            Console.WriteLine(resourse);
        }

    }
}
