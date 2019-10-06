using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_TicTacToe
{
    class Program
    {
        private static char[,] board;
        private static char currentPlayer = 'X';

        private static void initBoard()
        {
            board = new char[3, 3];
            for (int x = 0; x < board.GetLength(0); x++)
                for (int y = 0; y < board.GetLength(1); y++)
                    board[x, y] = ' ';
        }

        private static void drawBoard()
        {
            Console.WriteLine();
            Console.WriteLine("   0   1   2 ");
            Console.WriteLine($"0  {board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
            Console.WriteLine("  ---+---+---");
            Console.WriteLine($"1  {board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
            Console.WriteLine("  ---+---+---");
            Console.WriteLine($"2  {board[2, 0]} | {board[2, 1]} | {board[2, 2]}");
            Console.WriteLine();
        }

        private static bool isAvailable(int x, int y)
        {
            return board[x, y] == ' ';
        }

        private static bool isBoardFull()
        {
            foreach (char field in board)
                if (field == ' ') return false;

            Console.WriteLine("Board is full");
            drawBoard();
            return true;

        }

        private static void mainLoop()
        {
            Console.WriteLine("--- TIC TAC TOE ---");
            initBoard();
            while (!isBoardFull())
            {
                drawBoard();
                makeMove();
                if (isWinner())
                {
                    Console.Clear();
                    Console.WriteLine($"Player {currentPlayer} has won the game!");
                    drawBoard();
                    break;
                }
                currentPlayer = (currentPlayer == 'X' ? 'O' : 'X');
                Console.Clear();
            }
            Console.WriteLine("Preass any key to exit.");
            Console.ReadKey();

        }

        private static int t(int x, int y)
        {
            if (board[x, y] == 'X')
            {
                return 1;
            }
            else if (board[x, y] == 'O')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private static bool isWinner()
        {
            int result = 0;
            // horizontal check
            for (int x = 0; x < board.GetLength(0); x++)
            {
                result = t(x, 0) + t(x, 1) + t(x, 2);
                if (Math.Abs(result) == 3) return true;
            }
            // vertical check
            for (int y = 0; y < board.GetLength(1); y++)
            {
                result = t(0, y) + t(1, y) + t(2, y);
                if (Math.Abs(result) == 3) return true;
            }

            // diagonal check
            result = t(0, 0) + t(1, 1) + t(2, 2);
            if (Math.Abs(result) == 3) return true;

            result = t(0, 2) + t(1, 1) + t(2, 0);
            if (Math.Abs(result) == 3) return true;

            return false;
        }

        private static int getProperDimension(string msg)
        {
            int result = 0;
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out result) && result >= 0 && result < 3) break;
                Console.WriteLine("Try again! Value should equal 0,1 or 2");
            }

            return result;
        }

        private static void makeMove()
        {
            Console.WriteLine($"Provide position of {currentPlayer}");

            int x = getProperDimension("x= ");
            int y = getProperDimension("y= ");

            if (!isAvailable(x, y))
            {
                Console.WriteLine($"Position ({x}, {y}) not available. Press any key to try again");
                Console.ReadKey();
                return;
            }
            board[x, y] = currentPlayer;
        }

        static void Main(string[] args)
        {
            mainLoop();
        }
    }
}