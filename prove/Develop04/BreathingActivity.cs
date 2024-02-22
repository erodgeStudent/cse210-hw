using System;

public class BreathingActivity : Activity
{   
    
    public BreathingActivity(string msg, string dscrpt, int secs, int time) : base(msg, dscrpt, secs, time)
    {
    }

    public string TimePerBreath(int secs)
    {
        DateTime startTime = DateTime.Now;
        DateTime timesUp = startTime.AddSeconds(secs);
        while (DateTime.Now < timesUp)
        {
            Console.Write("\n>>Breathe in...");
            for(int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.Write("\n>>Breathe out...");
            for(int i = 5; i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");

        }   
        return "\nFinished. Well Done!";
    }

}