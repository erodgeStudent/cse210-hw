using System;

public class EternalGoal : Goal {
    private int _points;
    private bool _complete = false;

    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {

    }
}