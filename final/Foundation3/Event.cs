public abstract class Event{

    protected string _title;
    protected string _description;
    protected DateTime _dateTime;
    protected Address _address;

    public Event(string title, string description, DateTime datetime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = datetime;
        _address = address;
    }

    public void ShowStandardDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_dateTime);
        Console.WriteLine(_address.GetAddressString());
    }

    public virtual void ShowFullDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_dateTime);
        Console.WriteLine(_address.GetAddressString());
    }

    public abstract void ShowShortDescription();
    

}