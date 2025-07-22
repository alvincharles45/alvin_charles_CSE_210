// Address.cs
using System;

public class Address
{
    private string streetAddress;
    private string cityName;
    private string province;
    private string countryName;

    public Address(string streetInput, string cityInput, string provinceInput, string countryInput)
    {
        streetAddress = streetInput;
        cityName      = cityInput;
        province      = provinceInput;
        countryName   = countryInput;
    }

    public bool IsInUSA()
    {
        return countryName.ToLower() == "usa";
    }

    public override string ToString()
    {
        return $"{streetAddress}\n{cityName}, {province}\n{countryName}";
    }
}
