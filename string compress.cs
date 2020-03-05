using System;
using System.Linq;

namespace Programing_Qestions
{
    class Program1
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the string");
            string str=Console.ReadLine();
          //  string str2= Console.ReadLine();

         
                Console.WriteLine("String: "+compressString(str));
        }

       static string compressString(string str)
        {
            string res = "";
            int count = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                count++;

                if( (i+1)>= str.Length || str[i] != str[i + 1])
                {
                    res += str[i];
                    res += count;
                    count = 0;
                }

            }

            return str.Length < res.Length? str:res;  
        }

    }
}

