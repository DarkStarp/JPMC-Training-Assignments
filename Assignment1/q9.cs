using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q9
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            int c=a+b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            while(c<40)
            {
                Console.WriteLine(c);
                a = b;
                b = c;
                c = a + b;
            }
        }
    }
}
