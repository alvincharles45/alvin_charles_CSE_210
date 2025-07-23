// Product.cs
public class Product
{
    private string _productName;
    private string _sku;
    private double _unitPrice;
    private int    _quantity;

    public Product(string productName, string sku, double unitPrice, int quantity)
    {
        _productName = productName;
        _sku         = sku;
        _unitPrice   = unitPrice;
        _quantity    = quantity;
    }

    public double GetTotalCost()
    {
        return _unitPrice * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_productName} (SKU: {_sku})";
    }
}
