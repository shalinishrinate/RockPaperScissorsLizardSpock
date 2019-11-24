using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Human:Player
    {
        public override void GetName()
        {
            Console.WriteLine("Please type your name.");
            name = Console.ReadLine();
            Console.WriteLine("Hello" + name + "Welcome to the Rock Paper Scissors Lizard Spock game.");
        }
        public string GetInputOnGesture()
        {
            Console.WriteLine(name + " What gesture do you choose?"
               + "1. Rock\n"
               + "2. Paper\n"
               + "3. Scissors\n"
               + "4. Spock\n"
               + "5. Lizard\n");

            string input = Console.ReadLine();
            return input;
        }

        public void GestureChoice(string input)
        {
            switch (input)
            {
                case "1":
                    gesture = "You chose Rock.";
                    break;
                case "2":
                    gesture = "You chose Paper.";
                    break;
                case "3":
                    gesture = " You chose Scissors.";
                    break;
                case "4":
                    gesture = "You chose Spock.";
                    break;
                case "5":
                    gesture = "You chose Lizard.";
                    break;
                default:
                    Console.WriteLine("This is not a valid choice.\n");
                    break;
            }

        }

        // public override void chooseGestures()

        //pubic override void chooseName();

    }
}
