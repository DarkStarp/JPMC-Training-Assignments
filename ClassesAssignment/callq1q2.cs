using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssignment
{
    internal class callq1q2
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            obj.accept(654766, "Mohan", "saving", 100000.0D, 'd');
            obj.deposit(5000);
            obj.Details();
            obj.withdrawl(800);
            obj.Details();

            Student objj = new Student(45, "Radheshyam", 8, "CSE");
            objj.display_result();
            objj.display_data();
        }


    }
}
