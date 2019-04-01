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
            Console.Clear();
            BeginningPrompt();
            CreatePlayers();

            for (int Rounds = 0; Rounds <= 4; Rounds++)
            {
                playerOneGesture = playerOne.DecidedMove();
                playerTwoGesture = playerTwo.DecidedMove();
                bool isTie = CompareGestures(playerOneGesture, playerTwoGesture);

                if (isTie == true)
                {
                    Rounds--;
                }               
                                               
                if (playerOne.score == 3 || playerTwo.score == 3)
                {
                    break;
                } 
            }

            DecideWinner(playerOne.score, playerTwo.score);
            FinalPrompt();
        }
        public void BeginningPrompt()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!\n");
            Console.WriteLine("As seen on the Big Bang Theory, this game follows the rules of the original Rock Paper Scissors but with two new gestures.\n\n" +
                "Here are the rules...\n\nRock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors" +
                "decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n\nPlease press enter when you're ready!");
            Console.ReadLine();
        }
        public void CreatePlayers()
        {
            string NumberOfPlayers;
            Console.WriteLine("Please enter the number of players: 1 or 2.");
            NumberOfPlayers = Console.ReadLine();
            if (NumberOfPlayers == "1")
            {
                Console.WriteLine("You will be playing against HAL 9000");
                playerOne = new Hooman();
                playerTwo = new Compooter();
            }
            else if (NumberOfPlayers == "2")
            {
                playerOne = new Hooman();
                Console.WriteLine("Please press 'enter' to continue");
                playerTwo = new Hooman();
            }
            else
            {
                Console.WriteLine("That's not a valid input. Please enter a valid number of players: 1 or 2.");
                CreatePlayers();
            }

        }

        public bool CompareGestures(string playerOneGesture, string playerTwoGesture)
        {
            if (playerOneGesture == playerTwoGesture)
            {
                Console.WriteLine("It looks like you both entered the same gesture. It's a tie! Great minds think alike!\n");
                return true;
            }
            else if (playerOneGesture == "rock" && (playerTwoGesture == "scissors" || playerTwoGesture == "lizard"))
            {
                playerOne.score++;
                Console.WriteLine(playerOne.name + " won the round!\n");
            }
            else if (playerOneGesture == "paper" && (playerTwoGesture == "rock" || playerTwoGesture == "spock"))
            {
                playerOne.score++;
                Console.WriteLine(playerOne.name + " won the round!\n");
            }
            else if (playerOneGesture == "scissors" && (playerTwoGesture == "paper" || playerTwoGesture == "lizard"))
            {
                playerOne.score++;
                Console.WriteLine(playerOne.name + " won the round!\n");
            }
            else if (playerOneGesture == "lizard" && (playerTwoGesture == "spock" || playerTwoGesture == "paper"))
            {
                playerOne.score++;
                Console.WriteLine(playerOne.name + " won the round!\n");
            }
            else if (playerOneGesture == "spock" && (playerTwoGesture == "scissors" || playerTwoGesture == "rock"))
            {
                playerOne.score++;
                Console.WriteLine(playerOne.name + " won the round!\n");
            }
            else
            {
                playerTwo.score++;
                Console.WriteLine(playerTwo.name + " won the round!\n");
            }
            return false;
        }

        public void DecideWinner(int P1Score, int P2Score)
        {
            if (P1Score > P2Score)
            {
                Console.WriteLine("Congratulation " + playerOne.name + "! You won the game!\n");
            }
            else
            {
                Console.WriteLine("Congratulation " + playerTwo.name + "! You won the game!\n");
            }
        }

        public void FinalPrompt()
        {
            Console.WriteLine("Would you like to play again? Please type 'restart' to play again and 'quit' to exit the game");
            string UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "restart":
                    KickOff();
                    break;
                case "quit":
                    break;
                case "banana":
                    Console.WriteLine("Go home Nevin, you're drunk.");
                    FinalPrompt();
                    break;
                default:
                    Console.WriteLine("It seems like you can't follow directions. Please try again with an appropriate input.");
                    FinalPrompt();
                    break;
            }
        }
        
    }
}
