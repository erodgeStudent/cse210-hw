using System;

public class ChecklistGoal : Goal {

    private int _bonusTotalCount;
    private int _currentBonus = 0;
    private int _bonusPoints;
    private bool _complete;
    private string _name;
    private string _description;
    private int _points;
    public ChecklistGoal(string name, string description, int points, int bonusPoints, int bonusTotalCount, int currentBonus) : base (name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _bonusPoints = bonusPoints;
        _bonusTotalCount = bonusTotalCount;
        _currentBonus = currentBonus;
    }

    public override void DisplayGoal()
    {
        if (CheckIsComplete() == true)
        {
            _complete = true;
        }
        _currentBonus = GetCurrentBonus();
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

    public int AddCurrentBonus()
    {
        _currentBonus += 1;
        return _currentBonus;
    }

    public override string GetStringRepresentation()
    {
        var name = GetName();
        var description = GetDescription();
        var points = GetPoints();
        var bonusPoints = GetBonusPoints();
        var bonusTotalCount = GetBonusTotalCount();
        var currentBonus = GetCurrentBonus();
        return $"{GetType()}:{name}~{description}~{points}~{bonusPoints}~{bonusTotalCount}~{currentBonus}";
    }

    public override int RecordEvent()
    {
        int points = GetPoints();
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        AddCurrentBonus();
        if (_currentBonus == _bonusTotalCount){
            points += _bonusPoints;
            Completed();
        } 

        
        return points;
    }

}