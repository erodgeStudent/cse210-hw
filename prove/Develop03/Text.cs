using System;
using System.Collections;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;


public class Text
{
    private string _text;
    public List<string> _wordList = new List<string>();

    
    //----------CONSTRUCTORS
    public Text()
    {
        _text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

    }
    public Text(string text)
    {
        _text = text;
    }
    //----------GETTERS AND SETTERS
    public string GetScriptTxt()
    {
        return _text;
    }
    //----------METHOD
}
