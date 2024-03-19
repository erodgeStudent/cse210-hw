using System;

public class Primary : Child
{   
    private int _goal = 50;

    public Primary(int age, string name, string password, bool loggedIn) : base (age, name, password, loggedIn)
    {
    }

    public override string Reward()
    {
        return base.Reward();
    }

}