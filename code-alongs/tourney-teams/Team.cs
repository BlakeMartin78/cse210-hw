public class Team
{
    private List<Player> _players = new List<Player>();
    private string _name;
    private int _wins;
    private int _losses;
    public Team(string name)
    {
        _name = name;
        _wins = 0;
        _losses = 0;
    }

    public void AddPlayer(Player p)
    {
        _players.Add(p);
    }

    public void DisplayRoster()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"With {_wins} wins and {_losses} losses");
        foreach (Player player in _players)
        {
            Console.WriteLine(player.DisplayPlayer());
        }
    }
    
    public void AddWin()
    {
        _wins++;
    }
    public void AddLoss()
    {
        _losses++;
    }

}