using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        string option = "";
        Journal theJournal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        while (option != "5") {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
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

        
        }
    }
};