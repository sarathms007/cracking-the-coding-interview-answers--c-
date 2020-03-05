using System;
using System.Linq;

namespace Programing_Qestions
{
    class Program1
    {
        static void Main(string[] args)
        { Boolean flag = false;
            Console.WriteLine("Enter the string");
            string str1=Console.ReadLine();
            string str2= Console.ReadLine();

            if (str1.Length == str2.Length)
                flag = onewaySub(str1, str2);
            else if(str1.Length>str2.Length)
                flag=onewaySub(str2, str1);
            else
                flag = onewaySub(str1, str2);
           
            if (flag) 
            Console.WriteLine("String is One way");
            else
                Console.WriteLine("String is Not One way");
        }

       static Boolean onewaySub(string str1,string str2)
        { Boolean diff = false;
            for(int i = 0; i < str1.Length; ++i)
            {
                if (str1[i] != str2[i])
                {   if (diff)
                        return false;
                    else
                        diff = true;
                }
            }
            return true;  
        }

        static Boolean onewayInsert(string str1, string str2)
        {
            int index1 = 0;
            int index2 = 0;

            while(index1<str1.Length && index2 < str2.Length)
            {
                if (str1[index1] != str2[index2])
                {
                    if (index1 != index2)
                        return false;
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;

                }
            }
            return true;
        }
    }
}

