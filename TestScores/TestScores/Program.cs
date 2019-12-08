using System;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int total = 0;
            int score = 0;
            int sentinalValue = 999;
            double average;
            int counter = 0;

            Console.WriteLine("Enter 999 to stop entering values and figure your average");

            while (score != sentinalValue)
            {
                Console.Write("Enter a value between 0 and 100 >>>>> ");
                input = Console.ReadLine();
                score = Convert.ToInt32(input);
                if (score >= 0 && score <= 100)
                {
                    total = total + score;

                    counter++;
                }
                else if (score != 999)
                {
                    Console.WriteLine("You entered an incorrect value, try again");
                }
                else
                {
                    Console.WriteLine();
                }
                    

            }
            average = total / counter;
            Console.WriteLine("You entered {0} test scores and your overall average is: {1}", counter, average);
        }
    }
}
