using System;

public class BreathingActivity : Activity
{   
    private int _totalBreathing;
    
    public BreathingActivity(string msg, string dscrpt, int secs) : base(msg, dscrpt, secs)
    {
        _totalBreathing =+ secs;
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

    public string GetBreathingSummary(int time, string activity)
    {
        return $"\n\nYou have completed another {time} seconds of the {activity}";
    }

    public int GetTotalBreathingTime()
    {
        return _totalBreathing;
    }
}