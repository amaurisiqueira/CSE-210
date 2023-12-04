public class Activity
{

    protected DateOnly _date;
    protected int _length;
    protected string _activityName;
    public Activity(string name,DateOnly date, int length)
    {
        _activityName=name;
        _date = date;
        _length = length;
    }

    virtual public double GetDistance()
    {
        return 1;
    }
    virtual public double GetSpeed()
    {
        if (_length == 0) _length = 1;
        return (GetDistance() / _length)* 60;
    }
    virtual public double GetPace()
    {
        // minutes / distance
       // return  _length / GetDistance();
       return 60/GetSpeed();
    }
 
    virtual public string GetSummary()
    {
        //03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
        return $"{_date} {_activityName} ({ string.Format("{0:0.#}",_length)} min) : Distance { string.Format("{0:0.#}", GetDistance())} km, Speed: { string.Format("{0:0.#}",GetSpeed())} kph, Pace: { string.Format("{0:0.#}",GetPace())} Min per km";
    }
    public double GetDuration(){ return _length;}
}