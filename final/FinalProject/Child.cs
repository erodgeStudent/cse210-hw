using System;
using System.ComponentModel;
using System.Security.Cryptography;

public class Child
{   
    private int _age;
    private string _name;
    private int _responsibilityLevel;
    private int _homeworkLevel;
    private string _password;
    
    private List<string> _chores;
    private bool _loggedIn;

    public Child(int age, string name, int rLevel, int hLevel, string password, bool loggedIn)
    {
        _age = age;
        _name = name;
        _responsibilityLevel = rLevel;
        _homeworkLevel = hLevel;
        _password = password;
        _loggedIn = loggedIn;

    }

    public virtual int CalculatePointRate(int age, int rLevel, int hLevel)
    {
        var rate = age * rLevel * hLevel;
        return rate;
    }

    public void SetPassword(){
        Console.Write("Please set your password: ");
        string password = Convert.ToString(Console.Read());
        _password = password;
    }

    public string GetPassword()
    {   
        return _password;
    }

    public virtual List<Task> GetTasks(int rate, List<Task> allTasks )
    {
        List<Task> tasks = new List<Task>();
        foreach (Task c in allTasks)
        {
            //
        }
        return tasks;
    }

    public bool IsLoggedIn(){
        _loggedIn = true;
        return _loggedIn;
    }


}