using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q10
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            for(int i=5; i<=a; i++)
            {
                Console.WriteLine(Math.Pow(i,3));
            }
        }
    }
}
