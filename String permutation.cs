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
            string str2 = Console.ReadLine();
            if (CheckPermutaion(str1,str2)) Console.WriteLine("True");
            else Console.WriteLine("False");
        }

        static Boolean CheckPermutaion(string str1, string str2)
        {   
            string s1 = new string(str1.OrderBy(c=>c).ToArray());
            string s2 = new string(str2.OrderBy(c => c).ToArray());
            if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }
    }
}

