using System;
class Single : Task {
    public Single(string name, int pointVal, bool complete) : base (name, pointVal, complete)
    {}

    public override string SaveStringInFile()
    {
        var name = GetName();
        var points = GetPointVal();
        var complete = CheckIsComplete();
        return $"{GetType()}={name}:{points}:{complete}";
    }
    

}