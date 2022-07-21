using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class q2
    {
    }
    class bilding
    {
        public string type;
        public string capa;
        public string dimension;
        public int flat;
        public string villa;
        public DateTime doc;
        public bilding(string a, string b, string c, int d, string e, DateTime f)
        {
            type = a;
            capa = b;
            dimension = c;
            flat = d;
            villa = e;
            doc = f;
        }
        public static bilding create()
        {
            Console.WriteLine("Enter type of building");
            string a = Console.ReadLine();
            Console.WriteLine("Enter capacity");
            string b = Console.ReadLine();
            Console.WriteLine("Enter Dimension");
            string c = Console.ReadLine();
            int d = 0;
            string e = "";

            if (a.Equals("flat",StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Falt floor number");
                d = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter vila dimension");
                e = Console.ReadLine();
            }
            Console.WriteLine("Enter Date of Completion");
            DateTime f = DateTime.Parse(Console.ReadLine());
            return new bilding(a, b, c, d, e, f);
        }
        public void display()
        {
            Console.WriteLine($"Type of property:{type} \n Capacity: {capa} \n Dimension: {dimension} \n Date of Completion: {doc}");
        }
    }
    
}
