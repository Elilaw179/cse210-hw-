class ReflectionActivity : Activity
{
    private List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different from other times?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind for the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", 
        "This activity helps you reflect on times when you showed strength and resilience.") { }

    protected override void RunActivity()
    {
        Random rnd = new Random();
        Console.WriteLine(Prompts[rnd.Next(Prompts.Count)]);
        ShowSpinner(3);

        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.WriteLine(Questions[rnd.Next(Questions.Count)]);
            ShowSpinner(4);
            elapsedTime += 4;
        }
    }
}
