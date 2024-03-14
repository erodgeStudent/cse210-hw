using System;

public class Roman : Child
{   
    private int _age;
    private string _name;
    private int _responsibilityLevel;
    private int _homeworkLevel;
    private int _extraCurricularLevel;
    
    private List<string> _chores;

    public Roman(int age, string name, int rLevel, int hLevel, int ecLevel) : base (age, name, rLevel, hLevel)
    {
        _extraCurricularLevel = ecLevel;
    }

    public override void CalculatePointRate()
    {
        // var rate = age * rLevel * hLevel;
        // return rate;
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