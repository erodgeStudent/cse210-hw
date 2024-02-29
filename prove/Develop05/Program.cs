using System;

class Program
{  
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Eternal Quest!\n");
        var running = "yes";
        do {
            // Console.WriteLine($"You have {_points} points.\n");
            List<Goal> goals = new List<Goal>();

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
                            Console.Write("What is the name of your goal? ");
                            var name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            var description = Console.ReadLine();
                            Console.Write("How many point is this goal worth? ");
                            int points = Convert.ToInt32(Console.ReadLine());
                            SimpleGoal simple = new SimpleGoal(name, description, points);
                            goals.Add(simple);

                            break;
                        case 2:
                            //eternal
                            Console.WriteLine("Inside eternal");
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("How many point is this goal worth? ");
                            points = Convert.ToInt32(Console.ReadLine());
                            EternalGoal eternalGoal = new EternalGoal(name, description, points);
                            goals.Add(eternalGoal);
                            break;
                        case 3:
                            //checklist
                            Console.WriteLine("Inside checklist");
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("How many point is this goal worth? ");
                            points = Convert.ToInt32(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            var bonusCount = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            var bonusPoints = Convert.ToInt32(Console.ReadLine());
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonusCount, bonusPoints);
                            goals.Add(checklistGoal);
                            return;
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
        //         case 6:
        //             //quit
        //             Console.Write("Are you sure you want to quit? (y/n) ");
        //             var quit = Console.ReadLine();
        //             if (quit == "y"){
        //                 running = "no";
        //             }
        //             else{
        //                 return;
        //             }
        //             break;
                default:
                    break;
            }
        } while (running == "yes");
    }
}