public class Prompt
{

    private List<string> _prompts = new List<string>();

    public Prompt()
    {
        _prompts.Add("How was your day?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("How did you see the hand of God in your day?");
        _prompts.Add("What was your favorite part of today?");
        _prompts.Add("What were you grateful for today?");
        _prompts.Add("What is something you want want to remember about today?");
    }



    public string getRandomPrompt()
    {
        var randomGenerator = new Random();
        var randomNumber = randomGenerator.Next(0,_prompts.Count);

        return _prompts[randomNumber];   
    }
}