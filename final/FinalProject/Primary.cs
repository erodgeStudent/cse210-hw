using System;
using System.Text.RegularExpressions;

public class Primary : Child
{   
    private int _primaryGoal;
    private string _password;

    public Primary(int age, string name, string password, bool loggedIn) : base (age, name, password, loggedIn)
    {
    }


    public override void SetGoal() => _primaryGoal = 50;

    public override int GetGoal(){
        return _primaryGoal;
    }

    public override void DisplayPoints(int p)
    {
        int goal = GetGoal();
        Console.WriteLine($"You have {p} / {goal} points.");
        Thread.Sleep(3000);
    }

    public override string CreateNewPassword()
    {
        return base.CreateNewPassword();
    }   


}