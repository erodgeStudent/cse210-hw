using System;

public class Middle : Child {
    
    private int _goal = 500;



    public Middle(string name, string password, bool loggedIn) : base (name, password, loggedIn)
    {
    
    }

        public override string Reward()
    {
        return base.Reward();
    }

}