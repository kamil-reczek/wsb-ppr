using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_TicTacToe
{
    class Program
    {
        private static char[,] _board;
        private static char _currentPlayer = 'X';
        enum MenuItems { NewGame = 1, Author = 2, Exit = 3 }


        private static void InitBoard()
        {
            _board = new char[3, 3];
            for (int x = 0; x < _board.GetLength(0); x++)
                for (int y = 0; y < _board.GetLength(1); y++)
                    _board[x, y] = ' ';
        }

        private static void DrawBoard()
        {
            Console.WriteLine();
            Console.WriteLine("   0   1   2 ");
            Console.WriteLine($"0  {_board[0, 0]} | {_board[0, 1]} | {_board[0, 2]}");
            Console.WriteLine("  ---+---+---");
            Console.WriteLine($"1  {_board[1, 0]} | {_board[1, 1]} | {_board[1, 2]}");
            Console.WriteLine("  ---+---+---");
            Console.WriteLine($"2  {_board[2, 0]} | {_board[2, 1]} | {_board[2, 2]}");
            Console.WriteLine();
        }

        private static bool IsFieldAvailable(int x, int y)
        {
            return _board[x, y] == ' ';
        }

        private static bool IsBoardFull()
        {
            foreach (char field in _board)
                if (field == ' ') return false;

            Console.WriteLine("Board is full");
            DrawBoard();
            return true;

        }

        private static void NewGame()
        {
            Console.Clear();
            InitBoard();
            while (!IsBoardFull())
            {
                Console.WriteLine("--- THE GAME ---");
                DrawBoard();
                MakeMove();
                if (IsWinner())
                {
                    Console.Clear();
                    Console.WriteLine($"Player {_currentPlayer} has won the game!");
                    DrawBoard();
                    break;
                }
                _currentPlayer = (_currentPlayer == 'X' ? 'O' : 'X');
                Console.Clear();
            }
            Console.WriteLine("Press any key to return to Menu");
            Console.ReadKey();

        }

        private static int Translate(int x, int y)
        {
            if (_board[x, y] == 'X')
            {
                return 1;
            }
            else if (_board[x, y] == 'O')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private static bool IsWinner()
        {
            int result = 0;
            // horizontal check
            for (int x = 0; x < _board.GetLength(0); x++)
            {
                result = Translate(x, 0) + Translate(x, 1) + Translate(x, 2);
                if (Math.Abs(result) == 3) return true;
            }
            // vertical check
            for (int y = 0; y < _board.GetLength(1); y++)
            {
                result = Translate(0, y) + Translate(1, y) + Translate(2, y);
                if (Math.Abs(result) == 3) return true;
            }

            // diagonal check
            result = Translate(0, 0) + Translate(1, 1) + Translate(2, 2);
            if (Math.Abs(result) == 3) return true;

            result = Translate(0, 2) + Translate(1, 1) + Translate(2, 0);
            if (Math.Abs(result) == 3) return true;

            return false;
        }

        private static int GetProperDimension(string msg)
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

        private static void MakeMove()
        {
            Console.WriteLine($"Provide position of {_currentPlayer}");

            int x = GetProperDimension("x= ");
            int y = GetProperDimension("y= ");

            if (!IsFieldAvailable(x, y))
            {
                Console.WriteLine($"Position ({x}, {y}) not available. Press any key to try again");
                Console.ReadKey();
                return;
            }
            _board[x, y] = _currentPlayer;
        }

        private static MenuItems GetUserAction(string msg)
        {
            int input = 0;
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out input) && Enum.IsDefined(typeof(MenuItems), input))
                {
                    return (MenuItems)input;
                }
                else
                {
                    Console.WriteLine("Try again! Select 1, 2 or 3");
                }
            }
        }

        private static void DisplayManu()
        {
            Console.Clear();
            Console.WriteLine("--- TIC TAC TOE ---");
            Console.WriteLine();
            Console.WriteLine("[1] New game");
            Console.WriteLine("[2] Author");
            Console.WriteLine("[3] Exit");
            Console.WriteLine();
        }

        
        private static void GetAuthor()
        {
            Console.WriteLine("Pan Krzysztof Jarzyna ze Szczecina");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to Menu");
            Console.ReadKey();
        }

        private static void MainLoop()
        {
            bool exit = false;
            while (!exit)
            {
                DisplayManu();
                switch (GetUserAction("Select: "))
                {
                    case MenuItems.NewGame:
                        NewGame();
                        break;
                    case MenuItems.Author:
                        GetAuthor();
                        break;
                    case MenuItems.Exit:
                        if (GetUserAction("Select 3 to confirm exit: ") == MenuItems.Exit)
                        {
                            exit = true;
                        }
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}