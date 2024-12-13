using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string name { get => _name;}
    public Address address { get => _address;}

    public bool InUSA()
    {
        return _address.InUSA();
    }
}