using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string answer = "0";
        int numberBreaths = 0;
        int numberReflects = 0;
        int numberLists = 0;
        do{
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing Activity");
            Console.WriteLine(" 2. Start reflecting Activity");
            Console.WriteLine(" 3. Start listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();

            
        if (answer == "1"){
            Breathing breath1 = new Breathing("","",20);
            Console.Clear();
            breath1.DisplayStartingMessage();
            
            Console.Write("How long, in seconds, would you like your session? ");
            string asnw2 = Console.ReadLine();
            int secs = int.Parse(asnw2);
            breath1 = new Breathing("","",secs);
            breath1.Run();
            numberBreaths++;
        }
        if (answer == "2"){
            Reflecting ref1 = new Reflecting("Reflecting","This activity..",20);
            Console.Clear();
            ref1.DisplayStartingMessage();

            Console.Write("How long, in seconds, would you like your session? ");
            string asnw2 = Console.ReadLine();
            int secs = int.Parse(asnw2);
            ref1 = new Reflecting("","",secs);
            ref1.Run();
            numberReflects++;
        }
        if (answer == "3"){
            Listing list1 = new Listing("Listing","This activity..",20);
            Console.Clear();
            list1.DisplayStartingMessage();

            Console.Write("How long, in seconds, would you like your session? ");
            string asnw2 = Console.ReadLine();
            int secs = int.Parse(asnw2);
            list1 = new Listing("","",secs);
            list1.Run();
            numberLists++;
        }
        } while (answer != "4");

        if (answer == "4"){
            Console.WriteLine($"Thank You! You have done\nBreathing Activities: {numberBreaths}\nReflecting Activities: {numberReflects}\nListing Activities: {numberLists}\n\nHave a great day!");
        }

        
    }
}