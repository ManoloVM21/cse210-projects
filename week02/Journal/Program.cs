using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        string option = "";
        Journal theJournal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        while (option != "6") {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Edit \n6. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();
            

            if (option == "1")
            {
            
            Entry entry1 = new Entry();
            
            string question = prompt.GetRandomPrompt();
            entry1._promptText = question;
            Console.Write($"{entry1._promptText}\n> ");
            entry1._entryText = Console.ReadLine();

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            entry1._date = dateText;

            theJournal.AddEntry(entry1);
            }
            if (option == "2")
            {
                theJournal.DisplayAll();
            }
            if (option == "3")
            {
                Console.Write("What is the file name? ");
                string textFile = Console.ReadLine();
                theJournal.LoadFromFile(textFile);
            }
            if (option == "4") 
            {
                Console.Write("What is the name of the file? ");
                string textFile = Console.ReadLine(); 
                theJournal.SaveToFile(textFile);
            }
            if (option == "5")
            {
                theJournal.Editor();
            }
        
        Car car1 = new Car();
        car1._brand = "Toyota";
        car1._year = 2022;
        car1._owner = "Martin Harris";

        Car car2 = new Car();
        car2._brand = "Hundai";
        car2._year = 2022;
        car2._owner = "Oliver Cowdery";
        
        }
    }
};