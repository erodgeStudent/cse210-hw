using System;
class Single : Task {
    public Single(string name, int pointVal) : base (name, pointVal)
    {}

    public override string SaveStringInFile()
    {
        var name = GetName();
        var points = GetPointVal();
        var complete = CheckIsComplete();
        return $"{name}:{points}:{complete}";
    }
    

}