// Product.cs
public class Product
{
    private string productName;
    private string sku;
    private double unitPrice;
    private int    quantityOrdered;

    public Product(string nameInput, string skuInput, double priceInput, int quantityInput)
    {
        productName     = nameInput;
        sku             = skuInput;
        unitPrice       = priceInput;
        quantityOrdered = quantityInput;
    }

    public double GetTotalCost()
    {
        return unitPrice * quantityOrdered;
    }

    public string GetPackingLabel()
    {
        return $"{productName} (SKU: {sku})";
    }
}
