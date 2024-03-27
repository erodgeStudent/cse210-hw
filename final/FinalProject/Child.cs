using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public class Child
{   
    private int _age;
    private string _name;
    private string _password;
    private string _filename;
    private int _points;
    private int _goal = 0;
    
    private bool _loggedIn;
    public List<Task> _userTasks = new List<Task>();

    public Child(int age, string name, string password, bool loggedIn)
    {
        _age = age;
        _name = name;
        _password = password;
        _loggedIn = loggedIn;

    }

    public Child ListAllChildren(List<Child> lst)
    {
        Child child = new Child (0,"","",false);
        
        int count = 1;
        Console.WriteLine("Select a user: ");
        foreach (Child c in lst)
        {
            
            Console.WriteLine($"\t{count}. {c.GetName()}");
            count ++;
        }
        var userChoice = Convert.ToInt32(Console.ReadLine());
        int i = userChoice-1;
        child = lst[i];

        
        return child;
    }

    public Child DetermineAge(){
        Console.WriteLine("Enter your child's birthday mm-dd-yyyy");
        string input = Console.ReadLine();
        string pattern = @"(0[1-9]|1[0,1,2])-(0[1-9]|[12][0-9]|3[01])-(19|20)\d{2}";
        Regex regex = new Regex(pattern);
        Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
        Child child1 = new Child(0,"","", false);
        if (match.Success)
            {
                Console.WriteLine("successfully matched birthday format.");
                string [] dateArray = input.Split("-");
                int bMonth = Convert.ToInt16(dateArray[0]);
                int bDate = Convert.ToInt16(dateArray[1]);
                int bYear = Convert.ToInt16(dateArray[2]);
                DateTime now = DateTime.Today;
                int age = now.Year - bYear;
                Console.WriteLine("What is your child's name?");
                string name = Console.ReadLine();
                Console.WriteLine("Create a password: ");
                string password = Console.ReadLine();
                child1 = DetermineAgeGroup(age, name, password);
            }
            else 
            {
                Console.WriteLine("Try again.");
            }
            return child1;
    }


    public Child DetermineAgeGroup(int a, string name, string passWd)
    {
        //determine which child object to create

        switch (a)
        {
            case int i when i <= 7:
                Primary primary = new Primary(a, name,passWd,false);
                return primary;
            case int i when i >= 8 && i <= 10:
                Elementary elementary = new Elementary(a,name, passWd,false);
                return elementary;
            case int i when i >= 11 && i <= 13:
                Middle middle = new Middle(a,name, passWd, false);
                return middle;
            default:
                High high = new High(a,name, passWd, false);
                return high;
        }
    }



    public void PasswordLogin(){
        var correct = false;
        string password = GetPassword();
        do{
            Console.WriteLine(password);
            Console.WriteLine("Enter your password");
            string input = Console.ReadLine();
            
            if (input == password){
                IsLoggedIn();
                Console.WriteLine($"Welcome, {GetName()}!");
                correct = true;
            } else {
                Console.WriteLine("Error. Try again.");
                correct = false;
            }
        } while ( correct == false);
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

    public virtual void SetPassword(){
        Console.Write("Please set your password.\nMinimum 5 characters. ");
        string password = Convert.ToString(Console.Read());
        var min = new Regex(@".{5,}");
        {
            Console.WriteLine("Password is stored.");
            _password = password;
        }
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
        foreach (Task t in _userTasks)
        {
                var stringSave = t.SaveStringInFile();
                childTasks.Add(stringSave);
        }
        return childTasks;
    }

    public List<string> GetUsers(List<Child> lst)
    {
        List<string> saveUsers = new List<string>();
        foreach (Child c in lst)
        {
            var saveString = SaveStringInFile();
            saveUsers.Add(saveString);
        }
        return saveUsers;
    }

    public virtual string SaveStringInFile()
    {
        var name = GetName();
        var age = GetAge();
        var password = GetPassword();
        var loggedIn = IsLoggedIn();
        return $"{GetType()}={age}:{name}:{password}:{loggedIn}";
    }

    public bool IsLoggedIn(){
        _loggedIn = true;
        return _loggedIn;
    }

    public bool LogOut()
    {
        _loggedIn = false;
        return _loggedIn;
    }

    public void AddUserPoints(int points)
    {
        _points += points;
    }
    public int GetPoints()
    {
        return _points;
    }

    public void RestartPoints()
    {
        _points = 0;
    }

    public int GetGoal()
    {
        return _goal;
    }

    public void DisplayPoints(){
        Console.Clear();
        TaskFile file1 = new TaskFile();
        int points = file1.GetTotalUserPts();
        int goal = GetGoal();
        if (points < 0)
        {
            Console.WriteLine($"Great job! You have {points} / {goal}");
        }
        else{
            Console.WriteLine("Let's start earning some points!");
        }
        Thread.Sleep(3000);
    }

    public void Reward()
    {
        Console.Clear();
        Console.WriteLine( "You earned a Reward!");
        Thread.Sleep(3000);
        RestartPoints();
    }

    public virtual List<Task> AddTask(Task t)
    {
        _userTasks.Add(t);
        return _userTasks;
    }

    public void ListUserTasks()
    {   
        foreach (Task t in _userTasks)
        {
            t.DisplayTaskString();
        }
    }

    public Task ChooseToRecord()
    {
        ListUserTasks();
        int index = GetCompletedTask();
        Task record = _userTasks[index];  
        return record;      
    }

    public int GetCompletedTask()
        {
            Console.Write("Which goal did you accomplish? ");
            int response = Convert.ToInt32(Console.ReadLine());
            return response-1;
        }


}