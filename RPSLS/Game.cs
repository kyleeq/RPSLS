using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //member variables (Has A)
        Player playerOne;
        Player playerTwo;
        int Rounds;
        int NumberOfPlayers;

        List<Player> players = new List<Player>();


        //constructor
        public Game()
        {
            NumberOfPlayers = 2;
            Rounds = 5;

        }

        //member methods (Can Do)
        public void BeginningPrompt()
        {
            Console.WriteLine("");
        }
        public int CreatePlayers()
        {
            int NumberOfPlayers;
            Console.WriteLine("Please enter the number of players.");
            NumberOfPlayers = Convert.ToInt32(Console.ReadLine());
                if (NumberOfPlayers == 1)
            {
                Console.WriteLine("You will be playing against HAL 9000");
                playerOne = new Hooman();
                playerTwo = new Compooter();
            }
                else if (NumberOfPlayers == 2)
            {
                Console.WriteLine("You will be playing against player 2.");
                playerOne = new Hooman();
                playerTwo = new Hooman();
            }
                else
            {
                Console.WriteLine("Please enter a valid number of players. Please enter 1 or 2.");
                CreatePlayers();
            }
            return CreatePlayers();

        }
       
    }
}
