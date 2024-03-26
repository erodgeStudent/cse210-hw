using System;

public class Elementary : Child
{   
    private int _goal = 150;


    public Elementary(string name, string password, bool loggedIn) : base (name, password, loggedIn)
    {
    
    }

        public override string Reward()
    {
        return base.Reward();
    }
}