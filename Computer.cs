using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Computer : Player
    {

        // public override void ChooseGesture()
        //{  //random , turning them }
        public override void GetName()
        {
            name = "Computer";
        }

        //public int RandomNumber(int min, int max)
        //{
        //    Random random = new Random();
        //    string randomgesture =  random.Next(1, 6);
        //}
        public void GestureChoice(string input)
    {
            Random rnd = new Random();
            string randomgestures = gestures[rnd.Next(gestures.Count)];
            Console.WriteLine(randomgestures);
        }

    }
}

