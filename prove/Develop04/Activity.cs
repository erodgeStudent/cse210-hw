using System;

public class Activity
{
    private string _message;
    private string _description;
    private int _seconds;

    //CONSTRUCTOR

    public Activity(string msg, string dscrpt, int secs)
    {
        _message = "Welcome to the " + msg;
        _description = "Description: "+ dscrpt;
        _seconds = secs;
    }

    public static void GetReady()
    {
        Console.WriteLine("Get Ready");
        Thread.Sleep(5000);
    }

    public void PauseApp()
    {
        Thread.Sleep(_seconds);
    }
    public string GetSummary()
    {
        return $"{_message}\n{_description}";
    }
}