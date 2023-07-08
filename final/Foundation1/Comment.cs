public class Comment{

string _commentor;
string _text;

public Comment(string commentor, string text){
    _commentor = commentor;
    _text = text;

}

public string Display(){
    return $"{_commentor}: '{_text}' ";
}


}