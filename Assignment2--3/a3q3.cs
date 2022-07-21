using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2__3
{
    internal class a3q3
    {
        public static int s(int[]arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("size");
            int n = int.Parse(Console.ReadLine()); 
            int[] arr = new int[n];
            Console.WriteLine("array elemts");
            for(int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is {0}",a3q3.s(arr));
        }

    }
}
