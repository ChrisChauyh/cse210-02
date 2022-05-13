using System;

namespace cse210_02
{
    public class Guessing
    {
    public string guess_card { get; set; }
    public static int first_card_number = 0;
    public static int second_card_number = 0;
        public void guessthecard()
        {
            Rule gamesrule = new Rule();
            first_card_number = shuffle(); 
            Console.WriteLine("The card is: " + first_card_number);
            second_card_number = shuffle();
            Console.WriteLine("Higher or lower? [h/l] ");
            guess_card = Console.ReadLine();
            if(guess_card == "h")
            {
                gamesrule.high();
                gamesrule.CorrectOrNot();
            }
            else if (guess_card == "l")
            {
                gamesrule.low();
                gamesrule.CorrectOrNot();
            }
            Console.WriteLine("Next card was: " + second_card_number);
            Console.WriteLine("Your score is: " + Program.playerscores);

        }
        public int shuffle()
        {
            Random rand = new Random();
            int number = rand.Next(1,13);
            if(first_card_number == number)
            {
                ++number;
                return number;
            }
            else if (number == 13)
            {
                --number;
                return number;
            }
            return number;
        }

    }

}