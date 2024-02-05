using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Learning Activity W05: Fraction");
        //call constructors to test 
        Fraction f1 = new Fraction();
        // Fraction f2 = new Fraction(3);
        // Fraction f3 = new Fraction(2,3);

        f1.SetTop(3);
        f1.SetBottom(2);
        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetBottom());

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

    }
}

