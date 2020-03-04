using System;

namespace Programing_Qestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str=Console.ReadLine();
            if (CheckPermutaion(str)) Console.WriteLine("True");
            else Console.WriteLine("False");
        }

        static Boolean CheckPermutaion(string str)
        {

            Boolean[] flag = new Boolean[128];


            if (str.Length > 128) return false;
            else
            {
                for (int i = 0; i < str.Length; ++i)
                {
                    //int val = str[i];
                    if (flag[str[i]]) return false;
                    else flag[str[i]] = true;

                }
            }

            return true;
        }
    }
}

