public class Event
{
    private string _title;
    private string _description;
    private DateOnly _date;
    private TimeOnly _time;
    private Address _address;
    public Event(string title, string description, DateOnly date, TimeOnly time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetTitle() { return _title; }
    public string GetDescription() { return _description; }
    public DateOnly GetDate() { return _date; }
    public TimeOnly GetTime() { return _time; }
    public Address GetAddress() { return _address; }
    public string GetStardadDetail()
    {
        return $"Event:{_title}\nDescription:{_description}\nDate of event:{_date.ToShortDateString()} at {_time.ToShortTimeString()}\nAddress:{_address.GetFullAddress()}";
    }
    public string GetShortDescription(string tipe)
    {
        return $"\nShort Description:\nType of event:{tipe} Event:{_title}\nDate of event:{_date.ToShortDateString()}";
    }



}