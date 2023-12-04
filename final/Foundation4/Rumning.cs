public class Rumning : Activity
{
    private double _distance;
    public Rumning(string name, DateOnly date, int length, double distance) : base(name,date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        if (_distance == 0) return 1;
        return _distance;
    }


}