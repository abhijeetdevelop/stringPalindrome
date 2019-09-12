using System;
using System.Linq;

namespace Practice1309
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "noon";
            char[] ch = new char[str1.Length];
            ch = str1.ToCharArray();
            ch.Reverse();
            string newStr = new string(ch);     
            
            if (newStr == str1)
                Console.WriteLine("Palindrome");
            else Console.WriteLine("Not a Palindrome");

        }
    }
}
