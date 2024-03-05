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

    public override int RecordEvent()
    {
        return base.RecordEvent();
    }

    public override string GetStringRepresentation(Goal goal)
    {
        return base.GetStringRepresentation(goal);
    }


}