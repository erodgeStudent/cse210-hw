using System;

public class ChecklistGoal : Goal {

    private int _bonusTotalCount;
    private int _currentBonus = 0;
    private int _bonusPoints;
    private bool _complete= false;
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
        var name = GetName();
        var description = GetDescription();
        var points = GetPoints();
        var bonusPoints = GetBonusPoints();
        var bonusTotalCount = GetBonusTotalCount();
        var currentBonus = GetCurrentBonus();
        return $"{GetType()}:{name}~{description}~{points}~{bonusPoints}~{bonusTotalCount}~{currentBonus}";
    }

    public override void CreateGoalFromFile(string stringrepresentation, List<Goal> lst)
    {
        string [] strArray = stringrepresentation.Split(":");
        string[] paramArray = strArray[1].Split("~");
        // var goalType = strArray[0];
        ChecklistGoal checklist = new ChecklistGoal("","",0,0,0,0);
                {
                    _name = paramArray[0];
                    _description = paramArray[1];
                    _points = Convert.ToInt32(paramArray[2]);
                    _bonusPoints = Convert.ToInt32(paramArray[3]);
                    _bonusTotalCount = Convert.ToInt32(paramArray[4]);
                    _currentBonus = Convert.ToInt32(paramArray[5]);
                }
        lst.Add(checklist);
    }

}