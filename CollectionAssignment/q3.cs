using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionAssignment
{
    internal class q3
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Write Code, name in the same format for {i}");
                int code = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                sl.Add(code, name);
            }
            foreach (int i in sl.Keys)
            {
                Console.WriteLine($"{i}: {sl[i]}");
            }
        }
    }
}
