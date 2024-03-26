using System;
using System.Drawing;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ObjectiveC;
using System.Linq;
using System.Collections;
using System.Security.Cryptography;

class TaskFile{

    private int _totalUserPts;

    public void Save(List<string> lst, Child c){
        var filename = $"{c.SaveFile()}.txt";
        var points = c.GetPoints();
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            outputfile.WriteLine(points);
            foreach (string task in lst)
            {   
                outputfile.WriteLine(task);
            }
        }
        Console.WriteLine("");
    }

    public int GetTotalUserPts()
    {
        return _totalUserPts;
    }

    public void SetTotalUserPts(int pts)
    {
        _totalUserPts += pts;
    }

    public void Load(Child c)
    {   
        // Console.Clear();
        var filename = $"{c.SaveFile()}.txt";
        var lst = c._userTasks;
        if (!File.Exists(filename))
        {
            List<string> personalTasks = c.GetTasks();
            Save(personalTasks, c);
        }
        int points = Convert.ToInt32(File.ReadLines(filename).First());
        _totalUserPts = points;
        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(points);
            foreach (string ln in lines)
            {
                CreateTask(ln, lst);
                outputFile.WriteLine(ln);
            }
        }
    }

    public void CreateTask(string stringSave, List<Task> lst)
    {
        Task task = new Task("",0,false);
        string[] strArray = stringSave.Split("=");
        string type = strArray[0];
        string[] paramArray = strArray[1].Split(":");
        string name = paramArray[0];
        int points = Convert.ToInt32(paramArray[1]);
        bool complete = Convert.ToBoolean(paramArray[2]);
        
        Task uploaded = task.DetermineTask(type, name, points, complete);
        if (complete == true)
        {
            uploaded.CheckOffTask();
        }
        Console.WriteLine($"CreateTask: {complete}");
        lst.Add(uploaded);
    }
}