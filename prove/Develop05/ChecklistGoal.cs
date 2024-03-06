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

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public int GetCurrentBonus()
    {
        return _currentBonus;
    }

    public int GetBonusTotalCount()
    {
        return _bonusTotalCount;
    }

    public override string GetStringRepresentation()
    {
        var objType = GetType();
        var name = GetName();
        var description = GetDescription();
        var points = GetPoints();
        var bonusPoints = GetBonusPoints();
        var bonusTotalCount = GetBonusTotalCount();
        var currentBonus = GetCurrentBonus();
        string saveString = $"{objType}~{name}~{description}~{points}~{bonusPoints}~{bonusTotalCount}~{currentBonus}";
        return saveString;
    }
}