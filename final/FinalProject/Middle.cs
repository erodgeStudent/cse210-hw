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

    public override string CreateNewPassword()
    {
        Console.WriteLine("Please set your password.\nCapital letter, number, special character, and 8 character minimum required. ");
        string password = Convert.ToString(Console.ReadLine());
        var validate = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
        var valid = validate.IsMatch(password);
        if (valid)
        {
            Console.WriteLine("New password stored.");
        }else{
            Console.WriteLine("Requirements not met");
        }
        Thread.Sleep(2000);
        Console.Clear();
        return password;
    }
}