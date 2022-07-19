using System;

namespace NumGuess // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Number  Guesser";
            String version = "1.0";
            string author = "Kevin";

            //Changes all colors that come after it
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcoome to the Game: {1} Version: {2} Made by: {3}", name, version, author);
            Console.ResetColor();

            Console.WriteLine("Please Insert your name: ");
            string playName = Console.ReadLine();
        }
    }   
}