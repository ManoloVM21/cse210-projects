using System;
using System.Data.SqlTypes;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();
        Square square1 = new Square();
        square1.SetColor("blue");
        square1.SetSide(2.3);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle(2.5,4);
        rectangle1.SetColor("red");
        shapes.Add(rectangle1);

        Circle circle1 = new Circle(6);
        circle1.SetColor("orange");
        shapes.Add(circle1);

        foreach (Shape shape in shapes){
            double area = shape.GetArea();
            Console.WriteLine(area);
        }
    }
}