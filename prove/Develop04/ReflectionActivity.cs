using System;
public class ReflectionActivity : Activity
{

        //ATTRIBUTES
        // private string _prompt;
        // private string _question;
        private int _totalReflecting;
        // private List<string> _promptList;
        // private List<string> _questionsList;

        //CONSTRUCTOR
        public ReflectionActivity(string msg, string dscrpt, int secs) : base(msg, dscrpt, secs)
        {
           _totalReflecting =+ secs; 
        }

        // //METHODS
        // public void GetRandomPrompt()
        // {
        //     Console.WriteLine("Random Prompt Here");
        // }

        // public void GetQuestions(){
        //     Console.WriteLine("Random Questions About Prompt");
        // }

        public void DisplayPrompt()
        {
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"---prompt---");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            var ready = Console.ReadLine();
            switch (ready)
            {
                case "":
                    Console.WriteLine("Ready for next step");
                    break;
                default:
                    Console.WriteLine("Were you ready? Try pressing Enter again.");
                    break;
            }
        }

        // public string DisplayQuestions()
        // {
        //     Console.WriteLine("Display Prompt Questions Here");
        // }
        
    
}