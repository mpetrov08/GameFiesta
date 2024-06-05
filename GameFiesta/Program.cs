using GameFiesta.Languages;
using Spectre.Console;
using System.ComponentModel.Design;
using GameFiesta.StartScreen;
using GameFiesta.AllGames.CowsAndBullsGame;
using GameFiesta.AllGames.HangmanGame;
using GameFiesta.Languages.Contracts;

namespace GameFiesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILanguage language = new English();
            MenuManager menuManager = new MenuManager(language);
            menuManager.Visualize();
        }
    }
}