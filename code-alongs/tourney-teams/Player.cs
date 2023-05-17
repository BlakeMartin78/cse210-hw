public class Player
{
    string _name;
    string _position = "";
    int _jerseyNumber;


    public Player(string name, int jerseyNumber)
    {
        _name = name;
        _jerseyNumber = jerseyNumber;
    }

    public Player(string name, int jerseyNumber, string position)
    {
        _name = name;
        _jerseyNumber = jerseyNumber;
        _position = position;
    }

    public void SetPosition(string position)
    {
        _position = position;
    }

    public string DisplayPlayer()
    {
        return $"{_name} {_jerseyNumber} {_position}";
    }

}