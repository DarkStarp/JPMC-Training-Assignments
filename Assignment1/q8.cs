using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no.");
            int a = int.Parse(Console.ReadLine());
            int b=1;
            for(int i = 1; i <= a; i++)
            {
                b = i * b;
            }
            Console.WriteLine(b);
        }
    }
}
