using System;
using System.Security.Cryptography.X509Certificates;

class Program
{  
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        Console.WriteLine("Welcome to Eternal Quest!\n");
        var running = "yes";
        do {
            // Console.WriteLine($"You have {_points} points.\n");
            

            Menu menu = new Menu();
            menu.DisplayMenu();
            int response = menu.GetResponse();
            switch (response){
                case 1:
                    //create
                    menu.DisplayGoalMenu();
                    int goalResponse = menu.GetResponse();
                    switch (goalResponse)
                    {
                        case 1:
                            //simple
                            SimpleGoal simple = menu.CreateSimple();
                            goals.Add(simple);
                            foreach(Goal g in goals)
                            {
                                g.DisplayGoal();
                            }
                            break;
                        case 2:
                            //eternal
                            EternalGoal eternalGoal = menu.CreateEternal();
                            goals.Add(eternalGoal);
                            foreach(Goal g in goals)
                            {
                                g.DisplayGoal();
                            }
                            break;
                        case 3:
                            //checklist
                            ChecklistGoal checklistGoal = menu.CreateChecklist();
                            goals.Add(checklistGoal);
                            foreach(Goal g in goals)
                            {
                                g.DisplayGoal();
                            }
                            break;
                    }
                    break;
                case 2:
                    //list
                    Console.WriteLine("Inside List");

                    foreach(Goal g in goals)
                    {
                        g.DisplayGoal();
                    }
                    break;
        //         case 3:
        //             //save
        //             Console.WriteLine("Inside Save");
        //             break;
        //         case 4:
        //             //load
        //             Console.WriteLine("Inside Load");
        //             break;
        //         case 5:
        //             //record event
        //             Console.WriteLine("Inside Record");
        //             break;
                case 6:
                    //quit
                    Console.Write("Are you sure you want to quit? (y/n) ");
                    var quit = Console.ReadLine();
                    if (quit == "y"){
                        running = "no";
                    }
                    else{
                        return;
                    }
                    break;
                default:
                    break;
            }
        } while (running == "yes");
    }
}