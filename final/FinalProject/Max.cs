using System;

public class Max : Child
{   
    private int _age;
    private string _name;
    private int _responsibilityLevel;
    private int _homeworkLevel;
    
    private List<string> _chores;

    public Max(int age, string name, int rLevel, int hLevel) : base (age, name, rLevel, hLevel)
    {
    }

    public override void CalculatePointRate()
    {
        base.CalculatePointRate();
    }

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