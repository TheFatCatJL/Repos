using System;

namespace Day5
{

    public abstract class Shape
    {
        double Width;
        double Height;
        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public abstract double Area(double width, double height);
        public abstract double Perimeter(double width, double height);
        
    }

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height) { }
        
        public override double Area(double width, double height)
        {
            return width * height;
        }

        public override double Perimeter(double width, double height)
        {
            return 2 * (width + height);
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height) { }

        public override double Area(double width, double height)
        {
            return 0.5*width*height ;
        }
        
        public override double Perimeter(double width, double height)
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle(10,20);
            Triangle T = new Triangle(10, 10);
            Console.WriteLine(R.Area(10, 20));
            Console.WriteLine(R.Perimeter(10, 20));
            Console.WriteLine(T.Area(10, 20));
            Console.WriteLine(T.Perimeter(10, 20));

        }
    }
}
