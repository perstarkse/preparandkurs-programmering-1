using System;
namespace Gissa20
{
    class Gissa20
    {
        static void Main(string[] args)
        {
            Random newRandom = new Random();
            int randomNumber = newRandom.Next(1, 21);
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Var god gissa på ett tal mellan 1-20.");
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    if (guess > randomNumber)
                    {
                        Console.WriteLine("Din gissning var för hög!");
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Din gissning var för låg!");
                    }
                    else if (guess == randomNumber)
                    {
                        Console.WriteLine("Gissningen var korrekt! Grattis!");
                        isRunning = false;
                    }

                else
                    {
                        Console.WriteLine("du måste skriva en siffra");
                    }
                }
            }
        }
    }
}