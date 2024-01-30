using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Prompt
{
    
    public static List<string> _prompts = new List<string>()
        {
            "What made you laugh today?",
            "Describe a place/time where you felt happiest",
            "What is something you were proud of today?",
            "Describe a small act of kindness you witness or performed recently.",
            "When were you challenged today? What did you learn from it?",
            "Describe when you had some time to yourself. What did you choose to do?",
            "What is something you look forward to this week?",
            "When did you feel the Spirit today?",
            "What was something that stood out to you during scripture study?"
        };
    
    public static string GenerateRandPrompt(){
        Random rnd = new Random();
        int i = rnd.Next(_prompts.Count);
        var prompt = _prompts[i]; 
        return prompt;
    }

}