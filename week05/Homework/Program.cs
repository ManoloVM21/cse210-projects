using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        MathAssignment math1 = new MathAssignment("Roberto Rodriguez","Fractions","7.3","8-19");
        string summary = math1.GetSummary();
        string list = math1.GetHomework();
        Console.WriteLine(summary);
        Console.WriteLine(list);

        WrittingAssignment write1 = new WrittingAssignment("Mary Waters","European History","The Causes of World War II");
        string sumaryW = write1.GetSummary();
        string listW = write1.GetWrittingInformation();
        Console.WriteLine(sumaryW);
        Console.WriteLine(listW);
    
    }
}