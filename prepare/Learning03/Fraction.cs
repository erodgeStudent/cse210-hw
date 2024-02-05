public class Fraction{

//---------------------PRIVATE ATTRIBUTES
    private int _top;
    private int _bottom;
// --------------------CONSTRUCTORS
    public Fraction()
    {
        _top = 1;
        _bottom = 1; 
        // Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int wholeNum)
    {
        _top = wholeNum;
        _bottom = 1;
        // Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        // Console.WriteLine($"{_top}/{_bottom}");
    }
//--------------------GETTERS and SETTERS

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }


    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    //-----------------METHODS
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double) _top / (double)_bottom;
    }

}