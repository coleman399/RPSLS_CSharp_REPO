using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Human: Player
    {
        internal string name;
        
        internal Human(string player)
        {
            this.name = player; 
        }
    }
}
