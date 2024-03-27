using System;

class Daily : Task
{
    private DateTime _timeStamp;
    private DateTime _timeToReset;
    public Daily(string name, int pointVal, bool complete, DateTime timestamp) : base(name, pointVal, complete, timestamp)
    {
        _timeStamp = timestamp;
        _timeToReset = new DateTime(DateTime.Now.Year,
                                    DateTime.Now.Month,
                                    DateTime.Now.Day + 1,
                                    5,0,0);
    }

    public override void DisplayTaskString()
    {
        SetFrequency();
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
        var time = GetTimeStamp();
        return $"{GetType()}={name}#{points}#{complete}#"+time;
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