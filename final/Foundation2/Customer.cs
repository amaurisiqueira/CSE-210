public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetName(){
        return _name.Trim();
    }
    public bool IsUsa()
    {
        return _address.IsUSA();
    }
    public string GetFullAdress(){
        return _address.GetFullAddress();
    }
}