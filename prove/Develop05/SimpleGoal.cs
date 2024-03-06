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
        _isEternal = isEternal;
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

    // public override SimpleGoal CreateGoalFromFile(string stringrepresentation, List<Goal> lst)
    // {
    //     string [] strArray = stringrepresentation.Split("~");
    //     var name = strArray[1];
    //     var description = strArray[2];
    //     var points = Convert.ToInt32(strArray[3]);
    //     SimpleGoal simple = new SimpleGoal(name, description, points, false);

    //     lst.Add(simple);
    //     simple.DisplayGoal();
    //     return simple;
    // }

}