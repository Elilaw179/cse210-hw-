using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {Name}.");
        Console.WriteLine(Description);
        Console.Write("Enter duration (in seconds): ");
        Duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(3);  // Prepare animation
        Console.Clear();

        RunActivity();
        EndActivity();
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in {i} seconds...  ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected abstract void RunActivity();

    private void EndActivity()
    {
        Console.WriteLine($"Good job! You have completed the {Name} for {Duration} seconds.");
        ShowSpinner(3);
    }
}
