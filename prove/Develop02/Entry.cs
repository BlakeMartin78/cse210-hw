public class Entry
{

    private string _dateAndTime;
    private string _prompt;
    private string _text;

    public Entry()
    {
    }

    public void writeEntry()
    {
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();
        _dateAndTime = dateText;
        _text = Console.ReadLine();

    }

    public void displayAndSetPrompt()
    {
        Prompt prompty = new Prompt();
        _prompt = prompty.getRandomPrompt();
        Console.WriteLine(_prompt);
    }

    public void displayEntry()
    {
        Console.WriteLine($"{_dateAndTime}\nQuestion: {_prompt}\nEntry:\n\n{_text}");
    }
    public string returnEntryFormatted()
    {
        return $"{_dateAndTime}|{_prompt}|{_text}";
    }

    public void inputFromLoad(string date, string prompt, string text)
    {
        _dateAndTime = date;
        _prompt = prompt;
        _text = text;
    }
}