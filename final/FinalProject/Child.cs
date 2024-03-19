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
    private string _filename;
    private int _points;
    public int _range;
    
    private bool _loggedIn;
    public List<Task> _userTasks = new List<Task>();

    public Child(int age, string name, int rLevel, int hLevel, string password, bool loggedIn)
    {
        _age = age;
        _name = name;
        _responsibilityLevel = rLevel;
        _homeworkLevel = hLevel;
        _password = password;
        _loggedIn = loggedIn;

    }

    public int GetAge()
    {
        return _age;
    }

    public int GetRLevel()
    {
        return _responsibilityLevel;
    }

    public string SaveFile(){
        var name = GetName();
        _filename = name;
        return _filename;
    }

    public int GetHLevel()
    {
        return _homeworkLevel;
    }

    public virtual int CalculatePointRate()
    {
        var age = GetAge();
        var rLevel = GetRLevel();
        var hLevel = GetHLevel();
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

    public string GetName()
    {
        return _name;
    }

    public List<string> GetTasks()
    {
        Console.WriteLine("inside GetTasks");
        List<string> childTasks = new List<string>();
        var range = GetRange();
        Console.WriteLine("Saving:");
        foreach (Task t in _userTasks)
        {
            // var points = t.GetPointVal();
            // if (points < range){
                var stringSave = t.SaveStringInFile();
                childTasks.Add(stringSave);
                Console.WriteLine(stringSave);
                Thread.Sleep(1000);
            // }
        }
        return childTasks;
    }

    public bool IsLoggedIn(){
        _loggedIn = true;
        return _loggedIn;
    }

    public int GetPoints()
    {
        return _points;
    }

    public int GetRange()
    {
        return _range;
    }


}