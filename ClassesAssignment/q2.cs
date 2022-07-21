using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssignment
{
    internal class Student
    {
        public int rollno;
        public string name;
        public int standard;
        public string branch;
        public string result;
        public int[] marks = new int[5] {36,46,57,45,77};

        public Student(int a, string b, int c, string d)
        {
            rollno = a;
            name = b;
            standard = c;
            branch = d;
        }
        public void display_result()
        {
            int total = 0;
            foreach(int a in marks)
            {
                if(a<35)
                {
                    result="failed";
                    break;
                }
                total += a;
                
            }
            int avg = total / 5;
            if (avg < 50)
            {
                result = "failed";
            }
            result = "pass";
        }
        public void display_data()
        {
            Console.WriteLine($"Name of Student: {name} \nRoll Number: {rollno} \nClass: {standard} \nBranch: {branch}\n Result: {result}");
        }
    }
    
}
