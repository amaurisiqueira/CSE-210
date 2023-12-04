public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsUSA()
    {
        if (_country.ToUpper().Trim() == "USA") return true;
        return false;
    }
    public string GetFullAddress()
    {
        return _street.Trim() + ", " + _city.Trim() + ", " + _state.Trim() + ", " + _country.Trim();
    }

}