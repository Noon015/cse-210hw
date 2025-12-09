using System;

class Customer
{
    protected string _firstName;
    protected string _lastName;
    protected Address _cutomerAddress;

    public Customer(string firstName, string lastName, Address customerAddress)
    {
        _firstName= firstName;
        _lastName = lastName;
        _cutomerAddress = customerAddress;
    }

    public bool IsInUS()
    {
        bool countryCheck = _cutomerAddress.IsInUSA();
        if (countryCheck)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public string DisplayCustomerInfo()
    {
        string addressInfo = _cutomerAddress.DisplayAddress();
        string fullInfo = $"{_firstName} {_lastName}\n{addressInfo}";
        return fullInfo;
    }
}