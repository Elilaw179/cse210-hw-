using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _text;

    public Entry(string prompt, string text)
    {
        _date = DateTime.Now.ToShortDateString(); // Store the current date as a string
        _prompt = prompt;
        _text = text;
    }

    public string Display()
    {
        return $"{_date} - {_prompt}\n{_text}";
    }

    public string ToSaveFormat()
    {
        return $"{_date}|{_prompt}|{_text}";
    }

    public static Entry FromSaveFormat(string data)
    {
        string[] parts = data.Split('|');
        if (parts.Length == 3)
        {
            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];
            return new Entry(prompt, text) { _date = date }; // Restore the saved date
        }
        return null;
    }
}
