using System;

public class Product
{
    private string _name;
    private int _productid;
    private double _price;
    private int _quantity;

    public Product(string name, int productid, double price, int quantity)
    {
        _name = name;
        _productid = productid;
        _price = price;
        _quantity = quantity;
    }

    public string name { get => _name;}
    public int productid { get=> _productid;}
    public double price {get => _price;}
    public int quantity {get => _quantity;}

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}