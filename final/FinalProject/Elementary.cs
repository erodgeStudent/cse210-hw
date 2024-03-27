using System;

public class Elementary : Child
{   
    private int _goal = 150;


    public Elementary(int age, string name, string password, bool loggedIn) : base (age, name, password, loggedIn)
    {
    
    }

        public override string Reward()
    {
        return base.Reward();
    }
}