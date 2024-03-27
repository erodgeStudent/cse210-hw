using System;
using System.Text.RegularExpressions;

public class Middle : Child {
    
    private int _goal;
    private string _password;



    public Middle(int age, string name, string password, bool loggedIn) : base (age, name, password, loggedIn)
    {
    }

    public override void SetGoal() => _goal = 500;

    public override void DisplayPoints(int p)
    {
        int goal = GetGoal();
        Console.WriteLine(goal);
        Console.WriteLine($"You have {p} / {goal} points.");
        Thread.Sleep(3000);
    }

    // public override void SetPassword()
    // {
    //     Console.WriteLine("Please set your password.\nCapital letter, number, and 8 character minimum required. ");
    //     string password = Convert.ToString(Console.Read());
    //     var num = new Regex(@"[0-9]+");
    //     var upper = new Regex(@"[A-Z]");
    //     var min = new Regex(@".{8,}");
    //     var valid = num.IsMatch(password) && upper.IsMatch(password) && min.IsMatch(password);
    //     if (valid)
    //     {
    //         Console.WriteLine("New password stored.");
    //         _password = password;
    //     }
    // }


}