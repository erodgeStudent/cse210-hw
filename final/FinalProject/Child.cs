using System;

public class Child
{   
    private int _age;
    private string _name;
    private int _responsibilityLevel;
    private int _homeworkLevel;
    
    private List<string> _chores;

    public Child(int age, string name, int rLevel, int hLevel)
    {
        _age = age;
        _name = name;
        _responsibilityLevel = rLevel;
        _homeworkLevel = hLevel;
    }

    public virtual void CalculatePointRate()
    {
        // var rate = age * rLevel * hLevel;
        // return rate;
    }

    public virtual List<Task> GetTasks(int rate, List<Task> allTasks )
    {
        List<Task> tasks = new List<Task>();
        foreach (Task c in allTasks)
        {
            //
        }
        return tasks;
    }
}