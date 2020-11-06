using System;
using System.Collections.Concurrent;
using System.Dynamic;
using System.Threading.Tasks.Sources;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            string[,] board =
            {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"}
            };
            int counter = 1;
            while (running)
            {

                Console.WriteLine("     |     |     ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0, 0], board[0, 1], board[0, 2]);
                Console.WriteLine("     |     |     ");
                Console.WriteLine("-----------------");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1, 0], board[1, 1], board[1, 2]);
                Console.WriteLine("     |     |     ");
                Console.WriteLine("-----------------");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[2, 0], board[2, 1], board[2, 2]);
                Console.WriteLine("     |     |     ");

                double playerRound = counter % 2 == 0 ? 2 : 1;

                if ((board[0, 0].Equals(board[0, 1]) && board[0, 0].Equals(board[0, 2])) ||
                    (board[1, 0].Equals(board[1, 1]) && board[1, 0].Equals(board[1, 2])) ||
                    (board[2, 0].Equals(board[2, 1]) && board[2, 0].Equals(board[2, 2])) ||
                    (board[0, 0].Equals(board[1, 0]) && board[1, 0].Equals(board[2, 0])) ||
                    (board[0, 1].Equals(board[1, 1]) && board[1, 1].Equals(board[2, 1])) ||
                    (board[0, 2].Equals(board[1, 2]) && board[1, 2].Equals(board[2, 2])) ||
                    (board[0, 0].Equals(board[1, 1]) && board[0, 0].Equals(board[2, 2])) ||
                    (board[2, 0].Equals(board[1, 1]) && board[2, 0].Equals(board[0, 2])))
                {
                    if (playerRound == 1)
                    {
                        Console.WriteLine("\nPlayer 2 Win!");
                        Console.Read();
                        running = false;
                    }
                    else
                    {
                        Console.WriteLine("\nPlayer 1 Win!");
                        Console.Read();
                        running = false;
                    }
                }

                Console.Write("\nPlayer {0} : Choose your field:", playerRound);
                string playerInput = Console.ReadLine();
                switch (playerInput)
                {
                    case "1":
                        board[0, 0] = playerRound == 1 ? "O" : "X";
                        break;
                    case "2":
                        board[0, 1] = playerRound == 1 ? "O" : "X";
                        break;
                    case "3":
                        board[0, 2] = playerRound == 1 ? "O" : "X";
                        break;
                    case "4":
                        board[1, 0] = playerRound == 1 ? "O" : "X";
                        break;
                    case "5":
                        board[1, 1] = playerRound == 1 ? "O" : "X";
                        break;
                    case "6":
                        board[1, 2] = playerRound == 1 ? "O" : "X";
                        break;
                    case "7":
                        board[2, 0] = playerRound == 1 ? "O" : "X";
                        break;
                    case "8":
                        board[2, 1] = playerRound == 1 ? "O" : "X";
                        break;
                    case "9":
                        board[2, 2] = playerRound == 1 ? "O" : "X";
                        break;
                    default:
                        Console.WriteLine("Your input was wrong. Try again.");
                        --counter;
                        break;
                }

                counter++;
                Console.Clear();
            }
        }
    }
}
