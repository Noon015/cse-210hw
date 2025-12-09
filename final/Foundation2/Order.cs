using System;

class Order
{
    protected Customer _customerInfo;
    protected List<Product> _customerOrder;

    public Order(Customer customerInfo,List<Product> customerOrder)
    {
        _customerInfo = customerInfo;
        _customerOrder = customerOrder;
    }

    public void AddToOrder(Product item)
    {
        _customerOrder.Add(item);
    }

    public void DisplayProducts()
    {
        foreach (Product item in _customerOrder)
        {
            Console.WriteLine("----------");
            Console.WriteLine(item.DisplayInfo());
        }
    }

    public void DisplayCustomerInfo()
    {
        string info = _customerInfo.DisplayCustomerInfo();
        Console.WriteLine(info);
    }

    public decimal CalculateOrder()
    {
        decimal total = 0.00m;

        foreach (Product item in _customerOrder)
        {
            decimal cost = item.ComputeCost();
            total += cost;
        }

        bool countryCheck = _customerInfo.IsInUS();
        
        if (countryCheck)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }
}