using System;

class Daily : Task
{
    private DateTime _timeStamp;
    private DateTime _timeToReset;
    
    public Daily(string name, int pointVal, bool complete, DateTime timestamp) : base(name, pointVal, complete, timestamp)
    {
        _timeStamp = timestamp.Date;
        _timeToReset = _timeStamp.AddDays(1);
    }

    private DateTime GetRenewTime()
    {
        return _timeToReset;
    }

    
    public override void DisplayTaskString()
    {
        SetFrequency();
        var name = GetName();
        var pVal = GetPointVal();
        var complete = CheckIsComplete();
        var renew = GetRenewTime();
        var check = "[ ]";
        if (complete == true)
        {check = "[X]"; }
        Console.WriteLine($">> {check} {name} is worth {pVal} points. Renews: {renew}");
    }

    public override string SaveStringInFile()
    {
        var name = GetName();
        var points = GetPointVal();
        var complete = CheckIsComplete();
        var time = GetTimeStamp();
        var renew = GetRenewTime();
        return $"{GetType()}={name}#{points}#{complete}#{time}#{renew}";
    }

    public override void SetFrequency(){
        //start timer over at 9 am every day.
        DateTime currentTime = DateTime.Now;
        int result = DateTime.Compare(currentTime, _timeToReset);
        if (result > 0)
        {
            RenewTask();
        }
    }
}