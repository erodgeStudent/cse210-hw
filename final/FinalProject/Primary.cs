using System;

public class Primary : Child
{   

    public Primary(int age, string name, int rLevel, int hLevel, string password, bool loggedIn) : base (age, name, rLevel, hLevel, password, loggedIn)
    {
    }

    public override int CalculatePointRate()
    {
        return base.CalculatePointRate();
    }

   
}