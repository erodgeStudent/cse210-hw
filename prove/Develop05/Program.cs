using System;
using System.Security.Cryptography.X509Certificates;

class Program
{  
    
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
        GoalFile file = new GoalFile();
        Console.WriteLine("Welcome to Eternal Quest!\n");
        var running = "yes";
        do {
            Goal goal = new Goal("","",0);
            var totalPoints = file.GetTotalPoints();
            Console.WriteLine($"You have {totalPoints} points.");
            

            Menu menu = new Menu();
            menu.DisplayMenu();
            int response = menu.GetResponse();
            
            
            switch (response){
                case 1:
                    menu.DisplayGoalMenu();
                    int goalResponse = menu.GetResponse();
                    switch (goalResponse)
                    {
                        case 1:
                            SimpleGoal simple = menu.CreateSimple();
                            _goals.Add(simple);
                            break;
                        case 2:
                            EternalGoal eternalGoal = menu.CreateEternal();
                            _goals.Add(eternalGoal);
                            break;
                        case 3:
                            ChecklistGoal checklistGoal = menu.CreateChecklist();
                            _goals.Add(checklistGoal);
                            break;
                        default:
                            Console.WriteLine("Enter an option from the list.");
                            break;
                    }
                    break;
                case 2:
                    file.DisplayAll(_goals);
                    break;
                case 3:
                    var lst = file.CollectGoalsToSave(_goals);
                    file.Save(lst);
                    
                    break;
                case 4:
                    //load
                    file.Load(_goals);
                    break;
                case 5:
                    int i = menu.RecordGoalMenu(_goals);
                    Goal recordIt = goal.GetGoalByIndex(i, _goals);
                    int addPoints = recordIt.RecordEvent();
                    file.SetTotalPoints(addPoints);
                    break;
                case 6:
                    //quit
                    running = file.QuitProgram();
                    break;
                default:
                    break;
            }
        } while (running == "yes");
    }
}