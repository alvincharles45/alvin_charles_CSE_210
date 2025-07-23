// Order.cs
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer      _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        // 1) subtotal
        double subtotal = 0.0;
        foreach (var item in _products)
        {
            subtotal += item.GetTotalCost();
        }

        // 2) shipping
        double shippingCost;
        if (_customer.IsDomestic())
        {
            shippingCost = 5.0;
        }
        else
        {
            shippingCost = 35.0;
        }

        return subtotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        var labelBuilder = "";
        foreach (var item in _products)
        {
            labelBuilder += item.GetPackingLabel() + "\n";
        }

        if (labelBuilder.Length > 0)
        {
            // remove trailing newline
            labelBuilder = labelBuilder.TrimEnd('\n');
        }

        return labelBuilder;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}
