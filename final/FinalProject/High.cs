using System;
using System.Text.RegularExpressions;

public class High : Child {
    private int _highGoal;
    private string _password;


    public High(int age, string name, string password, bool loggedIn) : base(age, name, password, loggedIn)
    {
    }

    public override void SetGoal() => _highGoal = 1000;

    public override int GetGoal()
    {
        return _highGoal;
    }
    public override void DisplayPoints(int p)
    {
        int goal = GetGoal();
        Console.WriteLine($"You have {p} / {goal} points.");
        Thread.Sleep(3000);
    }

    public override string CreateNewPassword()
    {
        Console.WriteLine("Please set your password.\nCapital letter, number, special character, and 8 character minimum required. ");
        string password = Convert.ToString(Console.ReadLine());
        var num = new Regex(@"[0-9]+");
        var upper = new Regex(@"[A-Z]");
        var min = new Regex(@".{8,}");
        var specialChars = new Regex(@"[!#$%^&()_.-]");
        var valid = num.IsMatch(password) && upper.IsMatch(password) && min.IsMatch(password) && specialChars.IsMatch(password);
        if (valid)
        {
            Console.WriteLine("New password stored.");
        }
        Thread.Sleep(2000);
        Console.Clear();
        return password;
    }


}