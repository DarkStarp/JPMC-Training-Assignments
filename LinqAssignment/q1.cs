using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    internal class q1
    {
        static void Main(string[]args)
        {
            int[] arr = { 1,2,3,4,5,6,7,8,9,10 };
            var q = from a in arr
                    let k=a*a*a
                    where k>100 &&k<1000
                    select k;
            foreach(var i in q)
                Console.WriteLine(i);

        }
    }
}
