using System;

public class EternalGoal : Goal {
    private int _points;
    private bool _complete = false;

    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {

    }

        public override void DisplayGoal()
    {
        base.DisplayGoal();
    }

    public override int RecordEvent()
    {
        return base.RecordEvent();
    }

    public override string GetStringRepresentation()
    {
        var name = GetName();
        var description = GetDescription();
        var points = GetPoints();
        return $"{GetType()}:{name}~{description}~{points}";
    }

    public override void CreateGoalFromFile(string stringrepresentation, List<Goal> lst)
    {
        base.CreateGoalFromFile(stringrepresentation, lst);
    }
}