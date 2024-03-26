using System;

class Daily : Task
{
    private bool _complete;
    public Daily(string name, int pointVal, bool complete) : base(name, pointVal, complete)
    {
    }

    public override void DisplayTaskString()
    {
        Console.WriteLine("Inside Daily DisplayTaskString");
        var name = GetName();
        var pVal = GetPointVal();
        var complete = CheckIsComplete();
        var check = "[ ]";
        if (complete == true)
        {check = "[X]"; }
        Console.WriteLine($">> {check} {name} is worth {pVal} points.");
    }

    public override string SaveStringInFile()
    {
        var name = GetName();
        var points = GetPointVal();
        var complete = CheckIsComplete();
        return $"{GetType()}={name}:{points}:{complete}";
    }

    public override void SetFrequency(Task t){
        //start timer over at 9 am every day.
        DateTime tomorrowAtNineAM = DateTime.Now.AddDays(1).AddHours(9);
        DateTime currentTime = DateTime.Now;
        if (tomorrowAtNineAM >= currentTime)
        {
            t.RenewTask();
        }
    }
}