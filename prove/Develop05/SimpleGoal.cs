using System;

public class SimpleGoal : Goal {
    private string _name;
    private string _description;
    private int _points;
    private int _totalPoints;
    private bool _complete= false;
    private bool _isEternal;

    public SimpleGoal(string name, string description, int points, bool isEternal) : base (name, description, points)
    {
        _isEternal = false;
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
        var eternal = _isEternal;
        return $"{GetType()}:{name}~{description}~{points}~{eternal}";
    }

    public override void CreateGoalFromFile(string stringrepresentation, List<Goal> lst)
    {
        string [] strArray = stringrepresentation.Split("~");
        SimpleGoal simple = new SimpleGoal("", "", 0, false)
        {
                _name = strArray[1],
                _description = strArray[2],
                _points = Convert.ToInt32(strArray[3])
        };
        lst.Add(simple);
    }

}