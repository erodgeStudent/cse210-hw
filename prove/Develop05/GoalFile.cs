using System;
using System.Drawing;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.InteropServices.ObjectiveC;
class GoalFile{

    private int _totalPoints;

    public List<string> CollectGoalsToSave(List<Goal> lst)
    {
        List<string> saveList = new List<string>();
        foreach (Goal g in lst){
            var saveString = g.GetStringRepresentation();
            saveList.Add(saveString);
        }
        return saveList;
    }

        public virtual void DisplayAll(List<Goal> lst)
    {   
        Console.WriteLine("\nYour goals are:");
        foreach (Goal g in lst)
        {
            g.CheckIsComplete();
            g.DisplayGoal();
        }
    }

    public void Save(List<string> lst)
    {   
        Console.WriteLine("Save File As: ");
        var filename = Console.ReadLine();
        
            using (StreamWriter outputfile = new StreamWriter(filename))
            {   
                // outputfile.WriteLine{totalPoints};
                foreach (string s in lst)
                {
                    outputfile.WriteLine(s);
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


    public void CreateGoalFromFile(string stringrepresentation, List<Goal> lst)
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
                    var complete = Convert.ToBoolean(paramArray[3]);
                    Console.WriteLine(complete);
                    SimpleGoal simple = new SimpleGoal(name, description, points, complete);
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


    public void SetTotalPoints(int points)
    {
        _totalPoints += points;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public string QuitProgram()
    {
        Console.Write("Are you sure you want to quit? (y/n) ");
        var quit = Console.ReadLine();
        return quit;
    }
}