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
    private int _totalPoints;
    private bool _complete= false;
    private string _filename;
    

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
        _complete = true;
        GetTotalPoints();
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        SetTotalPoints(points);
        Console.WriteLine($"You now have {_totalPoints} points.");
        return _totalPoints;
    }

    public int GetPoints()
    {
        return _points;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void SetTotalPoints(int p)
    {
        _totalPoints += p;
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
        Console.WriteLine($"{check} {_name}  ({_description})");
    }

    public virtual void DisplayAll(List<Goal> lst)
    {   
        Console.WriteLine("\nYour goals are:");
        foreach (Goal g in lst)
        {
            g.DisplayGoal();
        }
    }

    public virtual string GetStringRepresentation()
    {
        var name = GetName();
        var description = GetDescription();
        var points = GetPoints();
        return $"{GetType()}:{name}~{description}~{points}";
    }

    public virtual void CreateGoalFromFile(string stringrepresentation, List<Goal> lst)
    {

            string [] strArray = stringrepresentation.Split(":");
            string[] paramArray = strArray[1].Split("~");
            //type of goal
            var goalType = strArray[0];
            //get each param and add new object to _goals
            if (paramArray.Count() == 4)
            {
                SimpleGoal simple = new SimpleGoal("","" ,0, false);
                {   
                    _name = paramArray[0];
                    _description = paramArray[1];
                    _points = Convert.ToInt32(paramArray[2]);
                };
                lst.Add(simple);
            }

            if (paramArray.Count() == 3)
            {
                EternalGoal eternal = new EternalGoal("","",0);
                {
                    _name = paramArray[0];
                    _description = paramArray[1];
                    _points = Convert.ToInt32(paramArray[2]);
                }
                lst.Add(eternal);
            }

            
    }

    public void Save(string filename, List<string> lst)
    {   
        //if file exists, add new lines
        if (File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            
            using (StreamWriter outputfile = new StreamWriter(filename))
            {   
                foreach (string ln in lines)
                {
                    outputfile.WriteLine(ln);
                }
                // outputfile.WriteLine{totalPoints};
                foreach (string s in lst)
                {
                    outputfile.WriteLine(s);
                } 
            }
        } else {
            using (StreamWriter outputfile = new StreamWriter(filename))
            {   
                // outputfile.WriteLine{totalPoints};
                foreach (string s in lst)
                {
                    outputfile.WriteLine(s);
                } 
            }
        }
    }

    public void Load(List<Goal> lst)
    {
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("\nThis file does not exist, please try again.");
            return;
        }
        else
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                Console.WriteLine($"\n Goals in {filename}:\n");
                foreach (string ln in lines)
                {
                    CreateGoalFromFile(ln, lst);
                    outputFile.WriteLine(ln);
                }
                Console.WriteLine();
            }
        }
    }
}