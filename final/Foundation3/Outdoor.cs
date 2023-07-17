public class Outdoor : Event
{


    string _weather;


    public Outdoor(string title, string description, DateTime datetime, Address address, string weather) : base(title,description,datetime,address)
    {
        _weather = weather;
    }

    public override void ShowShortDescription()
    {
        Console.WriteLine($"This event is an Outdoor event titled '{_title}' and takes place on {_dateTime}");
    }


    public override void ShowFullDetails()
    {
        base.ShowFullDetails();
        Console.WriteLine(_weather);
    }
}