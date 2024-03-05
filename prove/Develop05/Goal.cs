using System;
using System.Drawing;
using System.IO;
using System.IO.Enumeration;

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

        public void DisplayAll(List<Goal> lst)
    {   
        Console.WriteLine("\nYour goals are:");
        foreach (Goal g in lst)
        {
            g.DisplayGoal();
        }
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

    public virtual void CreateGoalFromFile(string stringrepresentation)
    {

            string [] strArray = stringrepresentation.Split("~");

            Goal current = new Goal("", "", 0)
            {
                _name = strArray[1],
                _description = strArray[2],
                _points = Convert.ToInt32(strArray[3])
            };
            goals.Add(current);
            current.DisplayGoal();
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

    public void Load()
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
                    CreateGoalFromFile(ln);
                    outputFile.WriteLine(ln);
                }
                Console.WriteLine();
            }
        }
    }
}