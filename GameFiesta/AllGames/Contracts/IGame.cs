using GameFiesta.Languages.Contracts;
using GameFiesta.StartScreen.Components;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFiesta.AllGames.Contracts
{
    public abstract class Game
    {
        protected Game(ILanguage language)
        {
            this.Language = language;
        }

        protected ILanguage Language { get; private set; }

        public abstract void Run();

        public virtual void ContinueOption()
        {
            Language.PrintContinueMessage();
            var choosedKey = Console.ReadKey();

            while (choosedKey.Key != ConsoleKey.Enter)
            {
                Language.PrintErrorMessage();
                choosedKey = Console.ReadKey();
            }

            Console.Clear();
        }
    }
}
