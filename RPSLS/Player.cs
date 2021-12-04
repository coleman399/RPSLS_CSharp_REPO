using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Player
    {
        internal string[] gestures;
        internal int[] gesture_index;
        internal int wins;

        internal Player()
        {
            gestures = new string[] {"rock", "paper", "scissors", "lizard", "spock" };
            gesture_index = new int[] { 1, 2, 3, 4, 5 }; 
            wins = 0;
        }
    }
}
