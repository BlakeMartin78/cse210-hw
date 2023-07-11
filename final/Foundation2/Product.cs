public class Product{
    string _productId;
    string _productName;
    double _unitPrice;
    int _quantity; 

    public Product(string productId, string name, double price, int quantity){
        _productId = productId;
        _productName = name;
        _unitPrice = price;
        _quantity = quantity;
    }

    public double GetTotalPrice(){
        return _unitPrice * _quantity;
    }
    public string GetPackingLabel()
    {
        return $"{_productId}: {_productName}";
    }
}