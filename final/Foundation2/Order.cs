public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    public Order(Customer customer)
    {
        _customer = customer;
    }
    double GetShippingCost()
    {
        if (_customer.IsUsa()) return 5.0;
        return 35.0;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string GetPackageLabel()
    {
        return _customer.GetName() + " - " + _customer.GetFullAdress();
    }
    public string GetShippingLabel()
    {
        string myReturn = "";
        bool first = true;
        int n = 0;
        foreach (Product p in _products)
        {
            if (first) { first = false; }
            else { myReturn += "\n"; }

            myReturn +=  "" + (++n) + ") " + p.GetProductID() +" - "+ p.GetName()  ;
        }
        return myReturn;
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.PriceComputed();
        }
        if (_products.Count > 0) total += GetShippingCost();
        return total;
    }

}