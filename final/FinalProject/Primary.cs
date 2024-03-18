using System;

public class Primary : Child
{   


    public Primary(int age, string name, int rLevel, int hLevel, string password, bool loggedIn) : base (age, name, rLevel, hLevel, password, loggedIn)
    {
    }

    // public override void CalculatePointRate()
    // {
    //     base.CalculatePointRate();
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