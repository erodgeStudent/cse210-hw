using System;
using System.IO;
public class Journal
{
    
    public List<Entry> _entries = new List<Entry>();
    public string _filename;

    //----------------------METHODS---------------------------------
    public void AddNewEntry(){
        Console.WriteLine("inside Addnew entry");
        Entry _newEntry = new Entry();
        _entries.Add(_newEntry);
    }

    public void SaveJournal()
    {
        Console.WriteLine("inside save journal");
        Console.WriteLine("What is the filename?");
        this._filename = Console.ReadLine();
        //if file already exists, add new lines.
        if (File.Exists(this._filename)) 
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);
            using (StreamWriter outputFile = new StreamWriter(this._filename))
            {
                foreach (string ln in lines)
                {
                    Console.WriteLine(ln);
                    outputFile.WriteLine(ln);
                }
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._entryDate} {entry._userText}~~");
                    outputFile.WriteLine("");
                }

            }
            
        }
        else {
        //if file is new, create new file. 
        using (StreamWriter outputFile = new StreamWriter(this._filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._entryDate} {entry._userText}~~");
                outputFile.WriteLine("");
            }
        }  
        }
    }

    public void LoadJournal()
    {
        Console.WriteLine("inside load journal");
        Console.WriteLine("What is the file name?");
        this._filename = Console.ReadLine();
        //check if file exists
        if (File.Exists(this._filename)) 
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);
            using (StreamWriter outputFile = new StreamWriter(this._filename))
            {
                foreach (string ln in lines)
                {
                    Console.WriteLine(ln);
                    outputFile.WriteLine(ln);
                }
            }
            
        } else {
            Console.WriteLine("\nThis file does not exist, please try again.");
            return;
        }
        

    }

    public void DisplayJournal()
    {
        Console.WriteLine("inside display journal");
        Console.WriteLine($"\nMy Journal Entries:");
            foreach (Entry entry in _entries )
            {
                entry.DisplayEntry();
            }
        
    }

    public void QuitJournal()
    {
        Console.WriteLine("inside quit journal");
        Console.WriteLine("Are you sure you want to quit? (y/n)");
        string res = Console.ReadLine();
        if (res == "y")
        {
            System.Environment.Exit(0);
        }
        else
        {
            return;
        }
    }

}