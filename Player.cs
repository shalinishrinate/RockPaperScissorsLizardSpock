using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public abstract class Player
    {
        //member variables
        public string name;
        public string gesture;
        public int score;

        public List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        
        //constructor
        public Player() 
        {
            score = 0;
        }

        //methods
        public abstract void ChooseName();

        public abstract void ChooseGesture();
        

    }

}
