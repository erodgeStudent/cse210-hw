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

            string goalType = strArray[0];
            //base params
            var name = paramArray[0];
            var description = paramArray[1];
            var points = Convert.ToInt32(paramArray[2]);

            switch (goalType)
            {
                case "SimpleGoal":
                    var isEternal = Convert.ToBoolean(paramArray[3]);
                    SimpleGoal simple = new SimpleGoal(name, description, points, isEternal);
                    lst.Add(simple);
                    simple.DisplayGoal();
                    break;
                case "EternalGoal":
                    EternalGoal eternal = new EternalGoal(name, description, points);
                    lst.Add(eternal);
                    eternal.DisplayGoal();
                    break;
                case "ChecklistGoal":
                    var bonusPoints = Convert.ToInt32(paramArray[3]);
                    var bonusTotalCount = Convert.ToInt32(paramArray[4]);
                    var currentBonus = Convert.ToInt32(paramArray[5]);
                    ChecklistGoal checklist = new ChecklistGoal(name, description, points, bonusPoints, bonusTotalCount, currentBonus);               
                    lst.Add(checklist);
                    checklist.DisplayGoal();
                    break;
                default:
                    Console.WriteLine("None");
                    break;
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