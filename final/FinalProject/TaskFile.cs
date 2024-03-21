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
    public void Save(List<string> lst, Child c){
        Console.WriteLine("Saving your file.");
        var filename = $"{c.SaveFile()}.txt";
        Console.WriteLine(filename);
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (string task in lst)
            {   
                outputfile.WriteLine(task);
            }
        }
        Console.WriteLine("");
    }

    public void Load(Child c)
    {
        var filename = $"{c.SaveFile()}.txt";
        var lst = c._userTasks;
        if (File.Exists(filename)){
            Console.WriteLine("Loading Progress");
            string[] lines = System.IO.File.ReadAllLines(filename);
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (string ln in lines)
                {
                    CreateTask(ln, lst);
                    outputFile.WriteLine(ln);
                }
            }
        }
    }

    public void CreateTask(string stringSave, List<Task> lst)
    {
        Console.WriteLine("inside create task");
        string[] strArray = stringSave.Split("=");
        string[] paramArray = strArray[1].Split(":");
        // string type = strArray[0];
        string name = paramArray[0];
        int points = Convert.ToInt32(paramArray[1]);
        bool complete = Convert.ToBoolean(paramArray[2]);
        Task task = new Task(name, points, complete);
        lst.Add(task);
    }
}