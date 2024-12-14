using System;

public class Customer
{
    private string _name;
    private Address _address;

    public string Name
    {
        get {return _name;}
        set{_name = value;}
    }

    public Address address
    {
        get {return _address;}
        set{_address = value;}
    }



    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string name { get => _name;}
    public Address Address { get => _address;}

    public bool InUSA()
    {
        return _address.InUSA();
    }
}