using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HelloApp
{
   
    class Program
    {
        static List<string> list = new List<string>();
       
        static void Main(string[] args)
        {
            string str = "aabb";
            int n = str.Length;
            permute(str, 0, n - 1);
            list.GroupBy(x => x).Select(x => x.First()).ToList();
            foreach (var el in list)
            {
                Console.Writeline(el);
            }
        }


        static void permute(String str, int l, int r)
        {
            
            if (l == r)
                list.Add(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
            
        }


       
        static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }

}
        
    
    




