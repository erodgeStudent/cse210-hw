using System;

class Program
{   
    public static List<string> chooseActivity = new List<string>()
    {
        "1. Start breathing activity",
        "2. Start reflecting activity",
        "3. Start listing activity",
        "4. View Activity Log",
        "5. Quit"
    };

    public static List<string> chooseLog = new List<string>()
    {
        "1. Breathing Log",
        "2. Reflecting Log",
        "3. Listing Log",
        "4. Return to Main Menu"
    };


    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        var running = "yes";
        do
        {
            foreach(string a in chooseActivity)
            {
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
                    Thread.Sleep(3000);
                    Console.WriteLine("Get Ready...\n\n");
                    ba.PlaySpinner();
                    var time = ba.GetTime();
                    Console.WriteLine(ba.TimePerBreath(time));
                    ba.PlaySpinner();
                    Console.WriteLine(ba.GetBreathingSummary(time, msg));
                    var addBT = ba.GetTotalBreathingTime();
                    // Log lg = new Log();
                    // lg.LogMoreTime(addBT);
                    ba.PlaySpinner();
                    Console.Clear();
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
                    Console.WriteLine("Get Ready...\n\n");
                    ra.PlaySpinner();
                    Prompt p = new Prompt();
                    var prompt = p.GetRandomPrompt();
                    ra.DisplayPrompt(prompt);
                    Console.WriteLine("\n\nWhen you have something in mind, press enter to continue.");
                    var ready = Console.ReadLine();
                    
                    switch (ready)
                    {
                        case "":
                            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
                            Thread.Sleep(3000);
                            Console.Write("\n>>You may begin in: ");
                            for(int i = 5; i > 0; i--)
                            {
                                Console.Write(i);
                                Thread.Sleep(1000);
                                Console.Write("\b \b");
                            }
                            Console.Clear();
                            time = ra.GetTime();
                            var half = (time/2)*1000;
                            DateTime current = DateTime.Now;
                            DateTime end = current.AddSeconds(time);
                            while (DateTime.Now < end)
                            {
                                var question = ra.GenerateQuestions();
                                ra.DisplayQuestions(question, time);
                                ra.PlaySpinner();
                                Console.WriteLine("");
                                Thread.Sleep(half);
                            }
                            Console.WriteLine(ra.GetReflectingSummary(time, msg));
                            var addRT = ra.GetTotalReflectingTime();
                            // Log lg = new Log();
                            // lg.LogMoreTime(addRT);
                            break;
                        default:
                            Console.WriteLine("Were you ready? Try pressing Enter again.");
                            break;
                    }
                    ra.PlaySpinner();
                    Console.Clear();
                    break;
                case "3":
                //go to listing
                    msg = "Listing Activity.";
                    dscrpt = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    Console.WriteLine("How much time -in seconds- would you like for your session?");
                    time = Convert.ToInt32(Console.ReadLine());
                    ListingActivity la = new ListingActivity(msg, dscrpt, time);
                    Console.WriteLine(la.GetSummary());
                    Console.Clear();
                    Thread.Sleep(3000);
                    Console.WriteLine("\n\nGet Ready...\n\n");
                    la.PlaySpinner();
                    Prompt newp = new Prompt();
                    var prompt2 = newp.GetRandomPrompt();
                    la.DisplayListingPrompt(prompt2);
                    Console.WriteLine("\n\nGet Ready...");
                    la.PlaySpinner();
                    Thread.Sleep(3000);
                    Console.Write("\n\nYou may begin in ");
                    for(int i = 5; i>0; i--)
                    {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                    }
                    Console.WriteLine("");
                    la.GatherUserResponse(time);
                    Console.WriteLine(la.GetListingSummary(time,msg));
                    Thread.Sleep(3000);
                    la.PlaySpinner();
                    Console.Clear();
                    break;
                case "4":
                    //Go to log
                    Console.WriteLine("Display Log");
                    Console.WriteLine("Which log would you like to view?\n\n");
                    foreach (string s in chooseLog)
                    {
                        Console.WriteLine(s);
                    }
                    var a = Console.ReadLine();
                    var inLogMenu = "yes";
                    do{
                        switch (a)
                        {
                            case "1":
                            Console.WriteLine("Inside view breathing");
                            break;
                            case "2":
                            Console.WriteLine("Inside view reflecting");
                            break;
                            case "3":
                            Console.WriteLine("Inside view listing");
                            break;
                            case "4":
                            Console.WriteLine("Return to Menu");
                            inLogMenu = "no";
                            break;
                        }
                    } while (inLogMenu == "yes");
                    break;
                case "5":
                    running = "no";
                    break;
                default :
                    Console.WriteLine("Try your response again");
                    break;
            }
        

        } while (running == "yes");

    }    
}
