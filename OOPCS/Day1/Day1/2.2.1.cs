using System;

public class Triangle
{
    public double side1Value { get; set; }
    public double side2Value { get; set; }
    public double side3Value { get; set; }

    //constructor
    public Triangle()
    {
        this.side1Value = side1Value;
        this.side2Value = side2Value;
        this.side3Value = side3Value;
    }

    public Triangle(double side1, double side2, double side3)
    {
        this.side1Value = side1;
        this.side2Value = side2;
        this.side3Value = side3;
    }

    public double perimeterTriangle()
    {
        return side1Value + side2Value + side3Value;
    }
    public double perimeterTriangle(double side1, double side2, double side3)
    {
        //side1Value = side1;
        //side2Value = side2;
        //side3Value = side3;
        return side1 + side2 + side3;
    }

    
}
public class TriangleApp
{
    public static void Main()
    {
        Triangle tri1 = new Triangle();
        tri1.side1Value = 3;
        tri1.side2Value = 4;
        tri1.side3Value = 5;
        Console.WriteLine("Perimeter : {0}", tri1.perimeterTriangle());
        Console.WriteLine("Side A : {0}", tri1.side1Value);
        Console.WriteLine("Side B : {0}", tri1.side2Value);
        Console.WriteLine("Side C : {0}", tri1.side3Value);

        Triangle tri2 = new Triangle(8, 6, 10);
        Console.WriteLine("Perimeter : {0}", tri2.perimeterTriangle());
        Console.WriteLine("Side A : {0}", tri2.side1Value);
        Console.WriteLine("Side B : {0}", tri2.side2Value);
        Console.WriteLine("Side C : {0}", tri2.side3Value);

        Triangle tri3 = new Triangle();
        Console.WriteLine("Perimeter : {0}", tri3.perimeterTriangle(4,3,5));
        Console.WriteLine("Side A : {0}", tri3.side1Value);
        Console.WriteLine("Side B : {0}", tri3.side2Value);
        Console.WriteLine("Side C : {0}", tri3.side3Value);
    }
}