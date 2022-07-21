using System;

namespace NumGuess // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoOfApp();
            bool playGame = true;
            
            while (playGame) 
            {
                string name = PlayerInfo();
                GameLogic(name);
                playGame = KeepPlaying();
            }
        }


        static void InfoOfApp()
        {
            string name = "Number  Guesser";
            String version = "1.0";
            string author = "Kevin";

            //Changes all colors that come after it
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcoome to the Game: {0} Version: {1} Made by: {2}", name, version, author);
            Console.ResetColor();
        }

        static string PlayerInfo()
        {
            Console.WriteLine("Please Insert your name: ");
            string playerName = Console.ReadLine();
          
            Console.WriteLine("Hi welocme {0}, let start playing!", playerName);
            return playerName;
        }


        static void GameLogic(string nameOfPlayer)
        {
            Random random = new Random();
            int correctAnswer = random.Next(1, 10);
            int playersAnswer = 0;
            bool correctWinner = playersAnswer != correctAnswer;
            Console.WriteLine("Give us your first guessnumber from 1 to 10: ");

            while (correctWinner)
            {
                string input = Console.ReadLine();

                if (!(int.TryParse(input, out playersAnswer)))
                {
                    Console.WriteLine("Sorry but {0} is not a number. Try again", input);
                    continue;
                }

                playersAnswer = int.Parse(input);
                correctWinner = playersAnswer != correctAnswer;
                if (correctWinner)
                {
                    Console.WriteLine("Sorry but {0} is not the correct answer. Try again", playersAnswer);
                }

            }

            Console.WriteLine("Congratulation {0}! The correct number was indeed {1}.", nameOfPlayer, playersAnswer);

        }


        static bool KeepPlaying()
        {
            bool playerDecision = false;
            Console.WriteLine("Do you want to play another guessing game?");
            Console.WriteLine("Type N for NO or Y for Yes!");

            while (true)
            {
                string inputReceived = Console.ReadLine();
                string userInput = inputReceived.ToUpper();
                if (userInput == "Y" || userInput == "N")
                {
                    switch (userInput)
                    {
                        case "Y":
                            playerDecision = true;
                            Console.WriteLine("Let's start again! :)");
                            break;
                        case "N":
                            Console.WriteLine("Goodbye! Hope to see you next time!");
                            playerDecision = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry but {0} is not a valid input. Choose Y or N .Try again", inputReceived);
                    continue;
                }

                break;
            }
            return playerDecision;
        }
    }   
}