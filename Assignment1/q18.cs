using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word1");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter word2");
            string str2 = Console.ReadLine();
            if (str1 != str2)
            {
                Console.WriteLine("Word are not equal");
            }
            else
                Console.WriteLine("Words are equal");
        }
    }
}
