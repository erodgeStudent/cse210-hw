using System;
using System.Drawing;
using System.IO;

public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private int _totalPoints;
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
        _totalPoints += points;
        _complete = true;
        GetTotalPoints();
    }

    public int GetPoints()
    {
        return _points;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
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

    public virtual string GetStringRepresentation(Goal goal)
    {
        var objType = goal.GetType();
        var name = goal.GetName();
        var description = goal.GetDescription();
        var points = goal.GetPoints();
        string saveString = $"{objType}~{name}~{description}~{points}";
        return saveString;
    }

    public void Save(string filename, List<string> lst)
    {

        using (StreamWriter outputfile = new StreamWriter(filename))
        {   
            // outputfile.WriteLine{totalPoints};
            foreach (string s in lst)
            {
                outputfile.WriteLine(s);
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