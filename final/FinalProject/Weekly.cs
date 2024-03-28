using System;

class Weekly : Task
{
    private DateTime _timestamp;
    private DateTime _timeToReset;
    public Weekly(string name, int pointVal, bool complete, DateTime timestamp) : base(name, pointVal, complete, timestamp)
    {
        _timestamp = timestamp.Date;
        _timeToReset = _timestamp.AddDays(7).Date;
    }

        public override void DisplayTaskString()
    {
        var name = GetName();
        var pVal = GetPointVal();
        var complete = CheckIsComplete();
        var renew = GetRenewTime();
        var check = "[ ]";
        if (complete == true)
        {check = "[X]"; }
        Console.WriteLine($">> {check} {name} is worth {pVal} points. Renews: {renew}");
    }

    private DateTime GetRenewTime()
    {
        return _timeToReset;
    }

    public override string SaveStringInFile()
    {
        var name = GetName();
        var points = GetPointVal();
        var complete = CheckIsComplete();
        var time = GetTimeStamp();
        return $"{GetType()}={name}#{points}#{complete}#"+time;
    }

    public override void SetFrequency()
    {
        DateTime currentTime = DateTime.Now;
        int result = DateTime.Compare(currentTime, _timeToReset);
        if (result > 0)
        {
            RenewTask();
        }
    }

}