using System;

namespace cse210_02
{
    public class Rule
    {
        string correct = "";
        public void CorrectOrNot()
        {
            if (correct == "good")
            {
                Program.playerscores += 100;
            }
            else if (correct == "bad")
            {
                Program.playerscores -= 75;
            }
        }
        public void high()
        {
            if(Guessing.first_card_number < Guessing.second_card_number)
            {
                correct = "good";
            }
            else
            {
                correct = "bad";
            }
        }
        public void low()
        {
            if(Guessing.first_card_number > Guessing.second_card_number)
            {
                correct = "good";
            }
            else
            {
                correct = "bad";
            }
            
        }
        public void gameover()
        {
            if(Program.playerscores >= 0)
            {
                Program.continue_game = "n";
                Console.WriteLine("Sorry, you have lower 0 points, you lost......");
            }
        }
        

    }
}