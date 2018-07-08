using System;

public class Rectangle
{
    double Length { get; set; }
    double Breadth { get; set; }

    //constructor
    public Rectangle()
    {
        Length = 0;
        Breadth = 0;
    }

    public Rectangle(double a, double b)
    {
        Length = a;
        Breadth = b;
    }

    public double perimeterRectangle()
    {
        return Length*2+Breadth*2;
    }
    public double perimeterRectangle(double a, double b)
    {
        Length = a;
        Breadth = b;
        return Length*2+Breadth*2;
    }

    
}
public class RectangleApp
{
    public static void Main()
    {
        Rectangle Rec1 = new Rectangle(10, 5);
        Console.WriteLine("Perimeter : {0}", Rec1.perimeterRectangle());

        Rectangle Rec2 = new Rectangle();
        Console.WriteLine("Perimeter : {0}", Rec2.perimeterRectangle(6, 10));
    }
     
}