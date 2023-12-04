public class Outdoor : Event
{

    private string _weather_forecast;
    public Outdoor(string title, string description, DateOnly date, TimeOnly time, Address address, string weather_forecast) : base(title, description, date, time, address)
    {
        _weather_forecast = weather_forecast;
    }
    public string GetFullDetaills()
    {
        return $"\nFull Description:\n{base.GetStardadDetail()}\nWeather forecast:{_weather_forecast}";
    }
}