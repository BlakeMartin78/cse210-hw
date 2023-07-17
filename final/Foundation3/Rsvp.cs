public class Rsvp : Event
{


string _email;




public Rsvp(string title, string description, DateTime datetime, Address address, string email) : base(title,description,datetime,address)
{
    _email =email;
}

public override void ShowShortDescription()
    {
        Console.WriteLine($"This event is RVSP only titled '{_title}' and takes place on {_dateTime}");
    }

public override void ShowFullDetails()
    {
        base.ShowFullDetails();
        Console.WriteLine(_email);
    }

}