using System;

public class Primary : Child
{   
    private int _goal = 50;

    public Primary(string name, string password, bool loggedIn) : base (name, password, loggedIn)
    {
    }

    public override string Reward()
    {
        return base.Reward();
    }

}