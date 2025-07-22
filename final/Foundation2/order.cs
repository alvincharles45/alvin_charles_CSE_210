// Order.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    private List<Product> itemList      = new List<Product>();
    private Customer       orderCustomer;

    public Order(Customer customerInput)
    {
        orderCustomer = customerInput;
    }

    public void AddProduct(Product productInput)
    {
        itemList.Add(productInput);
    }

    public double GetTotalPrice()
    {
        double subtotal = itemList.Sum(p => p.GetTotalCost());
        double shipping = orderCustomer.IsInUSA() ? 5.0 : 35.0;
        return subtotal + shipping;
    }

    public string GetPackingLabel()
    {
        return string.Join("\n", itemList.Select(p => p.GetPackingLabel()));
    }

    public string GetShippingLabel()
    {
        return $"{orderCustomer.GetName()}\n{orderCustomer.GetAddress()}";
    }
}
