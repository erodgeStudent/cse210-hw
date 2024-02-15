using System;

class Program
{   
    public static List<string> chooseActivity = new List<string>(){
    "1. Start breathing activity",
    "2. Start reflecting activity",
    "3. Start listing activity",
    "4. Quit"
    };


    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");


        foreach(string a in chooseActivity){
            Console.WriteLine(a);
        }


        Console.WriteLine("Select a choice from the menu:");
    var response = Console.ReadLine();



    switch (response)
    {
        case "1":
            //go to breathing
            var msg = "Breathing Activity.";
            var dscrpt = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
            Console.WriteLine("How much time -in seconds- would you like for your session?");
            var seconds = Convert.ToInt32(Console.ReadLine());
            BreathingActivity ba = new BreathingActivity(msg, dscrpt, seconds);
            Console.WriteLine(ba.GetSummary());
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("Get Ready...");
            ba.PlaySpinner();
            var time = ba.GetTime();
            Console.WriteLine(ba.TimePerBreath(time));
            ba.PlaySpinner();
            Console.WriteLine(ba.GetBreathingSummary(time, msg));
            // var addBT = ba.GetTotalBreathingTime();
            // Log lg = new Log();
            
            break;
        case "2":
        //go to reflecting
            msg = "Reflecting Activity.";
            dscrpt = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            Console.WriteLine("How much time -in seconds- would you like for your session?");
            time = Convert.ToInt32(Console.ReadLine());
            ReflectionActivity ra = new ReflectionActivity(msg, dscrpt, time);
            Console.WriteLine(ra.GetSummary());
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("Get Ready...");
            ra.PlaySpinner();
            ra.DisplayPrompt();

            break;
        case "3":
        //go to listing
            // var msg = "Listing Activity.";
            // var dscrpt = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            // Console.WriteLine("How much time -in seconds- would you like for your session?");
            // var time = Convert.ToInt32(Console.ReadLine());
            // ListingActivity la = new ListingActivity(msg, dscrpt, time);
            break;
        case "4":
            break;
        default :
            Console.WriteLine("Try your response again");
            break;
        
    }
    }
}
