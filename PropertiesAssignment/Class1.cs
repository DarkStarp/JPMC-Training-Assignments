using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAssignment
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of books");
            int n = int.Parse(Console.ReadLine());
            book[] bt = new book[n];
            for (int i = 0; i < n; i++)
            {
                bt[i] = new book();
                Console.WriteLine("Enter ISBn");
                bt[i].ISBN = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter quantity");
                bt[i].Quant = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Book name");
                bt[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Book title");
                bt[i].title = Console.ReadLine();
                Console.WriteLine("Enter Book author");
                bt[i].Author = Console.ReadLine();
                Console.WriteLine("Enter Book price");
                bt[i].Price = double.Parse(Console.ReadLine());
            }
            for(int i = 0; i < bt.Length; i++)
            {
                bt[i].display();
            }

        }
    }
}
