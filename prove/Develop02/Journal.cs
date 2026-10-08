using System.IO.Compression;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void DisplayJournal()
    {
        foreach(Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateJournalEntry()
    {
        Entry newEntry = new Entry();
        newEntry.CreateEntry();
        _entries.Add(newEntry);
    }
}