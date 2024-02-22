using System;
public class ListingActivity : Activity
{
    
    public ListingActivity(string msg, string dscrpt, int secs, int time) : base(msg, dscrpt, secs, time)
    {
    }

    public void DisplayListingPrompt(string prompt)
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"---{prompt}---");
    }


    public void GatherUserResponse(int time)
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
        Console.WriteLine($"\nYou listed {userList.Count} items.");
        PlaySpinner();
    }



}