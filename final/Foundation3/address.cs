// Address.cs
using System;

public class Address
{
    private string streetLine;
    private string town;
    private string region;
    private string nation;

    public Address(string streetInput, string townInput, string regionInput, string nationInput)
    {
        streetLine = streetInput;
        town       = townInput;
        region     = regionInput;
        nation     = nationInput;
    }

    public string FormatAddress()
    {
        return $"{streetLine}, {town}, {region}, {nation}";
    }
}
