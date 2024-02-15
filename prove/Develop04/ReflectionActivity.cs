using System;
public class ReflectionActivity : Activity
{

        //ATTRIBUTES
        // private string _prompt;
        // private string _question;
        private int _totalReflecting;
        private static List<string> _promptList = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

       
        // private List<string> _questionsList;

        //CONSTRUCTOR
        public ReflectionActivity(string msg, string dscrpt, int secs) : base(msg, dscrpt, secs)
        {
           _totalReflecting =+ secs; 
        }

        // //METHODS
        public string GetRandomPrompt()
        {
            Console.WriteLine("Random Prompt Here");
            Random r = new Random();
            Stack<string> stack = new Stack<string>();
            foreach(string s in _promptList.OrderBy(x => r.Next()))
            {
                stack.Push(s);
            }
            string prompt = stack.Pop();
            return prompt;
        }

        // public void GetQuestions(){
        //     Console.WriteLine("Random Questions About Prompt");
        // }

        public void DisplayPrompt(string prompt)
        {
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"---{prompt}---");
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