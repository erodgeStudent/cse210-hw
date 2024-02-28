using System;

public class Rectangle : Shape 
{
    //ATTRIBUTES
    private double _length;
    private double _width;
    //CONSTRUCTOR
    public Rectangle(double length, double width, string color) : base (color)
    {
        _length = length;
        _width = width; 
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}