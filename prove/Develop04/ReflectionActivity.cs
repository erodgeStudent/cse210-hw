using System;
using System.Collections;
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

    
    public List<string> _questionsList = new List<string>()
    {
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "What lesson have you learned from this experience?",
        "Would you have done anything differently?"
    };

    //CONSTRUCTOR
    public ReflectionActivity(string msg, string dscrpt, int secs) : base(msg, dscrpt, secs)
    {
        _totalReflecting =+ secs; 
    }

    // //METHODS
    public string GetRandomPrompt()
    {
        Random r = new Random();
        Stack<string> _stackPrompt = new Stack<string>();
        foreach(string s in _promptList.OrderBy(x => r.Next()))
        {
            _stackPrompt.Push(s);
        }
        string prompt = _stackPrompt.Pop();
        return prompt;
    }

    public string GenerateQuestions()
    {
        Random r = new Random();
        Stack<string> _stackQ = new Stack<string>();
        List<string> twoQuestions = new List<string>();
        foreach(string s in _questionsList.OrderBy(x => r.Next()))
        {
            _stackQ.Push(s);
        }
        // for (int i = 2; i > 0; i--)
        // {
        //     string question = _stackQ.Pop();
        //     twoQuestions.Add(question);
        // }
        string question = _stackQ.Pop();
        
        return question;
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---{prompt}---");
    }

    public void DisplayQuestions(string question, int time)
    {   
        Console.Write($">{question}");
        Thread.Sleep(time);
    }

        public string GetReflectingSummary(int time, string activity)
    {
        return $"\n\nYou have completed another {time} seconds of the {activity}";
    }

        public int GetTotalReflectingTime()
    {
        return _totalReflecting;
    }
}      
    
