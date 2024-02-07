using System;
using System.Net;
using static Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer!");
        
        Reference reference = new Reference();
        var rf = reference.GetReferenceWithEndVal();

        Text text = new Text();
        var scriptureTxt = text.GetScriptTxt();
        
        Scripture scripture = new Scripture(rf, scriptureTxt);
        scripture.Display();
        string running ="yes";
     
        Scripture s = new Scripture(rf, scriptureTxt);
        Console.WriteLine(s.Display());
        
        do{
            

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string response = Console.ReadLine();
            
            switch (response)
            {
                case "":
                    running = "yes";
                    Console.Clear();
                    //need to get the word changed and call display again.
                    scripture.Display();
                    break;
                    
                case "quit":
                    running = "no";
                    break;
                
                default:
                    Console.WriteLine("Try your response again");
                    break;
            }
        }
        while( running =="yes");
    }
}