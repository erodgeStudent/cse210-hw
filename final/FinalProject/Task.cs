using System;
using System.Dynamic;
using System.Globalization;

public class Task{
    private string _name;
    private int _pointVal;
    private bool _complete;

    public Task(string name, int pointVal, bool complete){
        _name = name;
        _pointVal = pointVal;
        _complete = false;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPointVal()
    {
        return _pointVal;
    }



    public virtual void DisplayTaskString()
    {
        var name = GetName();
        var pVal = GetPointVal();
        var complete = CheckIsComplete();
        var check = "[ ]";
        if (complete == true)
        {check = "[X]"; }
        Console.WriteLine($">> {check} {name} is worth {pVal} points.");
    }

    public virtual string SaveStringInFile()
    {
        var name = GetName();
        var points = GetPointVal();
        var complete = CheckIsComplete();
        return $"{GetType()}={name}:{points}:{complete}";
    }

    public virtual void SetFrequency(Task t){
        //start timer over at 9 am every day.
        DateTime tomorrowAtNineAM = DateTime.Now.AddDays(1).AddHours(9);
        DateTime currentTime = DateTime.Now;
    }

    public bool CheckIsComplete()
    {
        return _complete;
    }

    public void CheckOffTask()
    {
        _complete = true;
    }

    public void RenewTask()
    {
        _complete = false;
    }

    public int RecordCompletedTask()
    {
        CheckOffTask();
        int pointVal = GetPointVal();
        Console.WriteLine($"You performed a task worth {pointVal} points.");
        return pointVal;
    }

}