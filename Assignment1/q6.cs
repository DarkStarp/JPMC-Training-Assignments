using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert temp");
            double f=double.Parse(Console.ReadLine());
            double c = (f - 32) / 1.8;
            Console.WriteLine(c);

        }
    }
}
