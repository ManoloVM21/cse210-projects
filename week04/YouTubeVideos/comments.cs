public class Comment{
    private string _person;
    private string _text;
    public Comment(string person, string text){
        _person = person;
        _text = text;
    }
    public void Display(){
        Console.WriteLine($"{_person} - '{_text}'");
    }
}