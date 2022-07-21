using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class Callq1q2q3
    {
        static void Main(string[] args)
        {
            //q1
            //Person obj = Person.accept();
            //obj.showdetails();
            //q2
            //bilding objj = bilding.create();
            //objj.display();
            //q3
            Console.WriteLine($"1. Rectangle \n2. Triangle \n3. Square \n4. Circle");
            int exp = int.Parse(Console.ReadLine());
            int length = 0;
            int breadth = 0;
            int basee = 0;
            int radius = 0;
            double side_length = 0;
            double height = 0;
            double area = 0;
            switch(exp)
            {
                case 1:
                    Console.WriteLine("Enter length");
                    length = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter breadth");
                    breadth = int.Parse(Console.ReadLine());

                    shapes pop = new shapes(length,breadth,basee,radius,side_length,height,area);
                    pop.Calculate_Area(pop.length, pop.breadth);
                    break;

                case 2:
                    Console.WriteLine("Enter base length");
                    basee = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height");
                    height = int.Parse(Console.ReadLine());

                    shapes pop1 = new shapes(length, breadth, basee, radius, side_length, height, area);
                    pop1.Calculate_Area(pop1.basee, pop1.height);
                    break;
                case 3:
                    Console.WriteLine("Enter side length");
                    side_length = int.Parse(Console.ReadLine());

                    shapes pop12 = new shapes(length, breadth, basee, radius, side_length, height, area);
                    pop12.Calculate_Area(pop12.side_length);
                    break;
                case 4:
                    Console.WriteLine("Enter raadius");
                    radius = int.Parse(Console.ReadLine());

                    shapes pop112 = new shapes(length, breadth, basee, radius, side_length, height, area);
                    pop112.Calculate_Area(pop112.radius);
                    break;

            }
        }
    }
}
