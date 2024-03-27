using System;
using System.Text.RegularExpressions;

public class Primary : Child
{   
    private int _goal = 50;
    private string _password;

    public Primary(int age, string name, string password, bool loggedIn) : base (age, name, password, loggedIn)
    {
    }

    public override string CreateNewPassword()
    {
        return base.CreateNewPassword();
    }   



}