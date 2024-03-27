using System;

class Daily : Task
{
    private DateTime _timeStamp;
    private DateTime _timeToReset;
    public Daily(string name, int pointVal, bool complete) : base(name, pointVal, complete)
    {
        _timeStamp = DateTime.Now;
        _timeToReset = _timeStamp.AddDays(1).AddHours(9);
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
        DateTime currentTime = DateTime.Now;
        Console.WriteLine(currentTime);
        Console.WriteLine(_timeStamp);
        
        if (currentTime >= _timeToReset)
        {
            t.RenewTask();
        }
    }
}