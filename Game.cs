using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Game
    { 
       //what info/data/variables does a game require to be played
        Player player1;
        Player player2;
        bool isGameSinglePlayer;
        bool isGameMultiPlayer;
        bool gameOver;
        int numberOfGamesPlayed;//result to be decided based on 3 games played between players.
        int numberofGamesWon;

        //input from player if he wants to plays against a human or computer???
        // gestures;assign values to gestures, for human to choose from and computer can choose random numbers 1-5????
        //list of gestures, where should it be accessible?to the players??
        // winning/losing combo, would it be  'if else'?
        //Human and computer will inherit from player. 

        public Game()
        {
          
        }

        public void RunGame()   // master method
        {
            DisplayRulesOfTheGame();

            Console.WriteLine("Would you like to play against a Human? [yes] or [no]");
            string playerInput = Console.ReadLine();
            if (playerInput == "yes")
            {
              
                player1 = new Human();
                player2 = new Human();
            }
            else
            {
                player2 = new Computer();
                player1 = new Human();
            }
        }

        public void DisplayRulesOfTheGame()
        {
            Console.WriteLine("This is a best of 3 game. So a player who wins 2 out of 3 game wins!");

            Console.WriteLine("Rock crushes Scissors");

            Console.WriteLine("Scissors cuts Paper");

            Console.WriteLine("Paper covers Rock");

            Console.WriteLine("Rock crushes Lizard");

            Console.WriteLine("Lizard poisons Spock");

            Console.WriteLine("Spock smashes Scissors");

            Console.WriteLine("Spock smashes Scissors");

            Console.WriteLine("Scissors decapitates Lizard");

            Console.WriteLine("Lizard eats Paper");

            Console.WriteLine("Paper disproves Spock");

            Console.WriteLine("Spock vaporizes Rock");

            Console.WriteLine("the rules");



        }
    }
}
