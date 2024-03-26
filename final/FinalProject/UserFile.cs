using System;
using System.Security.Cryptography.X509Certificates;
class UserFile{
    public void Save(List<string> lst)
    {
        var filename = "users.txt";

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            outputfile.WriteLine("Users:");
            foreach (string child in lst)
            {
            outputfile.WriteLine(child);
            }
        }
    }

    public List<string> CollectUsers(List<Child> lst)
    {
        List<string> saveList = new List<string>();
        foreach (Child c in lst)
        {
            var saveString = c.SaveStringInFile();
            saveList.Add(saveString);
        }
        return saveList;
    }

    public void Load(List<Child> lst)
    {
        var filename = "users.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("Users:");
            foreach (string ln in lines)
            {
                CreateChild(ln, lst);
                outputFile.WriteLine(ln);
            }
        }

    
    }

    public void CreateChild(string childString, List<Child> lst)
    {
        Child child = new Child("","",false);
        string[] strArray = childString.Split("=");
        string[] paramArray = strArray[1].Split(":");
        int age = Convert.ToInt16(paramArray[0]);
        string name = paramArray[1];
        string password = paramArray[2];
        bool loggedIn = Convert.ToBoolean(paramArray[3]);
        Child user = child.DetermineAgeGroup(age, name, password);
        lst.Add(user);
    }
}