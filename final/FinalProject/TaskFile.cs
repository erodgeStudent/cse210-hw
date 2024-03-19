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
        if(!File.Exists(filename))
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (string task in lst)
            {   
                Console.WriteLine(task);
                outputfile.WriteLine(task);
            }
        }
    }

    public void Load(List<Task> lst, Child c)
    {
        var filename = $"{c.SaveFile()}.txt";
        if (File.Exists(filename)){
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
        string [] strArray = stringSave.Split(":");
        string name = strArray[0];
        int points = Convert.ToInt32(strArray[1]);
        Task task = new Task(name, points);
        lst.Add(task);
    }
}