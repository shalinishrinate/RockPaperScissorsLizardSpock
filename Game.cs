﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Game
    {
        //member variable
        Player player1;
        Player player2;

        public void RunGame()   // master method
        {
            DisplayRulesOfTheGame();
            string input = GetNumberPlayers();
            CreatePlayers(input);

            player1.ChooseName();
            player2.ChooseName();

            player1.ChooseGesture();
            Console.ReadLine();
            Console.Clear();//to show that player2 is not making his choice based on player1's choice.

            player2.ChooseGesture();
            Console.ReadLine();
            Console.Clear();

            CompareGestures();
            Console.ReadLine();

            IncrementWinnerScore();
            Console.ReadLine();

            LoopGame();

            DecidingTheGameWinner();

            PlayAnotherGame();

        }

        public void RunAnotherRoundOfGame() // had to do this for rounds after round 1, so that it does not repeat from name choosing etc.
        {
            player1.ChooseGesture();
            Console.ReadLine();
            Console.Clear();

            player2.ChooseGesture();
            Console.ReadLine();
            Console.Clear();

            CompareGestures();
            Console.ReadLine();

            IncrementWinnerScore();
            Console.ReadLine();

            LoopGame();

            DecidingTheGameWinner();

            PlayAnotherGame();
        }

        public void DisplayRulesOfTheGame()
        {
            Console.WriteLine("As SHELDON from BIG BANG THEORY famously said..");

            Console.WriteLine(); //this and the following ones are just to give space between 2 lines, for better readablity.

            Console.WriteLine("\"For the record, IT COULD KILL US TO MEET NEW PEOPLE.\n" +
                              "They could be MURDERERS or the CARRIERS of unusual PATHOGENS.\n" +
                               "And I'm not insane, my mother had me tested.\" ");

            Console.WriteLine();

            Console.WriteLine("So lets not meet people! But play ROCK PAPER SCISSORS LIZARD SPOCK online!");

            Console.WriteLine();

            Console.WriteLine("This is a best of 3 game. The player with more points at the end of 3 game wins!");

            Console.WriteLine();

            Console.WriteLine("Same gesture by both players results in a tie.");

            Console.WriteLine();

            Console.WriteLine("Given below is how the gestures will be compared.");

            Console.WriteLine();

            Console.WriteLine("Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard " +
                " \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard" +
                " \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock" +
                " \n (and as it always has) Rock crushes Scissors");

            Console.WriteLine();

            Console.WriteLine("Good Luck!");

            Console.WriteLine();

            Console.WriteLine("Press Enter to continue."); //after the rules were displayed, the player wouldnt know what to do, hence this line.

            Console.ReadLine();

        }

        public string GetNumberPlayers()
        {
            Console.WriteLine("Who would you like to play against? " +
                               "Type 1 if against a Computer or " +
                               "Type 2 if against another Human");

            string numberOfPlayers = Console.ReadLine();

            if (numberOfPlayers == "1" || numberOfPlayers == "2")
            {
                CreatePlayers(numberOfPlayers);
            }

            else
            {
                switch (numberOfPlayers)
                {
                    case "quit":
                        Console.WriteLine("Sorry to see you go, hoping you will be back soon!");
                        Environment.Exit(0);  // did a search on how to quit and on stackoverflow it was suggested Environment.Exit(0) 
                        break;

                    default:
                        Console.WriteLine("Please type in either 1 or 2, or exit the game by typing quit.");
                        Console.WriteLine(); // this will give the player an option to type in again
                        break;
                }
            }
            return numberOfPlayers;
        }

        public void CreatePlayers(string numberOfPlayers)
        {

            if (numberOfPlayers == "1")
            {
                player1 = new Human();
                player2 = new Computer();
            }

            else
            {
                player1 = new Human();
                player2 = new Human();
            }

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
                Console.WriteLine(player1.name + " Wins!");
                player1.score++;
            }

            else if (player1.gesture == "Paper" && (player2.gesture == "Rock" || player2.gesture == "Spock"))
            {
                Console.WriteLine(player1.name + " Wins!");
                player1.score++;
            }

            else if (player1.gesture == "Scissors" && (player2.gesture == "Paper" || player2.gesture == "Lizard"))
            {
                Console.WriteLine(player1.name + " Wins!");
                player1.score++;
            }

            else if (player1.gesture == "Lizard" && (player2.gesture == "Spock" || player2.gesture == "Paper"))
            {
                Console.WriteLine(player1.name + " Wins!");
                player1.score++;
            }

            else if (player1.gesture == "Spock" && (player2.gesture == "Rock" || player2.gesture == "Scissors"))
            {
                Console.WriteLine(player1.name + " Wins!");
                player1.score++;
            }

            else
            {
                Console.WriteLine(player2.name + " Wins!");
                player2.score++;
            }

        }

        public void IncrementWinnerScore()
        {
            Console.WriteLine("The current scores are: \n" + player1.name + " : " + player1.score + "\n" + player2.name + " : " + player2.score);
        }
        public void LoopGame()
        {
            while (true)
            {
                if (player1.score == 2 || player2.score == 2)
                {
                    break;
                }
                else
                {
                    RunAnotherRoundOfGame();
                }
            }
        }
        public void DecidingTheGameWinner()
        {
            if (player1.score == 2)
            {
                Console.WriteLine("Congratulations " + player1.name + ", you are the WINNER!");
                Console.WriteLine();

            }
            else if (player2.score == 2) // for a long time could not understand why 'else' wasnt working, then realised there is a condition and then changed to else if.
            {
                Console.WriteLine("Congratulations " + player2.name + ", you are the WINNER!");
                Console.WriteLine();
            }
        }

        public void PlayAnotherGame()
        {
            Console.WriteLine("Thank you for playing ROCK PAPER SCISSORS LIZARD SPOCK! Press 1 to quit, or press any key to play again!");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("See you soon!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("");
                    RunGame();
                    break;
            }
        }
    }
}