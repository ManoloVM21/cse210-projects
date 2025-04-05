using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Breathing : Activity{
    public Breathing(string name, string description, int duration) : base(name,description,duration){
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
    }
    public void Run(){

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);

        void Breath(){
        Console.Write("\n\nBreath in...");
        ShowCountDown(5);
        Console.Write("\n\nNow Breathe out...");
        ShowCountDown(5);
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        do{
            Breath();
        } while(DateTime.Now < endTime);
        Console.WriteLine("\nWell Done!!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the Breating Activity");
        ShowSpinner(3);
        Console.Clear();
    }
}