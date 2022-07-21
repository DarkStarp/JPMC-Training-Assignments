using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2");
            int no2 = int.Parse(Console.ReadLine());
            if(no1>no2)
            {
                while(no2 != no1)
                    Console.WriteLine(no2++);
            }
            else
            {
                while(no2!=no1)
                    Console.WriteLine(no1++);
            }
            Console.ReadKey();

        }
    }
}
