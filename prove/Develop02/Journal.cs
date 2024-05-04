public class Journal
{
    private List<Entry> entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Prompt: {entry.Prompt}");
                writer.WriteLine($"Response: {entry.Response}");
                writer.WriteLine();
            }
        }

    }

    public void LoadFromFile(string file)
    {
        entries.Clear();

        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string date = line.Substring(line.IndexOf(':') + 2);
                string prompt = reader.ReadLine().Substring(line.IndexOf(':') + 2);
                string response = reader.ReadLine().Substring(line.IndexOf(':') + 2);

                entries.Add(new Entry(prompt, response, date));
                reader.ReadLine(); // Read blank line
            }
        }

    }
}