public class Video{

string _title;
string _author;
int _length;
List<Comment> _comments = new List<Comment>();

public Video(string title, string author, int length)
{
    _title = title;
    _author = author;
    _length = length;
}

public void AddComment(string text, string commentor)
{
    Comment currentComment = new Comment(commentor,text);
    _comments.Add(currentComment);
}

public void Display()
{
    Console.WriteLine($"{_title} by {_author}");
    Console.WriteLine($"{_length} seconds");
    Console.WriteLine("");
    Console.WriteLine("Comments:");
    foreach (Comment comment in _comments)
    {
        Console.WriteLine(comment.Display());
    }
}


}