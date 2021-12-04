using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class RunGame
    {
        Human player1 = new Human("Player 1");
        Human player2 = new Human("Player 2");
        Computer computer = new Computer();

        internal RunGame()
        {
            welcome();
            rules();
            gameMode();
        }

        static void welcome()
        {
            Console.WriteLine("\n--- Welcome to Rock Paper Sissiors Lizard Spock! ---");
        }

        static void rules()
        {
            Console.WriteLine("\n--- SO THESE ARE THE RULES OF THE GAME ---\n");
            Console.WriteLine("Rock beats Sissciors, and Rock beats Lizard!");
            Console.WriteLine("Paper beats Rock, and Paper beats Spock!");
            Console.WriteLine("Sissiors beats paper, and Sissiors beats Lizard!");
            Console.WriteLine("Lizard beats paper, and Lizard beats Spock!");
            Console.WriteLine("Spock beats Rock, and Spock beats Sissiors!\n\nKeep these in mind when taking your pick for the round!");
            Console.WriteLine("\n--- This is a best 2 out of 3 game! ---\n");
        }

        static bool gameMode()
        {
            try
            {
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return true;
        }
    }
}
