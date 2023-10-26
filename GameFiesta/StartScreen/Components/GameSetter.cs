using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFiesta.AllGames.CowsAndBullsGame;
using GameFiesta.AllGames.HangmanGame;
using GameFiesta.enums;
using GameFiesta.Managers;
using GameFiesta.Managers.Contracts;
using Spectre.Console;

namespace GameFiesta.StartScreen.Components
{
    public class GameSetter : IManager
    {
        private Games game;
        private List<Games> posibleGames;
        private List<ConsoleKey> possibleConsoleKeys;
        private User user;
        public GameSetter(User user)
        {
            this.user = user;

            posibleGames = new List<Games>
            {
                Games.CowsAndBulls,
                Games.Hangman,
                Games.Labirinths,
                Games.Snake,
                Games.TikTakToe
            };

            possibleConsoleKeys = new List<ConsoleKey>
            {
                ConsoleKey.D1,
                ConsoleKey.D2,
                ConsoleKey.D3,
                ConsoleKey.D4,
                ConsoleKey.D5
            };
        }

        public void Print()
        {
            SetGame();
        }

        private void SetGame()
        {
            user.Language.PrintGameMenu();
            game = Choose.MakeChoose(posibleGames, possibleConsoleKeys);
            Console.Clear();
            if (game == Games.CowsAndBulls)
            {
                CowsAndBulls cowsAndBulls = new CowsAndBulls();
                cowsAndBulls.Run();
            }
            else if (game == Games.Hangman)
            {
                Hangman hangman = new Hangman();
                hangman.Run();
            }
            else if (game == Games.Labirinths)
            {
                Console.WriteLine("You choosed Labirinths");
            }
            else if (game == Games.Snake)
            {
                Console.WriteLine("You choosed Snake");
            }
            else if (game == Games.TikTakToe)
            {
                Console.WriteLine("You choosed TikTakToe");
            }
        }
    }
}
