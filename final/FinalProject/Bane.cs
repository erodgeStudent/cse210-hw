using System;

public class Bane : Child {
    
    private int _extracurricularLevel;


    public Bane(int age, string name, int rLevel, int hLevel, int ecLevel, string password, bool loggedIn) : base (age, name, rLevel, hLevel, password, loggedIn)
    {
    
        _extracurricularLevel = ecLevel;
    }

    // public override void CalculatePointRate()
    // {
    //     // var rate = age * rLevel * hLevel * eLevel;
    //     // return rate;
    // }
}