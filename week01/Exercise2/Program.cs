using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        
        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >=80)
        {
            letter = "B";
        }    
        else if (number >=70)
        {
            letter = "C";
        }
        else if (number >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You reached a {letter}");
        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You didn't pass. You can do it better next time!");
        }

    }
}