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
            /*
            A packing label should list the name and product id of each product in the order.

            // Puede calcular el costo total del pedido.
            Puede devolver una cadena para la etiqueta de embalaje.
            Puede devolver una cadena para la etiqueta de envío.
            El precio total se calcula como la suma de los precios de cada producto más un costo de envío único.
            El costo de envío es de $5 si el cliente vive en EE. UU. y de $35 si no vive en EE. UU.
            La etiqueta de embalaje debe enumerar el nombre y el ID del producto de cada producto en el pedido.
            La etiqueta de envío debe enumerar el nombre y la dirección del cliente.
            */


            //          Console.WriteLine(product1.GetProductID());
            //        Console.WriteLine(product1.GetName());
            //      Console.WriteLine(product1.PriceComputed());

        }//------------


    }
}