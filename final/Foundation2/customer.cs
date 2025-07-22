// Customer.cs
public class Customer
{
    private string fullName;
    private Address homeAddress;

    public Customer(string nameInput, Address addressInput)
    {
        fullName    = nameInput;
        homeAddress = addressInput;
    }

    public bool IsInUSA()
    {
        return homeAddress.IsInUSA();
    }

    public string GetName()
    {
        return fullName;
    }

    public Address GetAddress()
    {
        return homeAddress;
    }
}
