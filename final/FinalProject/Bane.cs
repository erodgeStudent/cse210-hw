using System;

public class Bane : Child {
    private int _extracurricularLevel;

    public Bane(int age, string name, int rLevel, int hLevel, int eLevel) : base ( age,  name, rLevel,  hLevel)
    {
        _extracurricularLevel = eLevel;
    }

    public override void CalculatePointRate()
    {
        // var rate = age * rLevel * hLevel * eLevel;
        // return rate;
    }
}