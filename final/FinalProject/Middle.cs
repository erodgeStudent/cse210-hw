using System;
using System.Text.RegularExpressions;

public class Middle : Child {
    
    private int _goal = 500;
    private string _password;



    public Middle(int age, string name, string password, bool loggedIn) : base (age, name, password, loggedIn)
    {
    }

    public override void SetPassword()
    {
        Console.Write("Please set your password.\nCapital letter, number, and 8 character minimum required. ");
        string password = Convert.ToString(Console.Read());
        var num = new Regex(@"[0-9]+");
        var upper = new Regex(@"[A-Z]");
        var min = new Regex(@".{8,}");
        var valid = num.IsMatch(password) && upper.IsMatch(password) && min.IsMatch(password);
        if (valid)
        {
            Console.WriteLine("New password stored.");
            _password = password;
        }
    }
    public override string Reward()
    {
        return base.Reward();
    }

}