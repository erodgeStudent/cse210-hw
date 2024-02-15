using System;

//Takes a running count of minutes and saves it to a TXT file
public class Log
{
    private int _breathingTime;
    private int _reflectingTime;
    private int _listingTime;

    public Log(int bt, int rt, int lt)
    {
        _breathingTime = bt;
        _reflectingTime = rt;
        _listingTime = lt;
    }

    //GETTERS AND SETTERS
    public int GetBT()
    {
        return _breathingTime;
    }

    public int GetRT()
    {
        return _reflectingTime;
    }
    public int GetLT()
    {
        return _listingTime;
    }

    public int SetBT()
    {
        return _breathingTime;
    }

    public int SetRT()
    {
        return _reflectingTime;
    }
    public int SetLT()
    {
        return _listingTime;
    }
    //METHODS
    // public int LogMoreTime()
    // {

    // }

}