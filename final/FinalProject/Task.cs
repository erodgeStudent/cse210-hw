using System;

public class Task{
    private string _name;
    private int _pointVal;

    public List<Task> _allTasks = new List<Task>();

    public Task(string name, int pointVal){
        _name = name;
        _pointVal = pointVal;
    }
}