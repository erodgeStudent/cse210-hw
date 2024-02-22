using System;

//Takes a running count of minutes and saves it to a TXT file
public class Log
{
    private int _totalActivityTime;
    private string _activity;

    public Log(int tt, string activity)
    {
        _totalActivityTime = tt;
        _activity = activity;
    }

    //GETTERS AND SETTERS
    public int GetTotalTime()
    {
        return _totalActivityTime;
    }


    public int SetLogTime()
    {
        return _totalActivityTime;
    }
    //METHODS
    public void LogMoreTime(int time)
    {
        Console.WriteLine("function to add new time to log");
    }

}