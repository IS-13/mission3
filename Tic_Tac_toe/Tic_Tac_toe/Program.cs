using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Amy_and_Blake ab = new Amy_and_Blake();

            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            int[] board = new int[9];
            int selection = 0;
            int value = 0;
            ab.printBoard(board);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Player 1, please select a number:");
                selection = int.Parse(Console.ReadLine());
                board[selection] = 1;
                ab.printBoard(board);
                value = ab.checkWinner(board);
                if (value == 1)
                {
                    Console.WriteLine("Player 1 is the winner! Congratulations!");
                    break;
                }
                else if (value == 2)
                {
                    Console.WriteLine("Player 2 is the winner! Congratulations!");
                    break;
                }
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine("Player 2, please select a number:");
                selection = int.Parse(Console.ReadLine());
                board[selection] = 2;
                ab.printBoard(board);
                value = ab.checkWinner(board);
                if (value == 1)
                {
                    Console.WriteLine("Player 1 is the winner! Congratulations!");
                    break;
                }
                else if (value == 2)
                {
                    Console.WriteLine("Player 2 is the winner! Congratulations!");
                    break;
                }
            }
            value = ab.checkWinner(board);
            if (value == 0)
            {
                Console.WriteLine("It's a tie game!");
            }
        }
    }
}
