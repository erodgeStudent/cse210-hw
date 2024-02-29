using System;
using System.Drawing;
using System.IO;

public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _complete= false;
    private string _filename;
    public List<Goal> goals = new List<Goal>();
    

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

    public virtual void DisplayGoal()
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

    public void Save()
    {
        Console.WriteLine("Save file as: ");
        this._filename = Console.ReadLine();

        using (StreamWriter outputfile = new StreamWriter(this._filename))
        {
            foreach (Goal goal in goals)
            {
                goal.DisplayGoal();
            }
        }
    }

    public void Load()
    {
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();

        if (File.Exists(this._filename))
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);
            using (StreamWriter outputFile = new StreamWriter(this._filename))
            {
                foreach (string ln in lines)
                {
                    outputFile.WriteLine(ln);
                }
            }
        } else 
        {
            Console.WriteLine("\nThis file does not exist, please try again.");
            return;
        }
    }
}