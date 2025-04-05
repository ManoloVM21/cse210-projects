using System.Diagnostics;

public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
    }
    public void DisplayEndingMessage(){
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    }
    public void ShowSpinner(int seconds){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        List<string> spinner = new List<string>(){"|","/","-","\\"};
        int f = 0;
        while (DateTime.Now < endTime){
            string s = spinner[f];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            f++;
            if (f >= spinner.Count){
                f=0;
            }
        }
    }
    public void ShowCountDown(int seconds){
        int time = seconds;
        for (int i = time; i>0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}