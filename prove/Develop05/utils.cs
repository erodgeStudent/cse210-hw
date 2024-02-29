using System;

public class Utils
{
    public void DisplayAll(List<Goal> lst)
    {
        foreach (Goal g in lst)
        {
            g.DisplayGoal();
        }
    }

    
}