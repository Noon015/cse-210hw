using System;

class Address
{
    protected string _street;
    protected string _city;
    protected string _state;
    protected string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string DisplayAddress()
    {
        string fullAddress = $"{_street}, {_city}, {_state}, {_country}";
        return fullAddress;
    }
}