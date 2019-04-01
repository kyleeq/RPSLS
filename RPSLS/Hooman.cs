using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Hooman : Player
    {
        //member variables (Has A)

        //constructor
        public Hooman()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
                      
        }

        //member methods (Can Do)
        public override string DecidedMove()
        {
            string playerOneGesture;
            do
            {
                Console.WriteLine(name + ", please enter a gesture");
                playerOneGesture = Console.ReadLine();
            } while (gestures.Contains(playerOneGesture));
 
            return playerOneGesture;
        }
    }
}
