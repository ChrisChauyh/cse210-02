using System;

namespace cse210_02
{
    public class Rule
    {
        //This class is for setting up ruls and provide output for Guessing class
        string correct = "";
        public void CorrectOrNot()
        {
            //Check if the player guessed the correct range
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
            //see if higher is correct
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
            //check if lower is correct
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
            //run if player got lower than 0
            if(Program.playerscores <= 0)
            {
                Console.WriteLine("Sorry, you have lower than 0 points, you lost......");
                Console.WriteLine("Thanks for playing!");
            }
        }
        

    }
}