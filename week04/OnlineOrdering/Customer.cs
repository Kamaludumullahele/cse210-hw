using System;
using System.Collections.Generic;

class Customer
{
    private string _customerName;
    private string _address;
    public Customer(string customerName, string address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetAddress()
    {
        return _address;
    }

    public bool isLivesInUSA()
    {
        return _address.Contains("United States");
    }
}
