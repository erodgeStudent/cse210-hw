// using System;

//Get ready... 
//Breathe in... countdown
//Now breathe out... countdown
//repeat 4x 
//Finish with Well done!! -- run with spinner.
//You have completed another (time) seconds of the Breathing Activity
public class BreathingActivity : Activity
{
    
    public BreathingActivity(string msg, string dscrpt, int secs) : base(msg, dscrpt, secs)
    {

    }

    public bool TimePerBreath()
    {
        DateTime startTime = DateTime.Now;
        DateTime fiveSeconds = startTime.AddSeconds(5);

        Thread.Sleep(3000);

        for(int i = 0; i < 4; i++){
            Console.WriteLine($"\n\n\nBreathe in...{fiveSeconds - startTime}");
            Thread.Sleep(3000);
        }
        return true;
    }

    public string GetBreathingSummary(int time, string activity)
    {
        return $"You have completed another {time} seconds of the {activity}";
    }
}