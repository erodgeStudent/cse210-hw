using System;
using System.ComponentModel;
using System.Security.Cryptography;

public class Child
{   
    private int _age;
    private string _name;
    private string _password;
    private string _filename;
    private int _points;
    public int _goal = 0;
    
    private bool _loggedIn;
    public List<Task> _userTasks = new List<Task>();

    public Child(int age, string name, string password, bool loggedIn)
    {
        _age = age;
        _name = name;
        _password = password;
        _loggedIn = loggedIn;

    }

    public int GetAge()
    {
        return _age;
    }

    public string SaveFile(){
        var name = GetName();
        _filename = name;
        return _filename;
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
        List<string> childTasks = new List<string>();
        Console.WriteLine("Saving:");
        foreach (Task t in _userTasks)
        {
                var stringSave = t.SaveStringInFile();
                childTasks.Add(stringSave);
                Console.WriteLine(stringSave);
                Thread.Sleep(1000);
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

    public int GetGoal()
    {
        return _goal;
    }

    public virtual string Reward()
    {
        return "Here is your reward.";
    }


}