public abstract class Shape
{
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getter and Setter for color
    public string GetColor()
    {
        return _color;

    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual method for GetArea to be overridden by derived classes
    public abstract double GetArea(); 
}