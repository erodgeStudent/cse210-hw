using System;

class Program
{   
    public static List<string> chooseActivity = new List<string>()
    {
        "1. Start breathing activity",
        "2. Start reflecting activity",
        "3. Start listing activity",
        "4. Quit"
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
        var totalTime = 0;
            var msg = "";
            var dscrpt = "";
            var seconds = 0;
        do
        {
            foreach(string s in chooseActivity)
            {
            Console.WriteLine(s);
            }


            Console.WriteLine("Select a choice from the menu:");
            var response = Console.ReadLine();

            

            Activity a = new Activity(msg, dscrpt, seconds, totalTime);
            switch (response)
            {
                case "1":
                    //go to breathing
                    msg = "Breathing Activity.";
                    dscrpt = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    Console.WriteLine("How much time -in seconds- would you like for your session?");
                    seconds = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    BreathingActivity ba = new BreathingActivity(msg, dscrpt, seconds, totalTime);
                    ba.PlaySpinner();
                    Console.WriteLine(ba.GetDescription());
                    Thread.Sleep(5000);
                    Console.Clear();
                    Thread.Sleep(3000);
                    Console.WriteLine("Get Ready...\n\n");
                    ba.PlaySpinner();
                    Console.WriteLine(ba.TimePerBreath(seconds));
                    ba.PlaySpinner();
                    Console.WriteLine(ba.GetSummary(seconds, msg));
                    Thread.Sleep(5000);
                    var addTime = ba.GetSeconds();
                    var LogTime = a.LogMoreTime(addTime);
                    a.SetTotalTime(LogTime);
                    totalTime = a.GetTotalTime();
                    Console.WriteLine($"add: {addTime} \nTotal: {totalTime}");
                    ba.PlaySpinner();
                    Console.Clear();
                    break;
                case "2":
                    //go to reflecting
                    msg = "Reflecting Activity.";
                    dscrpt = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    Console.WriteLine("How much time -in seconds- would you like for your session?");
                    seconds = Convert.ToInt32(Console.ReadLine());
                    ReflectionActivity ra = new ReflectionActivity(msg, dscrpt, seconds, totalTime);
                    Console.Clear();
                    ra.PlaySpinner();
                    Console.WriteLine(ra.GetDescription());
                    Thread.Sleep(5000);
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
                            var duration = ra.GetSeconds();
                            var half = (duration/2)*1000;
                            DateTime current = DateTime.Now;
                            DateTime end = current.AddSeconds(duration);
                            while (DateTime.Now < end)
                            {
                                var question = ra.GenerateQuestions();
                                ra.DisplayQuestions(question, duration);
                                ra.PlaySpinner();
                                Console.WriteLine("");
                                Thread.Sleep(half);
                            }
                            Console.WriteLine(ra.GetSummary(duration, msg));
                            Thread.Sleep(5000);
                            
                            break;
                        default:
                            Console.WriteLine("Were you ready? Try pressing Enter again.");
                            break;
                    }
                    addTime = ra.GetSeconds();
                    LogTime = a.LogMoreTime(addTime);
                    a.SetTotalTime(LogTime);
                    totalTime = a.GetTotalTime();
                    Console.WriteLine($"add: {addTime} \nTotal: {totalTime}");
                    a.LogMoreTime(addTime);
                    Console.WriteLine(a.LogMoreTime(addTime));
                    // totalTime = a.GetTotalTime();
                    // Console.WriteLine(totalTime);
                    ra.PlaySpinner();
                    Console.Clear();
                    break;
                case "3":
                //go to listing
                    msg = "Listing Activity.";
                    dscrpt = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    Console.WriteLine("How much time -in seconds- would you like for your session?");
                    seconds = Convert.ToInt32(Console.ReadLine());
                    ListingActivity la = new ListingActivity(msg, dscrpt, seconds, totalTime);
                    Console.Clear();
                    Console.WriteLine(la.GetDescription());
                    Thread.Sleep(5000);
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
                    la.GatherUserResponse(seconds);
                    Thread.Sleep(5000);
                    Console.WriteLine(la.GetSummary(seconds, msg));
                    addTime = la.GetSeconds();
                    LogTime = a.LogMoreTime(addTime);
                    a.SetTotalTime(LogTime);
                    totalTime = a.GetTotalTime();
                    Console.WriteLine($"add: {addTime} \nTotal: {totalTime}");
                    Thread.Sleep(5000);
                    la.PlaySpinner();
                    Console.Clear();
                    break;
                case "4":
                    totalTime = a.GetTotalTime();
                    Console.WriteLine(totalTime);
                    Console.WriteLine($"Congratulations! You have completed {totalTime} seconds of Mindfulness today.");
                    running = "no";
                    break;
                default :
                    Console.WriteLine("Try your response again");
                    break;
            }
        

        } while (running == "yes");

    }    
}
