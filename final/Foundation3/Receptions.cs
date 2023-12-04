public class Receptions : Event
{
    private string _email;
    public Receptions(string title, string description, DateOnly date, TimeOnly time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }
    public string GetEmail() { return _email; }
    public string GetFullDetaills()
    {
        return $"\nFull Description:\n{base.GetStardadDetail()}\nEmail to RSVP:{_email}";
    }

}