public class Lecture : Event
{
    string _speaker;
    int _capacity;

    public Lecture(string title, string description, DateTime datetime, Address address, string speaker, int capacity) : base(title,description,datetime,address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }


    public override void ShowShortDescription()
    {
        Console.WriteLine($"This event is a Lecture titled '{_title}' and takes place on {_dateTime}");
    }

    public override void ShowFullDetails()
    {
        base.ShowFullDetails();
        Console.WriteLine(_speaker);
        Console.WriteLine(_capacity);
    }
}