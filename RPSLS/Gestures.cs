using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Gestures
    {
        //variables
        string rock;
        string paper;
        string scissors;
        string lizard;
        string spock;
        List<string> defeats;
        private string input;

        //constuctor
        internal Gestures(string input)
        {
            rock = "rock";
            paper = "paper";
            scissors = "scissors";
            lizard = "lizard";
            spock = "spock";
            defeats = new List<string>();
            this.input = input;

            if (input == rock)
            {
                defeats.Add(scissors);
                defeats.Add(lizard);
            }
            else if (input == paper)
            {
                defeats.Add(rock);
                defeats.Add(spock);
            }
            else if (input == scissors)
            {
                defeats.Add(paper);
                defeats.Add(lizard);
            }
            else if (input == lizard)
            {
                defeats.Add(paper);
                defeats.Add(spock);
            }
            else if (input == spock)
            {
                defeats.Add(scissors);
                defeats.Add(rock);
            }
        }

        //methods
        internal int Results(string player2_choice)
        {
            if (defeats.Contains(player2_choice))
            {
                return 0;
            } 
            else
            {
                return 1;
            }
        }
    }
}
