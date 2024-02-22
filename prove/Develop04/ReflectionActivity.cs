using System;
using System.Collections;
public class ReflectionActivity : Activity
{

    //ATTRIBUTES
    // private string _prompt;
    // private string _question;

    public List<string> _questionsList = new List<string>()
    {
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "What lesson have you learned from this experience?",
        "Would you have done anything differently?"
    };

    //CONSTRUCTOR
    public ReflectionActivity(string msg, string dscrpt, int secs, int time) : base(msg, dscrpt, secs, time)
    {
    }

    // //METHODS


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
        Console.Write($"> {question}");
        Thread.Sleep(time);
    }

}      
    
