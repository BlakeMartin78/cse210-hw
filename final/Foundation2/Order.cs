using System;
using System.Text;



public class Order {

    Customer _customer;
    List<Product> _products = new List<Product>();



    public Order(Customer customer){
        _customer = customer;
    }


    public void AddProductToCart(Product product){
        _products.Add(product);
    }


    public double GetTotalCost()
    {
        double cost = 0;
        foreach (Product product in _products)
        {
            cost += product.GetTotalPrice();
        }
        if (_customer.IsInUsa() == true){
            cost += 5;
        }
        else{
            cost += 35;
        }
        return cost;
    }

    public string GetPackingLabel()
    {
        StringBuilder builder = new StringBuilder("");
        foreach (Product product in _products)
        {
            builder.Append($"{product.GetPackingLabel()}\n");
        }
        return builder.ToString();
    }
    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}