using System;
using System.Drawing;

public class Square : Shape 
{
    private double _side;

    //----CONSTRUCTOR
    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    //------METHODS
    public override double GetArea()
    {
        return _side * 4;
    }
}