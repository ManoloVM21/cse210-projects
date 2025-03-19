using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
public class Scripture{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text){
        _reference = reference;
        string[] palabras = text.Split(" ");
        foreach (string palabra in palabras){
            Word newword = new Word(palabra);
            _words.Add(newword);
        }
    }
    public void HideRandomWords(int numberToHide){
        Random random = new Random();
        List<Word> wordsToHide = _words.Where(word => !word.IsHidden()).ToList();
        numberToHide = Math.Min(numberToHide,wordsToHide.Count);
        for (int i = 0; i < numberToHide; i++){
            int index = random.Next(wordsToHide.Count);
            wordsToHide[index].Hide();
            wordsToHide.RemoveAt(index);
        }
    }
    public string GetDisplayText(){
        string scripturetext = string.Join(" ",_words.Select(word => word.GetDisplayText()));
        string scriptureref = _reference.GetDisplayText();
        string text = $"{scriptureref} {scripturetext}";
        return text;
    }
    public bool IsCompletelyHidden(){
        int counter = 0;
        foreach (Word word in _words){
            if(word.IsHidden()){
                counter ++;
            }
        }
        if (counter == _words.Count){
            return true;
        }
        else{
            return false;
        }
        
    }
}
public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text;
    }
    public void Hide(){
        _isHidden = true;
    }
    public void Show(){
        _isHidden = false;
    }
    public bool IsHidden(){
        return _isHidden;
    }
    public string GetDisplayText(){
        return _isHidden ? new string('_',_text.Length) : _text;
    }
}
public class Reference {
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string GetDisplayText(){
        string text;
        if (_endVerse != 0){
            text = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else{
            text = $"{_book} {_chapter}:{_verse}";
        }
        
        return text;
    }
}
class Program
{
    static void Main(string[] args)
    {
        string response;
        Reference ref1 = new Reference("2 Nephi",31,10);
        Scripture scripture = new Scripture(ref1, "And he said unto the children of men: Follow thou me. Wherefore, my beloved brethren, can we follow Jesus save we shall be willing to keep the commandments of the Father?");
        string display = scripture.GetDisplayText();
        do{
        Console.WriteLine(display);
        Random random = new Random();
        int number = random.Next(1,4);
        scripture.HideRandomWords(number);
        display = scripture.GetDisplayText();
        
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        response = Console.ReadLine();
        Console.Clear();
        
        if (scripture.IsCompletelyHidden()){
            Console.WriteLine(display);
            response = "quit";
        }
        } while (response != "quit");
    }
}