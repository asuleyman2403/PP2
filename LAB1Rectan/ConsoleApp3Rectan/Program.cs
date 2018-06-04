using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3Rectan
{
    class Circle
    {
        public static double findArea(double R)
        {
            return Math.PI * R * R;
        }
        public static double findLength(double R)
        {
            return 2 * Math.PI * R;
        }
    }
    class Rectangle
    {
        public static double findPer(double a, double b)
        {
            return 2 * (a + b);
        }
        public static double findArea(double a, double b)
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write radius of the circle:  ");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, write height of rectangle:  ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, write width of rectangle:  ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("The Area of the circle: " + Circle.findArea(R));
            Console.WriteLine("The Length of the circle: " + Circle.findLength(R));
            Console.WriteLine("The Area of the rectangle: " + Rectangle.findArea(a, b));
            Console.WriteLine("The Perimeter of the rectangle: " + Rectangle.findPer(a, b));

        }
    }
}
