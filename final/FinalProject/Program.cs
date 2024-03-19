using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello FinalProject World!");
        Primary max = new Primary(5, "Max", 1, 1, "MaxoRama5", false);
        Primary milo = new Primary(7, "Milo", 2, 2, "MiloMan7", false);
        Elementary roman = new Elementary(9, "Roman", 3, 3, 2, "RowRow9", false);
        Middle bane = new Middle(11, "Bane", 4, 4, 5, "Baniac11", false);
        Task task = new Task("",0);
        TaskFile file = new TaskFile();
        List<Child> _children = [max, milo, roman, bane];
        Menu menu = new Menu();
        Child user = menu.Login(_children);
        file.Load(user);
        var running = "yes";
        do{
            menu.DisplayOptions(user);
            
            Console.Write("\nChoose an option.");
            var choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //add new task
                    task.AddNewTask(user);
                    break;
                case 2:
                    //record task complete
                    Console.WriteLine("Write record task methods.");
                    break;
                case 3:
                    // list your tasks.
                    // task.ListUserTasks(user);
                    List<Task> lst = user._userTasks;
                    foreach (Task t in lst)
                    {
                        t.DisplayTaskString();
                    }
                    break;
                case 4:
                    //save file
                    List<string> personalTasks = user.GetTasks();
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
                    Console.WriteLine("Try again.");
                    break;
            }
        } while (running == "yes");







    }
}