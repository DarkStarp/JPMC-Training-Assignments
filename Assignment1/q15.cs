using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q15
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter "+ i );
                arr[i] = int.Parse(Console.ReadLine());

            }
            int total = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                total=total+arr[i];
            }
            float avg = total / 10;
            int min = arr.Min();
            int max = arr.Max();
            Console.WriteLine("Toatal: "+total);
            Console.WriteLine("Avg: "+avg);
            Console.WriteLine("Min: "+min);
            Console.WriteLine("Max: "+max);
            Array.Sort(arr);
            Console.WriteLine("Ascending: ");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("Descending: ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);

            }
        }
    }
}
