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
            name = Console.ReadLine("Input your name");
        }

        //member methods (Can Do)
        public override string DecidedMove()
        {
            Console.WriteLine(name + ", please enter a gesture");
            string playerOneGesture = Console.ReadLine();
        }
    }
}
