using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer!");
    //    -------------ORIGINAL SPECS BEGIN 
        Reference reference = new Reference();
        var rf = reference.GetReferenceWithEndVal();

        Text text = new Text();
        var scriptureTxt = text.GetScriptTxt();

        Scripture s = new Scripture(rf, scriptureTxt);
        var running = "yes";
    //    -------------ORIGINAL SPECS END
        Console.WriteLine(s.Display());
        Console.WriteLine("How many words would you like to remove?");
        int num = Convert.ToInt32(Console.ReadLine());
        
        do{
            
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string response = Console.ReadLine();
            
            switch (response)
            {
                case "":
                    running = "yes";
                    Console.Clear();
                    s.HideNext(num);
                    Console.WriteLine(s.Display());
                    bool quit = s.GetCompletelyHidden();
                    if(quit == true) {
                        running = "no";
                        Console.WriteLine("Finished.");
                        break;
                    }
                    break;
                    
                case "quit":
                    running = "no";
                    Console.WriteLine("Finished.");
                    break;
                
                default:
                    Console.WriteLine("Try your response again.");
                    break;
            }
        }
        while( running =="yes");
    }
}