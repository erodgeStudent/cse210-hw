using System;

public class SimpleGoal : Goal {

    private bool _complete;

    public SimpleGoal(string name, string description, int points, bool complete) : base (name, description, points)
    {
        _complete = complete;
    }

    public void Completed()
    {
        _complete = true;
    }
    
        public override void DisplayGoal()
    {
        
        base.DisplayGoal();
    }

    public override int RecordEvent()
    {
        int points = GetPoints();
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Completed();
        return points;
    }

    public override string GetStringRepresentation()
    {
        var name = GetName();
        var description = GetDescription();
        var points = GetPoints();
        var complete = CheckIsComplete();
        return $"{GetType()}:{name}~{description}~{points}~{complete}";
    }

}