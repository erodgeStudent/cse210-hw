using System;

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
            Console.WriteLine("Menu Options:");
            foreach (string option in _menuOptions)
            {
                Console.WriteLine(option);
            }
        }

        public int GetResponse(){
            Console.Write("Select a choice from the menu: ");
            int response = Convert.ToInt32(Console.ReadLine());
            return response;
        }

        public void DisplayGoalMenu(){
            foreach (string goal in _goalOptions)
            {
                Console.WriteLine(goal);
            }
            Console.WriteLine("");
        }

}