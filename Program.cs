using System;

namespace cse210_02
{
    public class Program
    {

        public static string continue_game = "y";
        public static string startover = "y";
        public static int playerscores = 300;
        static void Main(string[] args)
        {
        //This is the main program started
        do{
        Guessing guessinggame = new Guessing();
        Rule gamerules = new Rule();
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Welcome to Hilo Game");
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine("Here are the following rules:");
        Console.WriteLine("The player starts the game with 300 points.\nIndividual cards are represented as a number from 1 to 13.\nThe current card is displayed.\nThe player guesses if the next one will be higher or lower.\nThe the next card is displayed.\nThe player earns 100 points if they guessed correctly.\nThe player loses 75 points if they guessed incorrectly.\nIf a player reaches 0 points the game is over.\nIf a player has more than 0 points they decide if they want to keep playing.\nIf a player decides not to play again the game is over.\n");
        Console.ResetColor();
        do{
        guessinggame.guessthecard();
        gamerules.gameover();
        if(Program.playerscores > 0)
        {Console.Write("Do you want to continue guessing? y/n ");
        continue_game = Console.ReadLine();
        startover = "n";
        }
        else if(Program.playerscores <= 0)
        {
            startover = "n";
            continue_game = "n";
            playerscores = 300;
            Console.Write("Do you want to startover? y/n ");
            startover = Console.ReadLine();
        }
        } while (continue_game == "y");

        } while(startover == "y");

        Console.Write("Goodbye!");
        }
    }
}   
