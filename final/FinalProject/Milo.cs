using System;
using System.Security.Cryptography;

public class Milo : Child
{   
    private int _age;
    private string _name;
    private int _responsibilityLevel;
    private string _password;
    private int _homeworkLevel;
    private bool _loggedIn;
    
    private List<string> _chores;

    public Milo(int age, string name, int rLevel, int hLevel, string password, bool loggedIn) : base (age, name, rLevel, hLevel, password, loggedIn)
    {
    }


    public override List<Task> GetTasks(int rate, List<Task> allTasks )
    {
        List<Task> tasks = new List<Task>();
        foreach (Task c in allTasks)
        {
            //
        }
        return tasks;
    }
}