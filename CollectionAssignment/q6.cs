using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionAssignment
{
    internal class q6
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Write designation and then name for {i} employee");
                string code = Console.ReadLine();
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
