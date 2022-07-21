using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q5
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            while(1>0)
            {
                Console.WriteLine("Enter number1");
                int no1 = int.Parse(Console.ReadLine());
                if (no1 == -1)
                    break;
                if (no1 % 2 == 0)
                    a++;
                else
                    b++;
            }
            Console.WriteLine("Odd = "+b+" Even = "+a);

        }
    }
}
