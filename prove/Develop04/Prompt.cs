public class Prompt{


    private static List<string> _promptList = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    }; 


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
}

 