using System;
using Microsoft.VisualBasic.FileIO;
class Single : Task {
    public Single(string name, int pointVal, bool complete) : base (name, pointVal, complete)
    {}

    public override string SaveStringInFile()
    {
        var name = GetName();
        var points = GetPointVal();
        var complete = CheckIsComplete();
        return $"{GetType()}={name}:{points}:{complete}";
    }

    public override void DisplayTaskString()
    {
        Console.WriteLine("Inside Single DisplayTaskString");
        var name = GetName();
        var pVal = GetPointVal();
        var complete = CheckIsComplete();
        var check = "[ ]";
        if (complete == true)
        {check = "[X]"; }
        Console.WriteLine($">> {check} {name} is worth {pVal} points.");
    
    }


    public override void SetFrequency(Task t)
    {
        DateTime tmrAtNineAM =  DateTime.Now.AddDays(1).AddHours(9);
        DateTime currentTime = DateTime.Now;
        Console.WriteLine(tmrAtNineAM);
        var done = t.CheckIsComplete();
        if (done == true)
        {
            if (currentTime >= tmrAtNineAM)
            {
                t =  null; 
            }
        }
    }


}