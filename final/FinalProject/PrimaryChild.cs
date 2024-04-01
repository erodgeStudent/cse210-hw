using System;
using System.Text.RegularExpressions;

public class PrimaryChild : Child
{   
    private int _primaryGoal;
    private string _password;
    public List<Task> _primaryUserTasks = new List<Task>();

    public PrimaryChild(int age, string name, string password, bool loggedIn) : base (age, name, password, loggedIn)
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
        Reward(p, goal);
        Thread.Sleep(3000);
    }

    public override string CreateNewPassword()
    {
        return base.CreateNewPassword();
    }   

    public override List<string> GetTasks()
    {
        List<string> childTasks = new List<string>();
        foreach (Task t in _primaryUserTasks)
        {
                var stringSave = t.SaveStringInFile();
                childTasks.Add(stringSave);
        }
        return childTasks;
    }


}