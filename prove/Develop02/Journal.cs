public class Journal
{
    List<Entry> _entries = new List<Entry>();
    

    public Journal()
    {}

    public void AddEntry()
    {
        //making this new entry right here is vital, otherwise it will change the whole list, i don't know why it does this.
        Entry _currentEntry = new Entry();
        _currentEntry.displayAndSetPrompt();
        _currentEntry.writeEntry();
        _entries.Add(_currentEntry);
    }

    public void displayJournal()
    {
        int index = 0;
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("----------------");
            _entries[index].displayEntry();
            Console.WriteLine("----------------");
            index++;        
        }

    }

    public void saveEntries(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.returnEntryFormatted());
            }
        }
    }

    public void LoadEntries(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            //splits it into parts into a string array
            string[] parts = line.Split("|");

            Entry tempEntry = new Entry();

            tempEntry.inputFromLoad(parts[0],parts[1],parts[2]);
            _entries.Add(tempEntry);
        }
    }
}