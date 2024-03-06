using System;

public class EternalGoal : Goal {
    private int _points;
    private bool _complete = false;
    private string _name;
    private string _description;

    public EternalGoal(string name, string description, int points) : base (name, description, points)
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

    public override string GetStringRepresentation()
    {
        var name = GetName();
        var description = GetDescription();
        var points = GetPoints();
        return $"{GetType()}:{name}~{description}~{points}";
    }

    // public override EternalGoal CreateGoalFromFile(string stringrepresentation, List<Goal> lst)
    // {
    //     string [] strArray = stringrepresentation.Split(":");
    //         string[] paramArray = strArray[1].Split("~");
    //         //type of goal
    //         var goalType = strArray[0];
    //         //get each param and add new object to list
    //         var name = paramArray[0];
    //         var description = paramArray[1];
    //         var points = Convert.ToInt32(paramArray[2]);
    //         EternalGoal goal = new EternalGoal(name, description, points);
    //         lst.Add(goal);
    //         goal.DisplayGoal();
    //         return goal;
    // }
}