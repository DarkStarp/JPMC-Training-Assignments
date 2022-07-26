using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    interface f
    {
        public double yearlysales();
    }
    abstract class a
    {
        public double d;
        public abstract double monthlySales();
        public double dailySales()
        {
            return d;
        }
    }
    class asd : a, f
    {
        public override double monthlySales()
        {
            return dailySales()*30;
        }
        public double yearlysales()
        {
            return 365 * dailySales(); 
        }
    }
     
    internal class q4
    {
        static void Main(string[] args)
        {
            asd l = new asd();
            l.d = 400;
            Console.WriteLine(l.dailySales());
            Console.WriteLine(l.yearlysales());
            Console.WriteLine(l.monthlySales());
        }
    }
}
