using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFiesta.AllGames.Contracts;
using GameFiesta.AllGames.CowsAndBullsGame;
using GameFiesta.AllGames.HangmanGame;
using GameFiesta.AllGames.TicTacToeGame;
using GameFiesta.Languages;
using GameFiesta.Languages.Contracts;
using GameFiesta.Managers;
using GameFiesta.Managers.Contracts;
using GameFiesta.StartScreen.Components;
using Spectre.Console;

namespace GameFiesta.StartScreen
{
    public class MenuManager : IManager
    {
        private ILanguage language;
        private Game choosedGame;

        public MenuManager(ILanguage language)
        {
            this.language = language;
        }

        public void Visualize()
        {
            while (true)
            {
                Logo.PrintLogo();
                language.PrintSetUpMessage();
                Footer.PrintFooter();

                var choosedKey = Console.ReadKey();
                Console.Clear();

                if (choosedKey.Key == ConsoleKey.D1)
                {
                    LanguageSetter();
                }
                else if (choosedKey.Key == ConsoleKey.D2)
                {
                    PrintRules();
                }
                else if (choosedKey.Key == ConsoleKey.D3)
                {
                    GameSetter();
                }
                else
                {
                    language.PrintErrorMessage();
                }
            }
        }

        private void GameSetter()
        {
            while (true)
            {
                Logo.PrintLogo();
                language.PrintGameMenu();
                language.PrintBackMessage();
                Footer.PrintFooter();

                var choosedKey = Console.ReadKey();
                Console.Clear();

                if (choosedKey.Key == ConsoleKey.D1)
                {
                    choosedGame = new CowsAndBulls(language);
                }
                else if (choosedKey.Key == ConsoleKey.D2)
                {
                    choosedGame = new Hangman(language);
                }
                else if (choosedKey.Key == ConsoleKey.D3)
                {
                    choosedGame = new TicTacToe(language);
                }
                else if (choosedKey.Key == ConsoleKey.Backspace)
                {
                    return;
                }
                else
                {
                    language.PrintErrorMessage();
                    continue;
                }

                choosedGame.Run();
            }
        }

        private void LanguageSetter()
        {
            while (true)
            {
                Logo.PrintLogo();
                language.PrintLanguageChooseMessage();
                Footer.PrintFooter();

                var choosedKey = Console.ReadKey();
                Console.Clear();

                if (choosedKey.Key == ConsoleKey.D1)
                {
                    AnsiConsole.Write(new Markup("[white]Бъл[/][green]гар[/][red]ски[/] [darkgoldenrod] е избран като настоящ език.[/]"));
                    language = new Bulgarian();
                    break;
                }
                else if (choosedKey.Key == ConsoleKey.D2)
                {
                    AnsiConsole.Write(new Markup("[red]Eng[/][white]li[/][blue]sh[/] [darkgoldenrod]was set as main language[/]"));
                    language = new English();
                    break;
                }
                else if (choosedKey.Key == ConsoleKey.D3)
                {
                    AnsiConsole.Write(new Markup("[darkgoldenrod]Als Hauptsprache wurde[/] [grey19]De[/][red]ut[/][yellow]sch[/] [darkgoldenrod]eingestellt[/]"));
                    language = new German();
                    break;
                }
                else
                {
                    language.PrintErrorMessage();
                    continue;
                }
            }

            Back();
        }

        private void Back()
        {
            language.PrintBackMessage();
            language.PrintContinueMessage();
            Footer.PrintFooter();

            while (true)
            {
                var choosedKey = Console.ReadKey();

                if (choosedKey.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    return;
                }
                else if (choosedKey.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    Visualize();
                }
                else
                {
                    language.PrintErrorMessage();
                    continue;
                }
            }
        }

        private void PrintRules()
        {
            language.PrintRules();
            Back();
        }
    }
}
