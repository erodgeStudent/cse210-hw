using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

public class Menu
{
    
    private static List<string> _menuOptions = new List<string>()
        {
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit"
        };

        private static List<string> _goalOptions = new List<string>()
        {
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"
        };


        public void DisplayMenu(){
            Console.WriteLine("\nMenu Options: ");
            foreach (string option in _menuOptions)
            {
                Console.WriteLine(option);
            }
            Console.WriteLine();
        }



        public int GetResponse(){
            Console.Write("Select a choice from the menu: ");
            int response = Convert.ToInt32(Console.ReadLine());
            return response;
        }

        public SimpleGoal CreateSimple()
        {
            Console.Write("What is the name of your goal? ");
            var name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            var description = Console.ReadLine();
            Console.Write("How many point is this goal worth? ");
            int points = Convert.ToInt32(Console.ReadLine());
            return new SimpleGoal(name, description, points, false);
        }

        public EternalGoal CreateEternal()
        {
            Console.Write("What is the name of your goal? ");
            var name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            var description = Console.ReadLine();
            Console.Write("How many point is this goal worth? ");
            var points = Convert.ToInt32(Console.ReadLine());
            return new EternalGoal(name, description, points);
        }

        public ChecklistGoal CreateChecklist()
        {
            Console.Write("What is the name of your goal? ");
            var name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            var description = Console.ReadLine();
            Console.Write("How many point is this goal worth? ");
            var points = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            var bonusTotalCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            var bonusPoints = Convert.ToInt32(Console.ReadLine());
            var currentBonus = 0;
            return new ChecklistGoal(name, description, points, bonusPoints, bonusTotalCount,  currentBonus);
        }

        public void DisplayGoalMenu(){
            foreach (string goal in _goalOptions)
            {
                Console.WriteLine(goal);
            }
            Console.WriteLine("");
        }
//--------------------------------------------------
//choose all the goals available to record event
        public int RecordGoalMenu(List<Goal> lst)
        {
            DisplayGoalsToRecord(lst);
            int index = RecordResponse();
            return index;
        }
        
        public void DisplayGoalsToRecord(List<Goal> lst){
            int count = 1;
                foreach (Goal g in lst)
                {
                        Console.WriteLine($"{count}. {g.GetName()}");
                        count++;
                    
                }
        }

        public int RecordResponse()
        {
            Console.Write("Which goal did you accomplish? ");
            int response = Convert.ToInt32(Console.ReadLine());
            return response-1;
        }

}