using System;
using System.Drawing;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.InteropServices.ObjectiveC;

public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;

    

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }


    public Goal GetGoalByIndex(int i, List<Goal> lst)
    {
        Console.WriteLine(lst.Count);
        return lst[i];
    }

    public virtual int RecordEvent()
    {   
        int points = GetPoints();
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        return points;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void Completed()
    {
        _complete = true;
    }

    public void NotCompleted()
    {
        _complete = false;
    }
    
    public bool CheckIsComplete()
    {
        return _complete;
    }

    public virtual void DisplayGoal()
    {   
        var check = "";
        if (_complete == true)
        {
            check = "[X]";
        }else{
            check = "[ ]";
        }
        Console.WriteLine($"{check} {_name}  ({_description})");
    }



    public virtual string GetStringRepresentation()
    {
        var name = GetName();
        var description = GetDescription();
        var points = GetPoints();
        return $"{GetType()}:{name}~{description}~{points}";
    }

}