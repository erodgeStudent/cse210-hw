using System;

public class Utils
{
    public void DisplayAll(List<Goal> lst)
    {   
        Console.WriteLine("\nYour goals are:");
        foreach (Goal g in lst)
        {
            g.DisplayGoal();
        }
    }

    
}