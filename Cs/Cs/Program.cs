using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle1 = new Triangle(3, 4, 5);
            Console.WriteLine(triangle1.Area());
            Console.WriteLine(triangle1.Perimeter());
            Triangle triangle2 = new Triangle(5, 70);
            Console.WriteLine(triangle2.Area());
            Console.WriteLine(triangle2.Perimeter());
            Console.Read();
        }
        abstract class ShapesClass
        {
            abstract public double Area();
            abstract public double Perimeter();
        }
        class Square : ShapesClass
        {
            int side = 0;

            public Square(int n)
            {
                side = n;
            }
            public override double Area()
            {
                return side * side;
            }
            public override double Perimeter()
            {
                return 4 * side;
            }
        }
        class Circle : ShapesClass
        {
            double radius = 0;
            public Circle(double n)
            {
                radius = n;
            }
            public override double Area()
            {
                return  radius * radius * Math.PI;
            }
            public override double Perimeter()
            {
                return 2 * Math.PI * radius;
            }
        }
        class Triangle : ShapesClass
        {
            double a = 0;
            double b = 0;
            double c = 0;
            public Triangle(double n,double m, double k)
            {
                a = n;
                b = m;
                c = k;
            }
            public Triangle(double n,double angle)
            {
                a = n;
                b = Math.Cos(angle) * n;
                c = Math.Sin(angle) * n;
            }
            public override double Area()
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            }
            public override double Perimeter()
            {
                return a+b+c;
            }
        }
    }
}
