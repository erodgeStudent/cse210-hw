using System;

class Weekly : Task
{
    public Weekly(string name, int pointVal, bool complete) : base(name, pointVal, complete)
    {}

        public override void DisplayTaskString()
    {
        Console.WriteLine("Inside Weekly DisplayTaskString");
        var name = GetName();
        var pVal = GetPointVal();
        var complete = CheckIsComplete();
        var check = "[ ]";
        if (complete == true)
        {check = "[X]"; }
        Console.WriteLine($">> {check} {name} is worth {pVal} points.");
    }


}