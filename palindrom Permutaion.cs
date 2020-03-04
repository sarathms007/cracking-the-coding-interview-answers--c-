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
            if (CheckpalindromPer(str1)) 
            Console.WriteLine("String is a palindrom");
            else
                Console.WriteLine("String is not a palindrom");
        }

       static Boolean CheckpalindromPer(string str1)
        {
            //string s1= str1.Trim();
            int[] count = new int[260];
            int odd;
            odd = str1.Length % 2;
            for(int i = 0; i < str1.Length; ++i)
            {
                int val = str1[i];
                count[val]++;
            }

            for(int i = 0; i < count.Length; ++i)
            {
                if (count[i] % 2 != 0) { 
                    if(odd % 2 == 0)
                      return false;
                    else
                        odd++;
                    }
            }   
            return true;
        }
    }
}

