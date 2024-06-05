using GameFiesta.AllGames.Contracts;
using GameFiesta.Languages.Contracts;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFiesta.AllGames.TicTacToeGame
{
    public class TicTacToe : Game
    {
        private char[,] field;

        public TicTacToe(ILanguage language)  : base(language)
        { 
        }

        public override void Run()
        {
            Language.PrintTikTakToeHeader();

            Language.PrintTikTakToePlayer1Message();

            string firstPlayerName = Console.ReadLine();

            Language.PrintTikTakToePlayer2Message();

            string secondPlayerName = Console.ReadLine();

            Console.Clear();
            InitializeField();
            bool isFirstPlayerOnMove = true;

            while (true)
            {
                Language.PrintTikTakToeHeader();
                PrintField();
                if (isFirstPlayerOnMove)
                {
                    Language.PrintTikTakToeInputMessage(firstPlayerName);
                    int[] coordinates = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                    for (int i = 0; i < coordinates.Length; i++)
                    {
                        coordinates[i] -= 1;
                    }
                    
                    if (ValidateCoordinates(coordinates))
                    {
                        RefactorTheField(coordinates, 'X');
                    }
                    else
                    {
                        Language.PrintTikTakToeWrongCoordinatesMessage();
                        continue;
                    }

                    if (CheckForWinner('X'))
                    {
                        Console.Clear();
                        PrintWinnerMessage(firstPlayerName);
                        break;
                    }

                    isFirstPlayerOnMove = false;
                }
                else
                {
                    Language.PrintTikTakToeInputMessage(secondPlayerName);
                    int[] coordinates = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                    for (int i = 0; i < coordinates.Length; i++)
                    {
                        coordinates[i] -= 1;
                    }

                    if (ValidateCoordinates(coordinates))
                    {
                        RefactorTheField(coordinates, 'O');
                    }
                    else
                    {
                        Language.PrintTikTakToeWrongCoordinatesMessage();
                        continue;
                    }

                    if (CheckForWinner('O'))
                    {
                        Console.Clear();
                        PrintWinnerMessage(secondPlayerName);
                        break;
                    }

                    isFirstPlayerOnMove = true;
                }

                if (CheckForDraw())
                {
                    Console.Clear();
                    PrintField();
                    Language.PrintTikTakToeDrawMessage();
                    break;
                }

                Console.Clear();
            }

            Console.WriteLine();

            base.ContinueOption();
        }

        private void InitializeField()
        {
            field = new char[3, 3]
            {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '},
            };
        }

        private void PrintField()
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                if (i == 0)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        AnsiConsole.Write(new Markup($"[darkolivegreen1] {j}[/]"));
                    }

                    Console.WriteLine();
                }

                AnsiConsole.Write(new Markup($"[darkolivegreen1]{i + 1}[/]"));

                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (j + 1 == field.GetLength(1))
                    {
                        AnsiConsole.Write(new Markup($"[darkolivegreen1]{field[i, j]}[/]"));
                    }
                    else
                    {
                        AnsiConsole.Write(new Markup($"[darkolivegreen1]{field[i, j]}|[/]"));
                    }
                }

                Console.WriteLine();

                if (i + 1 < field.GetLength(0))
                {
                    AnsiConsole.Write(new Markup("[darkolivegreen1]------[/]"));
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }

        private bool ValidateCoordinates(int[] coordinates)
        {
            if (coordinates[0] >= 0
                && coordinates[1] >= 0
                && coordinates[0] < field.GetLength(0)
                && coordinates[1] < field.GetLength(1)
                && field[coordinates[0], coordinates[1]] == ' ')
            {
                return true;
            }

            return false;
        }
        
        private void RefactorTheField(int[] coordinates, char sign)
        {
            field[coordinates[0], coordinates[1]] = sign;
        }

        private bool CheckForWinner(char potentialWinnersSign)
        {
            if (field[0, 0] == potentialWinnersSign
                && field[1, 1] == potentialWinnersSign
                && field[2, 2] == potentialWinnersSign)
            {
                return true;
            }
            else if (field[0, 2] == potentialWinnersSign
                     && field[1, 1] == potentialWinnersSign
                     && field[2, 0] == potentialWinnersSign)
            {
                return true;
            }
            else if (field[0, 0] == potentialWinnersSign
                     && field[0, 1] == potentialWinnersSign
                     && field[0, 2] == potentialWinnersSign)
            {
                return true;
            }
            else if (field[1, 0] == potentialWinnersSign
                     && field[1, 1] == potentialWinnersSign
                     && field[1, 2] == potentialWinnersSign)
            {
                return true;
            }
            else if (field[2, 0] == potentialWinnersSign
                     && field[2, 1] == potentialWinnersSign
                     && field[2, 2] == potentialWinnersSign)
            {
                return true;
            }
            else if (field[0, 0] == potentialWinnersSign
                     && field[1, 0] == potentialWinnersSign
                     && field[2, 0] == potentialWinnersSign)
            {
                return true;
            }
            else if (field[0, 1] == potentialWinnersSign
                && field[1, 1] == potentialWinnersSign
                && field[2, 1] == potentialWinnersSign)
            {
                return true;
            }
            else if (field[0, 2] == potentialWinnersSign
                     && field[1, 2] == potentialWinnersSign
                     && field[2, 2] == potentialWinnersSign)
            {
                return true;
            }

            return false;
        }

        private bool CheckForDraw()
        {
            bool isDraw = true;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == ' ')
                    {
                        isDraw = false;
                    }
                }
            }

            return isDraw;
        }

        private void PrintWinnerMessage(string winnerName)
        {
            Language.PrintTikTakToeHeader();
            PrintField();
            Language.PrintTikTakToeWinningMessage(winnerName);
        }
    }
}
