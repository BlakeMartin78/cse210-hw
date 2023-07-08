public class Video{

string _title;
string _author;
int _length;
List<Comment> _comments = new List<Comment>();

public Video()
{

}

public void AddComment(string commentor, string text)
{
    Comment currentComment = new Comment(commentor,text);
    _comments.Add(currentComment);
}




}