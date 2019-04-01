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
        string playerOneGesture;
        string playerTwoGesture;
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
        public void KickOff()
        {
            BeginningPrompt();
            CreatePlayers();

        }
        public void BeginningPrompt()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock.");
            Console.WriteLine("As seen on the Big Bang Theory, this game follows the rules of the original Rock Paper Scissors but with two new gestures." +
                "Here are the rules...\nRock crushes Scissors\n Scissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors " +
                "decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\nPlease press enter when you're");
            Console.ReadLine();
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
                Console.WriteLine("That's not a valid input. Please enter a valid number of players: 1 or 2.");
                CreatePlayers();
            }
            return CreatePlayers();

        }

        public void CompareGestures(string playerOneGesture, string playerTwoGesture)
        {
            if (playerOneGesture == playerTwoGesture) {
                Console.WriteLine("It looks like you both entered the same gesture. It's a tie!");
            }
            else if (playerOneGesture == "rock" && (playerTwoGesture == "scissors" || playerTwoGesture == "lizard"))
            {
                playerOne.score++;
                Console.WriteLine(playerOne + " won the round!");
            }
            else if (playerOneGesture == "paper" && (playerTwoGesture == "rock" || playerTwoGesture == "spock"))
            {
                playerOne.score++;
                Console.WriteLine(playerOne + " won the round!");
            }
            else if (playerOneGesture == "scissors" && (playerTwoGesture == "paper" || playerTwoGesture == "lizard"))
            {
                playerOne.score++;
                Console.WriteLine(playerOne + " won the round!");
            }
            else if (playerOneGesture == "lizard" && (playerTwoGesture == "spock" || playerTwoGesture == "paper"))
            {
                playerOne.score++;
                Console.WriteLine(playerOne + " won the round!");
            }
            else if (playerOneGesture == "spock" && (playerTwoGesture == "scissors" || playerTwoGesture == "rock"))
            {
                playerOne.score++;
                Console.WriteLine(playerOne + " won the round!");
            }
            else
            {
                playerTwo.score++;
                Console.WriteLine(playerTwo + " won the round!");
            }
        }
    }
}
