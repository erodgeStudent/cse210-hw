using System;
using System.Collections;



public class Text
{
    private string _text;

    
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
