using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class RunGame
    {
        private Human player1;
        private Human player2;
        private Computer computer;

        internal RunGame()
        {
            player1 = new Human("Player 1");
            player2 = new Human("Player 2");
            computer = new Computer();
        }

        internal void Run()
        {
            Welcome();
            Rules();
            bool _gameMode = GameMode();
            if (_gameMode == true)
            {
                //PvPGame();
            } 
            else
            {
                //PvEGame();
            }
        }

        static void Welcome()
        {
            Console.WriteLine("\n--- Welcome to Rock Paper Sissiors Lizard Spock! ---");
        }

        static void Rules()
        {
            Console.WriteLine("\n--- SO THESE ARE THE RULES OF THE GAME ---\n");
            Console.WriteLine("Rock beats Sissciors, and Rock beats Lizard!");
            Console.WriteLine("Paper beats Rock, and Paper beats Spock!");
            Console.WriteLine("Sissiors beats paper, and Sissiors beats Lizard!");
            Console.WriteLine("Lizard beats paper, and Lizard beats Spock!");
            Console.WriteLine("Spock beats Rock, and Spock beats Sissiors!\n\nKeep these in mind when picking each round!");
            Console.WriteLine("\n--- This is a best 2 out of 3 game! ---\n");
        }

        static bool GameMode()
        {
            string user_input = "";
            do
            {
                Console.WriteLine("Please select your game mode:\nEnter 1 for Player VS Player.\nEnter 2 for Player VS AI.\nSelection: ");
                user_input = Console.ReadLine();
                if (user_input == "1")
                {
                    Console.WriteLine("\n--- PVP GAME--- ");
                    return true;
                }
                else if (user_input == "2")
                {
                    Console.WriteLine("\n--- PVE GAME--- ");
                    return false;
                }
                else
                {
                    Console.WriteLine("Please provide acceptable input.");
                }
            } 
            while (user_input != "1" || user_input != "2");

            return false;
        }

        private void ListGestures()
        {
            Console.WriteLine("Please enter a number for your gesture you want to select:");
            var gesturesList = player1.gesture_index.Zip(player1.gestures, (first, second) => first + " " + second);
            foreach (var gesture in gesturesList)
            {
                Console.WriteLine(gesture);
            }
        }

        private void PvPGame()
        {
            string player1_input;
            string player2_input;
            bool player1_input_verification;
            bool player2_input_verification;
            Gestures player1_gesture;
            do
            {
                ListGestures();
                player1_input = Console.ReadLine();
                int player1_gesture_index = GetIndex(player1_input);
                player1_input_verification = GetVerification(player1_gesture_index);
                if (player1_input_verification)
                {
                    player1_gesture = new Gestures(player1.gestures[player1_gesture_index]);
                }
                else
                {
                    PvPGame();
                }
                ListGestures();
                player2_input = Console.ReadLine();


            }
            while (player1.wins != 2 && player2.wins != 2 || player1_input_verification != true && player2_input_verification != true);  
        }

        static int GetIndex(string player_input)
        {
            if (player_input == "1")
            {
                return 0;
            }
            else if (player_input == "2")
            {
                return 1;
            }
            else if (player_input == "3")
            {
                return 2;
            }
            else if (player_input == "4")
            {
                return 3;
            }
            else if (player_input == "5")
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        static bool GetVerification(int player_gesture_index)
        {
            if (player_gesture_index == 5)
            {
                Console.WriteLine("Please Provide An Acceptable Input.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
