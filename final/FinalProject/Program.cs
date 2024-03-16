using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello FinalProject World!");
        Max max = new Max(5, "Max", 1, 1, "MaxoRama5", false);
        Milo milo = new Milo(7, "Milo", 2, 2, "MiloMan7", false);
        Roman roman = new Roman(9, "Roman", 3, 3, 2, "RowRow9", false);
        Bane bane = new Bane(11, "Bane", 4, 4, 5, "Baniac11", false);
        
        List<Child> _children = [max, milo, roman, bane];
        
        Menu menu = new Menu();
        menu.Login(_children);





    }
}