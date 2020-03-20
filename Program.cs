using System;

namespace csharpprojects
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();


            Console.WriteLine("Whats is your name?");
            
            string inputUserName = Console.ReadLine();

            Console.WriteLine("\n Hello {0}, lets play!\n", inputUserName);

            //int winnerNumber = 7;
            int guessNumber = 0;

            Random randomNumber = new Random();

            int winnerNumber = randomNumber.Next(1, 10);

            Console.WriteLine("This is a Guess-The-Number game. Please guess the number between 1 and 10");
            

            while (guessNumber != winnerNumber )
            {
                string inputGuess = Console.ReadLine();

                if(!int.TryParse(inputGuess, out guessNumber)){
                    ColorText(ConsoleColor.Red , "Thats is not a number.");
                    continue;
                }

                guessNumber = Int32.Parse(inputGuess);

                if (guessNumber != winnerNumber){
                    ColorText(ConsoleColor.Red ,"Wrong number, try again!");
                } else {
                    ColorText(ConsoleColor.Yellow ,"That is the correct number! You win!");
                }

            }

        }

        static void GetAppInfo()
        {
            string appName = "Number guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Felix Anducho";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("App name: {0}.\n App version {1}.\n Author: {2}.\n", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void ColorText (ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(text);

            Console.ResetColor();
        }        
    }
}

