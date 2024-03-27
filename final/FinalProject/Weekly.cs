using System;

class Weekly : Task
{
    private DateTime _timestamp;
    private DateTime _timeToReset;
    public Weekly(string name, int pointVal, bool complete, DateTime timestamp) : base(name, pointVal, complete, timestamp)
    {
        _timestamp = timestamp;
        _timeToReset = _timestamp.AddDays(7).AddHours(9);
    }

        public override void DisplayTaskString()
    {
        // Console.WriteLine("Inside Weekly DisplayTaskString");
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

    public override void SetFrequency()
    {
        DateTime currentTime = DateTime.Now;
        Console.WriteLine(Convert.ToString(currentTime));
        Console.WriteLine(Convert.ToString(GetTimeStamp()));
        Console.WriteLine(Convert.ToString(_timeToReset));
        Console.WriteLine("Inside set frequency weekly");
        int result = DateTime.Compare(currentTime, _timeToReset);
        if (result > 0)
        {
            RenewTask();
        }
    }

}