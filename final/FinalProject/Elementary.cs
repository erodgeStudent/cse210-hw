using System;
using System.Text.RegularExpressions;

public class Elementary : Child
{   
    private int _elementaryGoal;
    private string _password;

    public Elementary(int age, string name, string password, bool loggedIn) : base (age, name, password, loggedIn)
    {
    }

    public override void SetGoal() => _elementaryGoal = 150;

    public override int GetGoal()
    {
        return _elementaryGoal;
    }

    public override void DisplayPoints(int p)
    {
        int goal = GetGoal();
        Console.WriteLine($"You have {p} / {goal} points.");
        Reward(p, goal);
        Thread.Sleep(3000);
    }

    public override string CreateNewPassword()
    {
        Console.WriteLine("Please set your password.\nAt least one capital letter and number are required, minimum 5 characters. ");
        string password = Convert.ToString(Console.ReadLine());
        var upper = new Regex(@"[A-Z]");
        var min = new Regex(@".{5,}");
        var num = new Regex(@"[0-9]+");
        var valid = upper.IsMatch(password) && min.IsMatch(password) && num.IsMatch(password);
        if (valid)
        {
            Console.WriteLine("New password stored.");
            
        }
        Thread.Sleep(2000);
        Console.Clear();
        return password;
    }



}