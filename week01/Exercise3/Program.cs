using System;

class Program
{
    static void Main(string[] args)
    {
        //First and second stage
       
        
        // Stage 3---- random number
        Random randomNum = new Random();
        int magicNum = randomNum.Next(1, 101);

        int guess = -1;

        //  using a do-while loop 
        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNum> guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}