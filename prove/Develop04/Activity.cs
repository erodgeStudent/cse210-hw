using System;

public class Activity
{
    private string _message;
    private string _description;
    private int _seconds;
    public List<string> _spinner = new List<string>()
    {
        "/","|","\\","-","/","|"
    };


    //CONSTRUCTOR

    public Activity(string msg, string dscrpt, int secs)
    {
        _message = "Welcome to the " + msg;
        _description = "Description: "+ dscrpt;
        _seconds = secs;
    }
    //GETTERS
    public int GetTime()
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


    public string GetSummary()
    {
        return $"{_message}\n{_description}";
    }
}