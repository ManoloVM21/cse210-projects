using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the ExerciseTracking Project!");
        Console.WriteLine("I will show you the results tracked for each activity at the gym.\n");

        List<Activity> activities = new List<Activity>();
        Running running = new Running(20,40.5);
        activities.Add(running);

        Cycling cycling = new Cycling(50,120.3);
        activities.Add(cycling);

        Swimming swimming = new Swimming(70,30);
        activities.Add(swimming);

        foreach(Activity activity in activities){
            string strrep = activity.GetSummary();
            Console.WriteLine(strrep);
        }
    }   
}