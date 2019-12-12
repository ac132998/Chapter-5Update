using System;

namespace GuessinGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;
            int attempts = 0;
            int min = 1;
            int max = 100;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            Console.WriteLine("Enter a number between 1 through 100: ");
            userEntry = Convert.ToInt32(Console.ReadLine());
            attempts = attempts + 1;

            do
            {
                if (userEntry > randomNumber)
                {

                    Console.WriteLine("Too Low! Try again!");
                    userEntry = Convert.ToInt32(Console.ReadLine());
                    attempts = attempts + 1;

                 
                }

                
                else if (userEntry > randomNumber)
                {
                    Console.WriteLine("Too High! Try again!");
                    userEntry = Convert.ToInt32(Console.ReadLine());
                    attempts = attempts + 1;

   
                }



            } while (userEntry != randomNumber);

            Console.WriteLine("Yay! You guess the right number, it took you {0} times!", attempts);
        }

        
    }
}
