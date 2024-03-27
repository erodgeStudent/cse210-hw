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
        // Console.WriteLine("Inside DisplayTaskString");
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
        // Console.WriteLine("Inside DisplayTaskString");
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
        // Console.WriteLine($"Inside CheckIsComplete: {_complete}");
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
        // Console.WriteLine("Inside RecordCompletedTask");
        CheckOffTask();
        int pointVal = GetPointVal();
        Console.WriteLine($"You performed a task worth {pointVal} points.");
        return pointVal;
    }

    public Task DetermineTask(string type, string name, int points, bool complete)
    {
        // Console.WriteLine($"Inside DetermineTask {complete}");
        Task task1 = new Task(name, points, complete);
        switch (type)
        {
            case "Daily":
                task1 = new Daily(name, points, complete);
                SetFrequency(task1);
                break;
            case "Single":
                task1 = new Single(name, points, complete);
                break;
            case "Weekly":
                task1 = new Weekly(name, points, complete);
                SetFrequency(task1);
                break;
            
        }
        return task1;
    }

}