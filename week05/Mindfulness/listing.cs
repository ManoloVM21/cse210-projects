using System.Data;

public class Listing : Activity{
    protected int _count;
    protected List<string> _prompts = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    public Listing(string name, string description, int duration) : base(name,description,duration){
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    
    public void Run(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> userinputs = new List<string>();
        userinputs = GetListFromUser();

        // SAVING THE LIST IN A FILE
        string fileName = "userInputs.txt";
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
        File.WriteAllLines(filePath, userinputs);

        Console.WriteLine($"You Listed {_count} items!");
        Console.WriteLine("\nWell Done!!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the Listing Activity");
        ShowSpinner(3);
        Console.Clear();
    }
    public void GetRandomPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"\n---{prompt}---");
    }
    public List<string> GetListFromUser(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> inputs = new List<string>();
        do{
        Console.Write("> ");
        string input = Console.ReadLine();
        inputs.Add(input);
        _count++;
        } while (DateTime.Now < endTime);
        
        return inputs;
    }
}