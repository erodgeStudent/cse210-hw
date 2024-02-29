using System;

public class ChecklistGoal : Goal {

    private int _bonusCount;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, int bonusCount, int bonusPoints) : base (name, description, points)
    {
        _bonusCount = bonusCount;
        _bonusPoints = bonusPoints;
    }
}