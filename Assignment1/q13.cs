using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q13
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0]=int.Parse(Console.ReadLine());
            arr[1] = int.Parse(Console.ReadLine());
            arr[2] = int.Parse(Console.ReadLine());

            int m=arr.Max();
            Console.WriteLine(m);
        }
    }
}
