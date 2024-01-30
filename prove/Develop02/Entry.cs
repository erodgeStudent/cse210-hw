using System;

public class Entry
{   
    public string _entryDate = GetTimeStamp(DateTime.Now);
    public string _userText = UserEntry();
//---------------------------METHODS--------------------------------------------------------
    public static string GetTimeStamp(DateTime value)
    {
        return value.ToString("MM/dd/yyyy");
    }
    public static string UserEntry()
    {
        Console.WriteLine("Inside user Entry");
        string prompt = Prompt.GenerateRandPrompt();
        Console.WriteLine($"{prompt}");
        Console.Write("> ");
        string response = Console.ReadLine();
        string txt = $"Prompt - {prompt}\n{response}";
        return txt;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_entryDate}");
        Console.WriteLine($"{_userText}");
    }
}