using System;

public class Middle : Child {
    
    private int _goal = 500;



    public Middle(int age, string name, string password, bool loggedIn) : base (age, name, password, loggedIn)
    {
    
    }

        public override string Reward()
    {
        return base.Reward();
    }

}