class ListingActivity : Activity
{
    private List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", 
        "This activity helps you reflect on the good things in your life by listing positive things.") { }

    protected override void RunActivity()
    {
        Random rnd = new Random();
        Console.WriteLine(Prompts[rnd.Next(Prompts.Count)]);
        ShowCountdown(3);

        List<string> responses = new List<string>();
        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.Write("Enter an item: ");
            responses.Add(Console.ReadLine());
            elapsedTime += 3;
        }

        Console.WriteLine($"You listed {responses.Count} items.");
        ShowSpinner(3);
    }
}
