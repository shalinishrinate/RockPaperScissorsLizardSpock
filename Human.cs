﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Human:Player
    {
        public override void ChooseName()
        {
            Console.WriteLine("Please type your name.");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + name + " , welcome to the Rock Paper Scissors Lizard Spock game.");
            Console.WriteLine("Please press the Enter key to continue.");
            Console.ReadLine();
           
        }
        
        public override void ChooseGesture()
        {
            Console.WriteLine(name + " , what gesture do you choose to play? Please type in the number " +
                                      "displayed next to the gesture of your choice \n" +
                                       "1. Rock \n" +
                                       "2. Paper \n" +
                                       "3. Scissors \n" +
                                       "4. Spock \n" +
                                       "5. Lizard \n");

            string input = Console.ReadLine();

            Console.WriteLine("Please press the Enter key.");

            switch (input)
            {
                case "1":
                    gesture = "Rock";
                    break;
                case "2":
                    gesture = "Paper";
                    break;
                case "3":
                    gesture = "Scissors";
                    break;
                case "4":
                    gesture = "Spock";
                    break;
                case "5":
                    gesture = "Lizard";
                    break;
                case "quit":
                    Console.WriteLine("Sorry to see you go, hoping you will be back soon!");
                    break;
                default:
                    Console.WriteLine("This is not a valid choice. Please type in one of the numbers 1,2,3,4,5 " +
                        "or exit the game by typing quit.");
                    break;
            }

        }

        
    }
}
