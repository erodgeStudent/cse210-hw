using System;

class Weekly : Task
{
    private DateTime _timestamp;
    private DateTime _timeToReset;
    public Weekly(string name, int pointVal, bool complete) : base(name, pointVal, complete)
    {
        _timestamp = DateTime.Now;
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

    public override void SetFrequency(Task t)
    {
        //start timer over at 9 am every day.
        DateTime currentTime = DateTime.Now;
        Console.WriteLine(currentTime);
        Console.WriteLine(_timestamp);
        
        if (currentTime >= _timeToReset)
        {
            t.RenewTask();
        }
    }

}