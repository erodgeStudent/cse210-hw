using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello FinalProject World!");
        var running = "yes";
        List<Child> _children = new List<Child>();
        Task task = new Task("",0, false);
        TaskFile file = new TaskFile();
        UserFile userFile = new UserFile();
        //previously loaded children
        userFile.Load(_children);
        do{
            Menu menu = new Menu();
            Child child = new Child("","", false);
            int input = menu.StartMenu();
            if (input == 1)
            {
                //add new user
                Child newUser = child.DetermineAge();
                _children.Add(newUser);} 
            else if (input ==2)
            {
                //login as existing
                if (_children.Count >= 1)
                {
                    Child user = child.ListAllChildren(_children);
                    user.PasswordLogin();
                    var loggedIn = "true";
                    do{
                        file.Load(user);
                        int points = file.GetTotalUserPts();
                        Console.WriteLine($"Great job! You have {points} points.");
                        menu.DisplayOptions();
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
                                //logout of user and return to menu
                                List<string> quitpersonalTasks = user.GetTasks();
                                file.Save(quitpersonalTasks, user);
                                loggedIn = "false";
                                break;
                            
                            default:
                                Console.WriteLine("Try again.");
                                break;
                        } 
                    }while (loggedIn == "true");
                }
                else {
                    Console.WriteLine("List is empty.");
                }
            }
            else{
                List<string> lst = userFile.CollectUsers(_children);
                userFile.Save(lst);
                running = "no";
            }

        }while (running == "yes");
    }       

}