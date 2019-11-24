using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public abstract class Player
    {
        public string gesture;

        public List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        public string name;
        public int score;
       
        public void DisplayChoices()
        {
            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
        }
        public abstract void GetName();
        



    // string name
    //string gesture


    //abstract void chooseGesture()

    //abstract void chooseName()
}


    }
