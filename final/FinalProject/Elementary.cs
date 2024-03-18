using System;

public class Elementary : Child
{   
    private int _extracurricularLevel;

    public Elementary(int age, string name, int rLevel, int hLevel, int ecLevel, string password, bool loggedIn) : base (age, name, rLevel, hLevel, password, loggedIn)
    {
    
        _extracurricularLevel = ecLevel;
    }

    // public override void CalculatePointRate()
    // {
    //     // var rate = age * rLevel * hLevel;
    //     // return rate;
    // }

    public override List<Task> GetTasks(int rate, List<Task> allTasks )
    {
        List<Task> tasks = new List<Task>();
        foreach (Task c in allTasks)
        {
            //
        }
        return tasks;
    }
}