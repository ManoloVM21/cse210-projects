public class Video{
    private string _title;
    private string _author;
    private int _lenght;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _lenght = length;
    }
    public void AddComment(string person, string text){
        Comment comment = new Comment(person,text);
        _comments.Add(comment);
    }

    public int numberComments(){
        return _comments.Count;
    }
    public void Display(){
        int counts = numberComments();
        string text = $"Title: {_title}\nAuthor: {_author}\nLenght: {_lenght}\nNumber of Comments: {counts}\nComments:";
        Console.WriteLine(text);
        foreach (Comment comment in _comments){
            comment.Display();
        }
        Console.WriteLine(" ");       
    }
}