using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables (Has A)
        
        public int score;
        public string name;
        public List<string> gestures = new List<string> {"rock", "paper", "scissors", "lizard", "spock"};
        string move;

        //constructor
        public Player()
        {

        }

        //member methods (Can do)
        public abstract string DecidedMove();  

    }
}
