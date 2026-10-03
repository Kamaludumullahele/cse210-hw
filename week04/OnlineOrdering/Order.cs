using System;
using System.Collections.Generic;
class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.Price * product.Quantity;
        }
        return total;
    }
    // Add the shipping cost based on the customer's country.
    public decimal GetTotalPriceWithShipping()
    {
        decimal total = GetTotalPrice();
        return total + (_customer.isLivesInUSA() ? 5m : 35m);
    }

    public string GetShippingLabel()
    {
        return _customer.GetAddress();
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += "\n" + $"Product: {product.Name}, ID: {product.Id}, Quantity: {product.Quantity}";
        }
        return packingLabel;
    }   
}