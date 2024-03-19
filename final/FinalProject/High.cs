using System;

public class High : Child {



    private int _extracurricularLevel;

    public High(int age, string name, int rLevel, int hLevel, int ecLevel, string password, bool loggedIn, int range) : base(age, name, rLevel, hLevel, password, loggedIn, range)
    {
        _extracurricularLevel = ecLevel;
    }

    public int GetECLevel()
    {
        return _extracurricularLevel;
    }

       public override int CalculatePointRate()
    {
        var age = GetAge();
        var rLevel = GetRLevel();
        var hLevel = GetHLevel();
        var ecLevel = GetECLevel();
        var rate = age * rLevel * hLevel * ecLevel;
        return rate;
    }
}