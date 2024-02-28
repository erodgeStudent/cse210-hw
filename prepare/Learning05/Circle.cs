using System;

public class Circle : Shape 
{
    private double _radius;

    public Circle(double radius, string color) : base (color)
    {
        _radius = radius;
    }

    //METHOD
    public override double GetArea()
    {
        return Math.Round(Math.PI * _radius * _radius, 2);
    }
}