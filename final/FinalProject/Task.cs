using System;
using System.Dynamic;
using System.Globalization;

public class Task{
    private string _name;
    private int _pointVal;
    private bool _complete = false;

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

    public virtual List<Task> AddNewTask(Child c)
    {   
        Console.WriteLine("inside add new task");
        var lst = c._userTasks;
        Console.WriteLine("Enter task name: ");
        string name = Console.ReadLine();
        Console.WriteLine("How many points is this worth? ");
        int pointVal = Convert.ToInt32(Console.ReadLine());
        Task newTask = new Task(name, pointVal);
        lst.Add(newTask);
        return lst;
    }

    // public void ListUserTasks(Child c)
    // {   
    //     Console.WriteLine("inside list usertasks");
    //     var lst = c._userTasks;
    //     foreach (Task t in lst)
    //     {
    //         t.DisplayTaskString();
    //     }
    // }

    public void DisplayTaskString()
    {
        var name = GetName();
        var pVal = GetPointVal();
        var complete = CheckIsComplete();
        var check = "[ ]";
        if (complete == true)
        {check = "[X]"; }
        Console.WriteLine($">> {check} : {name} is worth {pVal} points.");
    }

    public virtual string SaveStringInFile()
    {
        var name = GetName();
        var points = GetPointVal();
        return $"{name}:{points}";
    }

    public virtual void SetFrequency(){
        //start timer over at 9 am every day.
        DateTime tomorrowAtNineAM = DateTime.Now.AddDays(1).AddHours(9);
        DateTime currentTime = DateTime.Now;
    }

    public virtual bool CheckIsComplete()
    {
        return _complete;
    }

    public virtual void CheckOffTask()
    {
        _complete = true;
    }

}