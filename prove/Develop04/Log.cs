using System;

//Takes a running count of minutes and saves it to a TXT file
public class Log
{
    private int _totalActivityTime;

    public Log(int tt)
    {
        _totalActivityTime = tt;
    }

        public int GetTotalTime()
    {
        return _totalActivityTime;
    }

}