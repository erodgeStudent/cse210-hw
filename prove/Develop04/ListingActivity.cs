using System;
public class ListingActivity : Activity
{
    private int _totalListing;
    
    public ListingActivity(string msg, string dscrpt, int secs) : base(msg, dscrpt, secs)
    {
        _totalListing =+ secs; 
    }

    public void DisplayListingPrompt(string prompt)
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"---{prompt}---");
    }


    public string GatherUserResponse(int time)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(time);
        List<string> userList = new List<string>();

        while (DateTime.Now < endTime)
        {   
            Console.Write("> ");
            var i = Console.ReadLine();
            userList.Add(i);
        }
        return $"You listed {userList.Count} items.";
    }

    public string GetListingSummary(int time, string activity)
    {
        return $"\n\nYou have completed another {time} seconds of the {activity}";
    }

    public int GetTotalListingTime()
    {
        return _totalListing;
    }

}