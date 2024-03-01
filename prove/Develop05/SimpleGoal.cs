using System;

public class SimpleGoal : Goal {
    private int _points;
    private bool _complete = false;

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {

    }

        public override void DisplayGoal()
    {
        base.DisplayGoal();
    }

        public override void RecordEvent(int points)
    {
        _points = points;
        _complete = true;
    }

    public override string GetStringRepresentation(Goal goal)
    {
        return base.GetStringRepresentation(goal);
    }


}