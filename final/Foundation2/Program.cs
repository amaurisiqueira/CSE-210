using System;

class Program
{
    static List<Order> _orders = new List<Order>();


    static void Populate_Order1()
    {

        Address Address = new Address("Calle a", "Santiago", "R.M.", "Chile");
        Customer customer = new Customer("Juanito El Gato", Address);

        Product product1 = new(
            "BIK1",
            "Bike Dakota",
            999.9,
            2);

        Product product2 = new(
            "PASEO1",
            "Bike Paseo",
            219.99,
            4);

        Product product3 = new(
            "BRUTUS2",
            "Bike Brutus",
            659.99,
            2);

        Order myOrder = new Order(customer);
        myOrder.AddProduct(product1);
        myOrder.AddProduct(product2);
        myOrder.AddProduct(product3);
        _orders.Add(myOrder);

    }
    static void Populate_Order2()
    {

        Address Address = new Address("1425 Ocean dr", "Hollywood", "Fl", "USA");
        Customer customer = new Customer("Paul Jack And Harris ", Address);
        Order myOrder = new Order(customer);

        Product product1 = new(
            "JETSKI",
            "Bombardier SP",
            25999.9,
            3);

        Product product2 = new(
            "REMO1",
            "Plastic Remo",
            9.99,
            8);

        Product product3 = new(
            "TSHIRT",
            "T-shirt promo",
            1.99,
            9);

        myOrder.AddProduct(product1);
        myOrder.AddProduct(product2);
        myOrder.AddProduct(product3);
        _orders.Add(myOrder);
    }
    static void Populate_Order3()
    {

        Address Address = new Address("Rua Iquiri 10", "Armando Mendes - Manaus", "Amazonas", "Brazil");
        Customer customer = new Customer("Joäo Batista Figueiredo", Address);
        Order myOrder = new Order(customer);
        Product product1 = new(
                  "ENGINE10",
                  "Maritime Engine 400hp",
                  55999.9,
                  1);

        Product product2 = new(
            "BOL1",
            "Bolts 10'",
            12.99,
            6);

        Product product3 = new(
            "PIS1",
            "Pistons 10'",
            666.99,
            2);

        myOrder.AddProduct(product1);
        myOrder.AddProduct(product2);
        myOrder.AddProduct(product3);
        _orders.Add(myOrder);
    }
    static void Main(string[] args)
    {
        _orders.Clear();

        Populate_Order1();
        Populate_Order2();
        Populate_Order3();




        Console.WriteLine("Foundation2");

        bool first = true;
        foreach (Order o in _orders)
        {
            if (first) first = false;
            else Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Packing  label:" + o.GetPackageLabel());
            Console.WriteLine("Shipping label:" );
            Console.WriteLine( o.GetShippingLabel() );
            Console.WriteLine("Total price   :" + o.GetTotalPrice().ToString("#,###,###.##"));
           






            //          Console.WriteLine(product1.GetProductID());
            //        Console.WriteLine(product1.GetName());
            //      Console.WriteLine(product1.PriceComputed());

        }//------------


    }
}
