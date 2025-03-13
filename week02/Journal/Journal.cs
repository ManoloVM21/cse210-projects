using System.IO;

public class Journal{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry) 
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry line in _entries)
        {
            line.Display();
        };
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputfile = new StreamWriter(file))
        {
            foreach (Entry line in _entries)
            {
                outputfile.WriteLine($"{line._date}|{line._promptText}|{line._entryText}");           
            }
            Console.WriteLine($"Journal saved successfully to {file}");
        }
    }
    public void LoadFromFile(string file)
    {
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                    
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2],
                };
                _entries.Add(entry);
            }
            Console.WriteLine($"Journal loaded successfully from {file}");
    }
}