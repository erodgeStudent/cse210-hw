using System;

public class Task{
    private string _name;
    private int _pointVal;

    public List<Task> _allTasks = new List<Task>();

    public Task(string name, int pointVal){
        _name = name;
        _pointVal = pointVal;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPointVal()
    {
        return _pointVal;
    }

    public List<Task> AddNewTask(List<Task> lst)
    {
        Console.WriteLine("Enter task name: ");
        string name = Console.ReadLine();
        Console.WriteLine("How many points is this worth? ");
        int pointVal = Convert.ToInt32(Console.ReadLine());
        Task newTask = new Task(name, pointVal);
        lst.Add(newTask);
        return lst;
    }

    public void ListUserTasks(List<Task> lst)
    {
        foreach (Task t in lst)
        {
            t.DisplayTaskString();
        }
    }

    public void DisplayTaskString()
    {
        var name = GetName();
        var pVal = GetPointVal();
        Console.WriteLine($">>{name} is worth {pVal} points.");
    }

        public string SaveStringInFile()
    {
        var name = GetName();
        var points = GetPointVal();
        return $"{name}:{points}";
    }

}