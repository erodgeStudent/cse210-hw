using System;
using System.Drawing;

public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _complete= false;
    

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }



    public virtual void RecordEvent(int points)
    {
        _points = points;
        _complete = true;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points += points;
    }
    
    public bool CheckIsComplete()
    {
        return _complete;
    }

    public void DisplayGoal()
    {   
        var check = "";
        if (_complete == true)
        {
            check = "[X]";
        }else{
            check = "[ ]";
        }
        Console.WriteLine(check + " " + _name + " (" + _description + ")");
    }
}