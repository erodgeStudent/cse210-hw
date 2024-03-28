using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class Menu{

    public List<string> _menuOptions = new List<string>(){
        "Add New Task",
        "Record Task Complete",
        "View Your Tasks",
        "Change Password",
        "Logout"
    };

    public Menu(){}

    public int StartMenu()
    {   
        Console.WriteLine("Welcome!");
        Console.WriteLine("1. Add New User");
        Console.WriteLine("2. Login");
        Console.WriteLine("3. Quit");
        Console.Write("Choose an option.");
        int userInput = Convert.ToInt16(Console.ReadLine());
        return userInput;
    }

    
    public void DisplayOptions()
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

    public Task ChooseTaskType()
    {   
        Task task1 = new Task("", 0, false, default);
        Console.WriteLine("Enter task name: ");
        string name = Console.ReadLine();
        Console.WriteLine("How many points is this worth? ");
        int pointVal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Which type of task is it?");
        var count = 1;
        var time = DateTime.Now;
        foreach (string i in Enum.GetNames(typeof(_taskOptions)))
        {
            Console.WriteLine($"{count}. {i}");
            count ++;
        }
        var num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 1:
                task1 = new Single(name, pointVal, false, time);
                break;
            case 2:
                task1 = new Daily(name, pointVal, false, time);
                break;
            case 3:
                task1 = new Weekly(name, pointVal, false, time);
                break;
            default:
                Console.WriteLine("Error. Try again");
                break;
        }
    
        return task1;
    }

}