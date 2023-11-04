public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public override double GetArea()
    {
        return _width   * _length  ;
    }
    public Rectangle(string color, double width, double length):base(color)
    {
        _width = width;
        _length = length;
    }

}