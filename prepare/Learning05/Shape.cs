using System;
using System.Drawing;

public class Shape 
{
    private string _color;

    //-----CONSTRUCTOR
    public Shape(string color)
    {
        _color = color;
    }

    //---------GETTERS SETTERS

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    //-------METHODS
    public virtual double GetArea()
    {
        return 0;
    }


}