using System;

public class High : Child {
    public int _goal = 1000;



    public High(string name, string password, bool loggedIn) : base(name, password, loggedIn)
    {
    }


        public override string Reward()
    {
        return base.Reward();
    }
}