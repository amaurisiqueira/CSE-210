public class Cycling : Activity
{
    private double _speed;
    public Cycling(string name, DateOnly date, int length, double speed) : base(name, date, length)
    {
        _speed = speed;
    }
    public override double GetSpeed()
    {
        if (_speed == 0) return 1;
        return _speed;
    }
    public override double GetDistance()
    {
        return GetSpeed() * (GetDuration() / 60);
    }
}