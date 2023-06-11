public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _responses = new List<string>();
    private int _counter = 0;

    public Listing() : base()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can.";
        _prompts.Add("Who is someone that you appreciate? ");
        _prompts.Add("What what is a strength of yours? ");
        _prompts.Add("Who have you helped this week? ");
        _prompts.Add("When have you felt the Spirit this month? ");
        _prompts.Add("Who are some of your heroes? ");
    }
    public Listing(int time) : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can.", time)
    {
        
    }

    public void RunActivity()
    {
        Console.Clear();
        DisplayWelcome();
        DisplayPrompt();
        // Console.Write("Press enter to continue... ");
        // Console.ReadLine();
        _start = DateTime.Now;
        do
        {
            GetAnswer();
            _counter += 1;
        } while(TimeHandler(_start) != true);
        Console.WriteLine();
        Console.WriteLine($"Good job, you listed {_counter} items!");
        Console.WriteLine();
        DisplayFinished();

    }

    public string GetRandomPrompt()
    {
        Random r = new Random();
        int i = r.Next(0,_prompts.Count);
        string stuff = _prompts[i];
        return stuff;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following: ");
        Console.WriteLine($" ---- {GetRandomPrompt()} ---- ");
        SpinnerAnimation(_long);
        Console.Write("You may begin in: ");
        CountDownAnimation();
        Console.WriteLine();
    }


    public void GetAnswer()
    {
        Console.Write("  > ");
        Console.ReadLine();

    }
}