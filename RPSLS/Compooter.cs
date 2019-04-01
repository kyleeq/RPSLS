using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Compooter : Player
    {
        //member variables (Has A)
        Random rand;

        //constructor
        public Compooter()
        {
            name = "HAL 9000";
            rand = new Random();

        }

        //member methods (Can DO)
        public override string DecidedMove()
        {
            int decision = rand.Next(4);
            Console.WriteLine("Hal 9000 decided to throw " + gestures[decision]);
            return gestures[decision];
        }
    }
}
