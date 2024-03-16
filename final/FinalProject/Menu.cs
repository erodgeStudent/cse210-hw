using System;
using System.Security.Cryptography;

public class Menu{

    enum MenuOptions
    {
        Add=1,
        Record,
        View,
        Quit
    }

    public Menu(){}

    public void Login(List<Child> lst)
    {
        Console.WriteLine("\nSelect a user.");
        int count = 1;
        foreach (Child option in lst)
        {
            Console.WriteLine($"\t{count}. {option}");
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

    }

    public void PasswordLogin(Child c, string password){
        var correct = false;
        do{
            
            Console.WriteLine(password);
        Console.WriteLine("Enter your password");
        string input = Console.ReadLine();
        
        if (input == password){
            c.IsLoggedIn();
            correct = true;
            Console.WriteLine("true");
        } else {
            Console.WriteLine("Error. Try again.");
            correct = false;
        }
        } while ( correct == false);
        
    }
    public void DisplayOptions()
    {   
        var count = 1;
        Console.Write("Choose an option.");
        foreach (string option in Enum.GetNames(typeof(MenuOptions)))
        {
            Console.WriteLine($"\t{count}. {option}");
            count ++;
        }

        Console.WriteLine("\nChoose an option.");
        var choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
            //add new task
            break;
            case 2:
            //record task complete
            break;
            case 3:
            //view list of tasks
            break;
            case 4:
            //Quit
            break;
            default:
            //Try again.
            break;
        }
    }


}