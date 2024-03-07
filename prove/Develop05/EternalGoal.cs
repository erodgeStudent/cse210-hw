using System;

public class EternalGoal : Goal {


    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {

    }

        public override void DisplayGoal()
    {
        base.DisplayGoal();
    }

    public override string GetStringRepresentation()
    {
        var name = GetName();
        var description = GetDescription();
        var points = GetPoints();
        return $"{GetType()}:{name}~{description}~{points}";
    }

        public override int RecordEvent()
    {   
        int points = GetPoints();
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        return points;
    }

}