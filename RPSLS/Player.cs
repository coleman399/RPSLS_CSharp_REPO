using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Player
    {
        string[] gestures;
        int wins;

        internal Player()
        {
            gestures = new string[] {"rock", "paper", "scissors", "lizard", "spock" };
            wins = 0;
        }
    }
}
