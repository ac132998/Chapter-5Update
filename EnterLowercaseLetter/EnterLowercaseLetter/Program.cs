using System;

namespace EnterLowercaseLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string userEntry;
            char input;

            do
            {
                Console.WriteLine("Enter a Lowercase letter >>>");
                userEntry = Console.ReadLine();
                input = Convert.ToChar(userEntry);

                if (input >= 'a' && input <= 'z')
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Error! Not a lowercase number");
                }
                    
                    Console.WriteLine("Enter a ! to quit");
                

            } while (userEntry != "!");


            
        }
    }
}
