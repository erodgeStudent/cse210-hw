using System;

public class ChecklistGoal : Goal {

    private int _bonusTotalCount;
    private int _currentBonus = 0;
    private int _bonusPoints;
    private bool _complete= false;
    private string _name;
    private string _description;
    private int _points;
    public ChecklistGoal(string name, string description, int points, int bonusTotalCount, int bonusPoints) : base (name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _bonusTotalCount = bonusTotalCount;
        _bonusPoints = bonusPoints;
    }

    public override void DisplayGoal()
    {
        var check = "";
        if (_complete == true)
        {
            check = "[X]";
        }else{
            check = "[ ]";
        }
        Console.WriteLine($"{check} {_name} ({_description}) -- Currently completed: {_currentBonus}/{_bonusTotalCount}");
    }
}