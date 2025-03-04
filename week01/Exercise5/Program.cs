using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string nameuser = Console.ReadLine();
            return nameuser;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string fav = Console.ReadLine();
            int favnum = int.Parse(fav);
            return favnum;
        }
        static int SquareNumber(int number)
        {
            number = number * number;
            return number;
        }
        static void DisplayResult()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int numb =PromptUserNumber();
            int sqnumb = SquareNumber(numb);
            Console.WriteLine($"{name}, the square of your number is {sqnumb}");
        }
        DisplayResult();
    }
}