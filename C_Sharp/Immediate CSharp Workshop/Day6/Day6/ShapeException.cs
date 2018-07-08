using System;

namespace Day6
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
        double SideA, SideB, Angle;
    
        public Triangle(double sidea, double sideb) : base(sidea, sideb)
        {
            SideA = sidea;
            SideB = sideb;
        }

        public Triangle(double sidea, double sideb, double angle) : this(sidea, sideb)
        {
            SideA = sidea;
            SideB = sideb;
            Angle = angle;
        }

        public bool TwoSideQuestion()
        {
            char userinput = 'y';
            Console.Write("Is the Triangle a Right Angle Triangle? Press y if yes, any other input to enter the angle.");
            userinput = Console.ReadKey(true).KeyChar;
            try
            {
                if (userinput != 'y' && userinput != 'Y')
                {
                    throw new Exception("Not Right Angle Triangle");
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        
        public override double Area(double sidea, double sideb)
        {
            bool rightangle = TwoSideQuestion();
            string userinput;
            int userinputint;
            if (rightangle == true)
            {
                return 0.5 * sidea * sideb;
            }
            else
            {
                do
                {
                    do
                    {
                        Console.Write("Enter the angle between the two sides >>> ");
                        userinput = Console.ReadLine();
                        Console.WriteLine();
                    } while (int.TryParse(userinput, out userinputint) == false);
                } while (userinputint < 0 && userinputint > 180);

                return Area(sidea,sideb,userinputint);
            }
        }

        public double Area(double sidea, double sideb, double angle)
        {
            return 0.5 * sidea * sideb * Math.Sin(angle); 
        }

        //only for right angle triangles
        public override double Perimeter(double sidea, double sideb)
        {
            bool rightangle = TwoSideQuestion();
            string userinput;
            int userinputint;
            if (rightangle == true)
            {
                return Math.Pow((Math.Pow(sidea, 2) + Math.Pow(sideb, 2)), 0.5) + sidea + sideb;
            }
            else
            {
                do
                {
                    do
                    {
                        Console.Write("Enter the angle between the two sides >>> ");
                        userinput = Console.ReadLine();
                        Console.WriteLine();
                    } while (int.TryParse(userinput, out userinputint) == false);
                } while (userinputint < 0 && userinputint > 180);

                return Perimeter(sidea, sideb, userinputint);
            }
        }

        public double Perimeter(double sidea, double sideb, double angle)
        {
            double cosineside;
            cosineside = Math.Pow(sidea, 2) + Math.Pow(sideb, 2) - 2 * sidea * sideb * Math.Cos(angle);
            cosineside = Math.Pow(cosineside, 0.5);
            return cosineside + sidea + sideb;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle(10,20);
            Triangle T = new Triangle(10, 10);
            Console.WriteLine(T.Area(10, 20));
            //Console.WriteLine(T.Perimeter(10, 20));

        }
    }
}
