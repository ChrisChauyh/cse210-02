using System;

namespace cse210_02
{
    public class Program
    {

        public static string continue_game = "y";
        public static int playerscores = 300;
        static void Main(string[] args)
        {
        Guessing guessinggame = new Guessing();
        Rule gamerules = new Rule();
        Console.WriteLine("Welcome to Hilo Game");
        Console.WriteLine("Here are the following rules:");

        do{


        guessinggame.guessthecard();
        gamerules.gameover();


        Console.Write("Do you want to continue guessing? y/n ");
        continue_game = Console.ReadLine();


        } while (continue_game == "y");

        Console.WriteLine("Thanks for playing!");
        }
    }
}   
