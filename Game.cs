using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Game
    {
        // member variables

        Player player1;
        Player player2;


        /*bool isGameSinglePlayer;
        bool isGameMultiPlayer;
        bool gameOver;
        int numberOfGamesPlayed;//result to be decided based on 3 games played between players.
        int numberofGamesWon;

        input from player if he wants to plays against a human or computer???
         gestures;assign values to gestures, for human to choose from and computer can choose random numbers 1-5????
        list of gestures, where should it be accessible? to the players??
         winning/losing combo, would it be  'if else'?
        Human and computer will inherit from player.*/

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

            //player1.DisplayChoices();
          

                player1.GetName();
                player2.GetName();

                player1.ChooseGesture();
                player2.ChooseGesture();

                CompareGestures();

                WinnerScoreIncremented();

                DeclareGameWinner();
            }





            //string Input = GetNumberplayers();
            //Create Players(Input);


        }

        
        public void DisplayRulesOfTheGame()
        {
            Console.WriteLine("This is a best of 3 game. The player with more points at the end of 3 game wins!");

            Console.WriteLine("Same gesture by both players results in a tie.");

            Console.WriteLine("Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock " +
                "\n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors" +
                " \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper" +
                " \nPaper disproves Spock \n Spock vaporizes Rock");

            
        }

        public void CompareGestures()
        {
            Console.WriteLine(player1.gesture);
            Console.WriteLine(player2.gesture);

            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("It is a tie, replay this round again");
            }

            else if (player1.gesture == "Rock" && (player2.gesture == "Scissors" || player2.gesture == "Lizard"))
            {
                Console.WriteLine(player1.name + "Wins!");
            }

            else if (player1.gesture == "Paper" && (player2.gesture == "Rock" || player2.gesture == "Spock"))
            {
                Console.WriteLine(player1.name + "Wins!");
            }

            else if (player1.gesture == "Scissors" && (player2.gesture == "Paper" || player2.gesture == "Lizard"))
            {
                Console.WriteLine(player1.name + "Wins!");
            }

            else if (player1.gesture == "Lizard" && (player2.gesture == "Spock" || player2.gesture == "Paper"))
            {
                Console.WriteLine(player1.name + "Wins!");
            }

            else if (player1.gesture == "Spock" && (player2.gesture == "Rock" || player2.gesture == "Scissors"))
            {
                Console.WriteLine(player1.name + "Wins!");
            }

            else
            {
                Console.WriteLine(player2.name + "Wins!");
            }
       
        }
    }

}