using System;
using System.Text.RegularExpressions;

public class Elementary : Child
{   
    private int _goal = 150;
    private string _password;

    public Elementary(int age, string name, string password, bool loggedIn) : base (age, name, password, loggedIn)
    {
        
    }

    // public override void SetPassword()
    // {
    //     Console.WriteLine("Please set your password.\nAt least one capital letter and number are required, minimum 5 characters. ");
    //     string password = Convert.ToString(Console.Read());
    //     var upper = new Regex(@"[A-Z]");
    //     var min = new Regex(@".{5,}");
    //     var num = new Regex(@"[0-9]+");
    //     var valid = upper.IsMatch(password) && min.IsMatch(password) && num.IsMatch(password);
    //     if (valid)
    //     {
    //         Console.WriteLine("New password stored.");
    //         _password = password;
    //     }
    // }


}