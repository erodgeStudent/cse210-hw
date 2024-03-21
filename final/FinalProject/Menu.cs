using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class Menu{

    public List<string> _menuOptions = new List<string>(){
        "Add New Task",
        "Record Task Complete",
        "View Your Tasks",
        "Save",
        "Quit"
    };

    public Menu(){}

    public Child Login(List<Child> lst)
    {
        Console.WriteLine("\nSelect a user.");
        int count = 1;
        foreach (Child option in lst)
        {
            Console.WriteLine($"\t{count}. {option.GetName()}");
            count ++;
        }
        var userChoice = Convert.ToInt32(Console.ReadLine());
        int i = userChoice-1;
        Child child = lst[i];
        var p = Convert.ToString(child.GetPassword());
        switch (userChoice)
        {
            case 1:
                PasswordLogin(child, p);
                break;
            case 2:
                PasswordLogin(child, p);
                break;
            case 3:
                PasswordLogin(child, p);
                break;
            case 4:
                PasswordLogin(child, p);
                break;
            default:

                Console.WriteLine("Error. Try again.");
                break;
        }
        return child;
    }

    public Child PasswordLogin(Child c, string password){
        var correct = false;
        do{
            
            Console.WriteLine(password);
        Console.WriteLine("Enter your password");
        string input = Console.ReadLine();
        
        if (input == password){
            c.IsLoggedIn();
            Console.WriteLine($"Welcome, {c.GetName()}!");
            correct = true;
        } else {
            Console.WriteLine("Error. Try again.");
            correct = false;
        }
        } while ( correct == false);
        return c;
    }
    public void DisplayOptions(Child c)
    {   
            var count = 1;
            Console.WriteLine("What would you like to do?.\n");
            foreach (string option in _menuOptions)
            {
                Console.WriteLine($"\t{count}. {option}");
                count ++;
            }
    }

    public enum _taskOptions
    {
        Single,
        Daily,
        Weekly
    };

    public Task ChooseTask()
    {   
        Task task1 = new Task("", 0);
        Console.WriteLine("Enter task name: ");
        string name = Console.ReadLine();
        Console.WriteLine("How many points is this worth? ");
        int pointVal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Which type of task is it?");
        var count = 1;
        foreach (int i in Enum.GetValues(typeof(_taskOptions)))
        {
            Console.WriteLine($"{count}. {i}");
            count ++;
        }
        var num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 1:
                task1 = new Single(name, pointVal);
                break;
            case 2:
                task1 = new Daily(name, pointVal);
                break;
            case 3:
                task1 = new Weekly(name, pointVal);
                break;
            default:
                Console.WriteLine("Error. Try again");
                break;
        }
        return task1;
    }

}