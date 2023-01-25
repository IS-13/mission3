using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_toe
{
    public class Amy_and_Blake
    {
        public void printBoard(int[] board)
        {
            string[] arry = { "0", "1", "2", "3", "4", "5", "6", "7", "8"};

            for(int i = 0; i < 9; i++)
            {
                if (board[i] == 1)
                {
                    arry[i] = "X";
                }
                if (board[i] == 2)
                {
                    arry[i] = "O";
                }

            }
            Console.WriteLine(arry[0] + " | " + arry[1] + " | " + arry[2] + "\n" +
                "---------" + "\n" +
                arry[3] + " | " + arry[4] + " | " + arry[5] + "\n" +
                "---------" + "\n" +
                arry[6] + " | " + arry[7] + " | " + arry[8]);
        }

        public int checkWinner(int[] board)
        {
            int winnerNum = 0;
            for (int i = 1; i < 3; i++)
            {
                //check columns
                if ((board[0] == i) && (board[3] == i) && (board[6] == i))
                {
                    winnerNum = i;
                }
                if ((board[1] == i) && (board[4] == i) && (board[7] == i))
                {
                    winnerNum = i;
                }
                if ((board[2] == i) && (board[5] == i) && (board[8] == i))
                {
                    winnerNum = i;
                }
                //check in a row
                if ((board[0] == i) && (board[1] == i) && (board[2] == i))
                {
                    winnerNum = i;
                }
                if ((board[3] == i) && (board[4] == i) && (board[5] == i))
                {
                    winnerNum = i;
                }
                if ((board[6] == i) && (board[7] == i) && (board[8] == i))
                {
                    winnerNum = i;
                }
                //check diagonals
                if ((board[0] == i) && (board[4] == i) && (board[8] == i))
                {
                    winnerNum = i;
                }
                if ((board[2] == i) && (board[4] == i) && (board[6] == i))
                {
                    winnerNum = i;
                }
            }
                
            return winnerNum;
        }
    }
}
