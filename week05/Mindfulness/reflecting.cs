public class Reflecting : Activity{
    protected List<string> _prompts;
    protected List<string> _questions = new List<string>{"Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",};
    public Reflecting(string name, string description, int duration) : base(name,description,duration){
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    }
    
    public void Run(){
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DisplayQuestions();
        Console.WriteLine("\nWell Done!!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the Reflecting Activity");
        ShowSpinner(3);
        Console.Clear();
    }
    public string GetRandomPrompt(){
        List<string> prompts = new List<string> {"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};

        Random random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        return prompt;
    }
    public string GetRandomQuestion(){
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        _questions.RemoveAt(index);
        return question;
    }
    public void DisplayPrompt(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine("\nConsider the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n---{prompt}---");
    }
    public void DisplayQuestions(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        do{
        string question = GetRandomQuestion();
        Console.Write($"\n> {question}");
        ShowSpinner(8);
        } while (DateTime.Now < endTime);
    }
}