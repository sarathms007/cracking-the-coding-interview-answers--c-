using System;
using System.Linq;

namespace Programing_Qestions
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str1=Console.ReadLine();
             Console.WriteLine("String:"+ URLify(str1));
        }

       static string  URLify(string str1)
        {
           string s1= str1.Trim();
            s1=s1.Replace(" ", "20%");
            return s1;
        }
    }
}

