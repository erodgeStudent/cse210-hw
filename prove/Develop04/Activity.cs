using System;

public class Activity
{
    private string _message;
    private string _description;
    private int _seconds;
    private int _totalActivityTime;
    public List<string> _spinner = new List<string>()
    {
        "/","|","\\","-","/","|"
    };


    //CONSTRUCTOR

    public Activity(string msg, string dscrpt, int secs, int time)
    {
        _message = "Welcome to the " + msg;
        _description = "Description: "+ dscrpt;
        _seconds = secs;
        _totalActivityTime = time;
    }
    //GETTERS
    public int GetSeconds()
    {
        return _seconds;
    }

    public static void GetReady()
    {
        Console.WriteLine("Get Ready");
        Thread.Sleep(5000);
    }

    public void PlaySpinner()
    {
        foreach (string s in _spinner)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }

    }

    public string GetDescription()
    {
        return $"{_message}\n{_description}";
    }

        public string GetSummary(int time, string activity)
    {
        return $"\n\nYou have completed another {time} seconds of the {activity}";
    }

    public int LogMoreTime(int seconds)
    {
        Console.WriteLine("Logging your time..");
        _totalActivityTime = _totalActivityTime + seconds;
        return _totalActivityTime;
    }

    public void SetTotalTime(int newTotal)
    {
        _totalActivityTime = newTotal;
    }

    public int GetTotalTime()
    {
        return _totalActivityTime;
    }

}