using System;

namespace GuessinGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userGuess;
            int attempts = 0;
            int min = 1;
            int max = 10;
            int dumbHigh = 10;
            int dumbLow = 1;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            do
            {

                Console.WriteLine("Guess a number between 1 through 10: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                attempts = attempts + 1;

                if (userGuess > randomNumber)
                {
                    if (dumbHigh > userGuess)
                    {
                        Console.WriteLine("TOO high!");
                        dumbHigh = userGuess;

                        if (dumbHigh > userGuess)
                        {
                            Console.WriteLine("Uh oh! You guessed higher! You need glasses!");

                        }
                        else
                        {
                            Console.WriteLine("Guess again. ");

                        }
                    }
                    

                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine("TOO low!");
                    dumbLow = userGuess;

                    if (dumbLow > userGuess)
                    {
                        Console.WriteLine("Uh oh! You guessed lower! You need glasses!");

                    }
                    else
                    {
                        Console.WriteLine("Guess again. ");

                    }
                }
                
            } while (userGuess != randomNumber);

            Console.WriteLine("Yay! You guess the right number, it took you {0} times!", attempts);
        }

        
    }
}
