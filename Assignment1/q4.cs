using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1");
            int no1 = int.Parse(Console.ReadLine());
            if (no1 % 2 == 0)
                Console.WriteLine("no1 is even");
            else
                Console.WriteLine("no1 is odd");
        }
    }
}
