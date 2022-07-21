using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class q3
    {
    }
    class shapes
    {
        public int length, breadth, basee,radius;
        public double side_length, height;
        public double area;

        public shapes(int length, int breadth, int basee, int radius, double side_length, double height, double area)
        {
            this.length = length;
            this.breadth = breadth;
            this.basee = basee;
            this.radius = radius;
            this.side_length = side_length;
            this.height = height;
            this.area = area;
        }   

        public void Calculate_Area(int length,int breadth)
        {
            area = length * breadth;
            Console.WriteLine($"Area of Rectangle: {area}");
        }
        public void Calculate_Area(int basee, double height)
        {
            area = 0.5*basee*height;
            Console.WriteLine($"Area of Traingle: {area}");
        }
        public void Calculate_Area(int radius)
        {
            area = 3.144*radius*radius;
            Console.WriteLine($"Area of Circle: {area}");
        }
        public void Calculate_Area(double side_length)
        {
            area = side_length*side_length;
            Console.WriteLine($"Area of Rectangle: {area}");
        }

    }
}
