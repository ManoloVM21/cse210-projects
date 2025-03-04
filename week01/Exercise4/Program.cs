using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        do{
        Console.Write("Enter number: ");
        string usern = Console.ReadLine();
        number = int.Parse(usern);
        numbers.Add(number);

        } while (number != 0);

        int smallest_pos=10000;
        foreach (int num in numbers)
        {
            if (num < smallest_pos && num > 0)
            {
                smallest_pos = num;
            } 
        }
        numbers.Sort();
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {smallest_pos}");
        Console.WriteLine("This is the sorted list:");
        foreach (int numb in numbers)
        {
            Console.Write($"{numb} ");
        }
    }
}