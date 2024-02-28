using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Polymorphism with shapes!");

        Console.WriteLine("Square:");
        Square sq = new Square(4,"blue");
        Console.WriteLine(sq.GetColor());
        Console.WriteLine(sq.GetArea());

        Console.WriteLine("Rectangle:");
        Rectangle rect = new Rectangle(2, 5, "purple");
        Console.WriteLine(rect.GetColor());
        Console.WriteLine(rect.GetArea());

        Console.WriteLine("Circle:");
        Circle cir = new Circle(4, "pink");
        Console.WriteLine(cir.GetColor());
        Console.WriteLine(cir.GetArea());

        //build a list
        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(rect);
        shapeList.Add(cir);
        shapeList.Add(sq);
        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine("");
        }
    }
}