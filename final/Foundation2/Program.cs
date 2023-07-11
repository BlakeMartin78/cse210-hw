using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1= new Order(new Customer("Jim Halpert",new Address("1600 Pennsylvania Avenue","Washington","District of Columbia", "Usa")));
        Product tempProduct = new Product("84183","Paper",1,100);
        order1.AddProductToCart(tempProduct);
        tempProduct = new Product("302","Pen",1.99, 50);
        order1.AddProductToCart(tempProduct);


        Console.WriteLine("Packing label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine();
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: {order1.GetTotalCost()}");

        Console.WriteLine();
        Console.WriteLine();
        Order order2 = new Order(new Customer("Michael Scott",new Address("42 Wallaby Way","Sydney","New South Wales", "Australia")));
        tempProduct = new Product("500","Basketball", 10, 1);
        order2.AddProductToCart(tempProduct);
        tempProduct = new Product("501", "Generic Jersey", 40, 1);
        order2.AddProductToCart(tempProduct);
        tempProduct = new Product("678", "Basketball Shorts", 14.99, 1);
        order2.AddProductToCart(tempProduct);



        Console.WriteLine("Packing label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine();
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: {order2.GetTotalCost()}");
    }
}