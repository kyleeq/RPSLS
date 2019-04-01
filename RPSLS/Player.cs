using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        //member variables (Has A)
        
        public int Score;
        public string Name;
        public List<string> gestures = new List<string> {"rock", "paper", "scissors", "lizard", "spock"};
        string move;

        //constructor
        public Player()
        {

        }

        //member methods (Can do)
        public virtual void DecidedMove()
        {
            
        }
        public void ConvertMove(string move)
        {
            switch (string move)
            {
                case 1:
                    Console.WriteLine("rock");
                    break;
                case 2:
                    Console.WriteLine("paper");
                    break;
                case 3:
                    Console.WriteLine("scissors");
                    break;
                case 4:
                    Console.WriteLine("lizard");
                    break;
                case 5:
                    Console.WriteLine("spock");
                    break;
                default:
                    
            }
        }

    }
}
