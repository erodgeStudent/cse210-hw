using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello FinalProject World!");
        Primary max = new Primary(5, "Max", "MaxoRama5", false);
        Primary milo = new Primary(7, "Milo", "MiloMan7", false);
        Elementary roman = new Elementary(9, "Roman", "RowRow9", false);
        Middle bane = new Middle(11, "Bane", "Baniac11", false);
        Task task = new Task("",0, false);
        TaskFile file = new TaskFile();
        List<Child> _children = [max, milo, roman, bane];
        Menu menu = new Menu();
        Child user = menu.Login(_children);
        file.Load(user);
        var running = "yes";
        do{
            int points = file.GetTotalUserPts();
            Console.WriteLine($"Great job! You have {points} points.");
            menu.DisplayOptions(user);
            
            Console.Write("\nChoose an option.");
            var choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //add new task
                    Task task1 = new Task("",0, false);
                    task1 = menu.ChooseTaskType();
                    user.AddTask(task1);
                    break;
                case 2:
                    //record task complete
                    Task task2 = user.ChooseToRecord();
                    int newPoints = task2.RecordCompletedTask();
                    user.AddUserPoints(newPoints);
                    break;
                case 3:
                    // list your tasks.
                    user.ListUserTasks();
                    break;
                case 4:
                    //save file
                    List<string> personalTasks = user.GetTasks();
                    file.Save(personalTasks, user);
                    break;
                case 5:
                    //Quit
                    points = user.GetPoints();
                    Console.WriteLine($"Great job! You have {points}");
                    Console.WriteLine("Are you sure you want to quit? y/n");
                    string response = Convert.ToString(Console.Read());
                    if (response == "y")
                        {
                            running = "no";
                        }
                    else{
                        Console.WriteLine("Try again.");
                    }
                    break;
                default:
                    Console.WriteLine("Try again.");
                    break;
            }
        } while (running == "yes");
    }
}