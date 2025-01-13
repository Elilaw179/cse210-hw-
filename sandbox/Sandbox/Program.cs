using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your first name? ");
        // string first = Console.ReadLine();

        // Console.Write("What is your last name? ");
        // string last = Console.ReadLine();

        // Console.WriteLine($"Your name is {last}, {first} {last}.");

        // int x = 5;
        // int y = 41;
        // if (x>y){
        //     Console.WriteLine("good");
        // } else{
        //     Console.WriteLine("not really");
        // }

        Console.Write("What is your favorite number?");
        string user = Console.ReadLine();
        int num = int.Parse(user);
        Console.WriteLine($"This is a good digit {num}");

    }
}