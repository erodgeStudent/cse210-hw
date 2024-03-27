using System;

public class High : Child {
    public int _goal = 1000;



    public High(int age, string name, string password, bool loggedIn) : base(age, name, password, loggedIn)
    {
    }


        public override string Reward()
    {
        return base.Reward();
    }
}