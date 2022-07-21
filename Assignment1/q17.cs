using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Word");
            string word= Console.ReadLine();
            word = word.ToLower();
            int a = word.Length;
            string rev = "";
            for(int i = (a-1); i >=0; i--)
            {
                rev = rev+word[i];
            }
            Console.WriteLine(rev);
        }
    }
}
