using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    interface Ipayable
    {
        public double Ramtdue();
        public double Aamtdue(double d);
        public string payadd();
    }
    class account: Ipayable
    {
        public double amt;
        public string add;
        public double duet=0;
        public account(double amt, string add)
        {
            this.amt = amt;
            this.add = add;
        }
        public double Ramtdue()
        {
            return duet;
        }
        public double Aamtdue(double amt)
        {
            duet += amt;
            
            return duet;
        }
        public string payadd()
        {
            return add;
        }
    }
    internal class q2
    {
        static void Main(string[] args)
        {
            account a = new account(7890, "H-1001");
            Console.WriteLine(a.Aamtdue(1234));
            Console.WriteLine(a.Ramtdue());
            Console.WriteLine(a.payadd());
        }
    }
}
