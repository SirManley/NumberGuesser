using System;
using System.Net.NetworkInformation;

// Namespace
namespace NumberGuesser
{
    //<Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Run GetAppInfo function
          GetAppInfo();

            // Greet user method
            GreetUser();

            while (true)
            {

                // Set correct number
                //int correctNumnber = 7;

                // Create a new Randome object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Init correct number
                int guess = 0;

                // Ask for a number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message Wrong number
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Output success method

                PrintColorMessage(ConsoleColor.Yellow, "Correct!");


                // Ask user if they want to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }

                else if (answer == "N")
                {
                    return;
                }

                else
                {
                    // Print error message Wrong answer
                    PrintColorMessage(ConsoleColor.Red, "Answer needed to be Y or N.  The program will exit now");
                    //PlayAgain();
                    return;

                }

            }
           static void GetAppInfo ()
            {
                // Set app variables
                string appName = "Number Guesser";
                string appVersion = "1.0.0";
                string appAuthor = "Ryan Manley";

                // Change text color
                Console.ForegroundColor = ConsoleColor.Green;

                // Write out app info
                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

                // Reset text color
                Console.ResetColor();
            }

            static void GreetUser()
            {
                // Ask users name
                Console.WriteLine("What is your name?");

                // Get user input
                string inputName = Console.ReadLine();

                Console.WriteLine("Hello {0}, let's play a game...", inputName);
            }

            static void PrintColorMessage(ConsoleColor color, string message) 
            {
                // Change text color
                Console.ForegroundColor = color;

                // Tell user its not a number
                Console.WriteLine(message);

                // Reset text color
                Console.ResetColor();
            }
        }
    }
}