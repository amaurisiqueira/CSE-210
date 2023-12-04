public class Lectures : Event
{

    private string _speaker;
    private int _capacity;
    public Lectures(string title, string description, DateOnly date, TimeOnly time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker() { return _speaker; }
    public int GetCapacity() { return _capacity; }
    public string GetFullDetaills()
    {
        
        return $"\nFull Description:\n{base.GetStardadDetail()}\nSpeaker:{_speaker}\nCapacity:{_capacity}";
    }
    
}