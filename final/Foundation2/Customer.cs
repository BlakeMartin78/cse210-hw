public class Customer
{
    string _name;
    Address _address;




    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }

    public string GetShippingLabel(){
        return $"{_name}\n{_address.GetAddressString()}";
    }


}