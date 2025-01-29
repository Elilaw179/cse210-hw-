

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


class Reference
{
    // Stores the scripture reference (e.g., "John 3:16" or "Proverbs 3:5-6").
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int? EndVerse { get; } // Nullable for single verse cases

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue
            ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}"
            : $"{Book} {Chapter}:{StartVerse}";
    }
}

class Word
{
    // Represents a single word in the scripture and tracks if it's hidden
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}

class Scripture
{
    // Handles the scripture text, hiding words, and displaying it
    public Reference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        // Clears the console before displaying
        Console.Clear();
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", Words));
    }

    public void HideWords(int count = 3)
    {
        // Get all visible words
        var visibleWords = Words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count == 0) return; // Stop if all words are hidden

        // Select random words to hide
        Random rand = new Random();
        for (int i = 0; i < Math.Min(count, visibleWords.Count); i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Remove so it isn't selected again
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }
}

class Program
{
    static void Main()
    {
        // Example scripture (you can change this)
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Memorization complete!");
                break;
            }

            Console.Write("\nPress Enter to hide words or type 'quit' to exit: ");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit") break;

            scripture.HideWords();
        }
    }
}
