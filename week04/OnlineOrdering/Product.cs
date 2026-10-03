using System;

class Product
{
    private string _productName;
    private string _productId;
    private decimal _price;
    private int _quantity;
    public Product(string productName, string productId, decimal price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string Name => _productName;
    public string Id => _productId;
    public decimal Price => _price;
    public int Quantity => _quantity;
}
