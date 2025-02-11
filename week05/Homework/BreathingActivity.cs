class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity helps you relax by guiding your breathing in and out slowly. Focus on your breath.") { }

    protected override void RunActivity()
    {
        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            elapsedTime += 3;

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            elapsedTime += 3;
        }
    }
}
