using System;

public class Menu
{
    public static List<string> menuOptions = new List<string>()
        {
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit"
        };


        public void DisplayMenu(){
            Console.WriteLine("Menu Options:");
            foreach (string option in menuOptions)
            {
                Console.WriteLine(option);
            }
        }

        public int GetResponse(){
            Console.Write("Select a choice from the menu: ");
            int response = Convert.ToInt32(Console.ReadLine());
            return response;
        }

}