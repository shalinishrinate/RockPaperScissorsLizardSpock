using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Computer : Player
    {

        public override void ChooseName()
        {
            name = "Computer";
        }

        public override void ChooseGesture()
        {
            Random rnd = new Random();
            gesture = gestures[rnd.Next(gestures.Count)];
            Console.WriteLine(name + " chose " + gesture);
            Console.WriteLine("Please press Enter key.");
        }

    }
}

