using System;

class Product
{
    protected string _name;
    protected int _productId;
    protected decimal _productPrice;
    protected int _productQuantity;

    public Product(string name,int productId, decimal productPrice, int productQuantity)
    {
        _name = name;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public decimal ComputeCost()
    {
        decimal fullCost = _productPrice * _productQuantity;
        return fullCost;
    }

    public string DisplayInfo()
    {
        return $"{_name}\n{_productId}\n{_productPrice}\n{_productQuantity}";
    }
}