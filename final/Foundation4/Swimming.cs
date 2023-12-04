public class Swimming : Activity
{
    private int _number_of_laps;
    public Swimming(string name, DateOnly date, int length, int number_of_laps) : base(name, date, length)
    {
        _number_of_laps = number_of_laps;
    }
    public override double GetSpeed()
    {   
        return 60 /  GetDuration();
    }
    override public  double GetDistance()
    {
        if (_number_of_laps == 0) return 1;
        return (Convert.ToDouble(_number_of_laps)  * 50.0) / 1000 ;
    }
    override public double GetPace()
    {
       return 60/GetSpeed();
    }
}