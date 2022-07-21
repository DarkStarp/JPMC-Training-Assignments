using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q11
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int i = 1;
            while(i<=20)
            {
                Console.WriteLine(a+" * "+i+" = "+ a*i);
                i++;
            }
        }
    }
}
