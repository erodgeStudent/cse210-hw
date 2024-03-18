using System;

public class Elementary : Child
{   
    private int _extracurricularLevel;

    public Elementary(int age, string name, int rLevel, int hLevel, int ecLevel, string password, bool loggedIn) : base (age, name, rLevel, hLevel, password, loggedIn)
    {
    
        _extracurricularLevel = ecLevel;
    }

    public int GetECLevel()
    {
        return _extracurricularLevel;
    }

    public override int CalculatePointRate()
    {
        var age = GetAge();
        var rLevel = GetRLevel();
        var hLevel = GetHLevel();
        var ecLevel = GetECLevel();
        var rate = age * rLevel * hLevel * ecLevel;
        return rate;
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