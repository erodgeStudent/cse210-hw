using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello FinalProject World!");
        Primary max = new Primary(5, "Max", 1, 1, "MaxoRama5", false, 15);
        Primary milo = new Primary(7, "Milo", 2, 2, "MiloMan7", false, 15);
        Elementary roman = new Elementary(9, "Roman", 3, 3, 2, "RowRow9", false, 30);
        Middle bane = new Middle(11, "Bane", 4, 4, 5, "Baniac11", false, 50);
        Task task = new Task("",0);
        TaskFile file = new TaskFile();
        List<Child> _children = [max, milo, roman, bane];
        List<Task> _allTasks = new List<Task>();
        Menu menu = new Menu();
        Child user = menu.Login(_children);
        
        var running = "yes";
        do{
            menu.DisplayOptions(user);
            file.Load(_allTasks, user);
            Console.Write("\nChoose an option.");
            var choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //add new task
                    task.AddNewTask(_allTasks);
                    break;
                case 2:
                    //record task complete
                    Console.WriteLine("Write record task methods.");
                    break;
                case 3:
                    // list your tasks.
                    task.ListUserTasks(_allTasks);
                    break;
                case 4:
                    //save file
                    var personalTasks = user.GetTasks(_allTasks);
                    file.Save(personalTasks, user);
                    break;
                case 5:
                    //Quit
                    Console.Write("Are you sure you want to quit? y/n");
                    var response = Convert.ToString(Console.Read());
                    if (response == "y")
                        {
                            running = "no";
                        }
                    else{
                        Console.WriteLine("Try again.");
                    }
                    break;
                default:
                    //Try again.
                    break;
            }
        } while (running == "yes");







    }
}