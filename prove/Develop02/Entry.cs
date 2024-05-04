public class Entry
{
    // public string _date;
    // public string _promptText;
    // public string _entryText;

    // public void Display()
    // {

    // }

    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string reponse, string date)
    {
        Prompt = prompt;
        Response = reponse;
        Date = date;

    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}