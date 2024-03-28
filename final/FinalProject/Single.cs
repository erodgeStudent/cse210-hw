using System;
using Microsoft.VisualBasic.FileIO;
class Single : Task {
    public Single(string name, int pointVal, bool complete, DateTime timestamp) : base (name, pointVal, complete, timestamp)
    {}

    public override string SaveStringInFile()
    {
        var name = GetName();
        var points = GetPointVal();
        var complete = CheckIsComplete();
        return $"{GetType()}={name}#{points}#{complete}";
    }

    public override void DisplayTaskString()
    {
        var name = GetName();
        var pVal = GetPointVal();
        var complete = CheckIsComplete();
        var check = "[ ]";
        if (complete == true)
        {check = "[X]"; }
        Console.WriteLine($">> {check} {name} is worth {pVal} points.");
    
    }

}