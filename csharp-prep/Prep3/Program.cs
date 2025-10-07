using System;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randNumber = randomGenerator.Next(1, 11);
        string response = "yes";
        while (response == "yes")
        {
            Console.WriteLine("Guess a number: ");
            string answerLine = Console.ReadLine();
            int userNumber = Convert.ToInt32(answerLine);

            if (randNumber > userNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (randNumber < userNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (randNumber == userNumber)
            {
                Console.WriteLine("You got it");
                Console.WriteLine("Would You like to go again? yes or no");
                string choice = Console.ReadLine();

                if (choice == "no")
                {
                    break;
                }
            }
        }

    }
}