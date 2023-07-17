public class Address{
    string _streetAddress;
    string _city;
    string _state;
    string _country;

    public Address(string streetaddress, string city, string state, string country){
        _streetAddress = streetaddress;
        _city = city;
        _state = state;
        _country = country;
    }



    public bool IsInUsa()
    {
        if (_country.ToUpper() == "USA"){
            return true;
        }
        else{
        return false;
        }
    }
    public string GetAddressString()
    {
        return $"{_streetAddress} {_city} {_state} {_country}";
    }
}