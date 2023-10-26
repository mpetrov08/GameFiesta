using GameFiesta.AllGames.CowsAndBullsGame.IDK;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFiesta.AllGames.CowsAndBullsGame
{
    public class CowsAndBulls
    {
        private List<int> possibleCombination;
        private Combination correctCombination;
        private int Cows;
        private int Bulls;
        private int Tryes;

        public CowsAndBulls()
        {
            possibleCombination = new List<int>();
            correctCombination = new Combination();
            correctCombination.GenerateCombination();
        }

        public void Run()
        {
            AnsiConsole.Write(new FigletText("Cows And Bulls").Centered().Color(Color.Cyan1));
            
            while (true)
            {
                AnsiConsole.Write(new Markup("[blue]Write possible combination of numbers: [/]"));
                ReadPossibleCombination();
                Tryes++;
                CheckForBulls();
                CheckForCows();

                if (Bulls == possibleCombination.Count)
                {
                    break;
                }

                possibleCombination.Clear();
                AnsiConsole.Write(new Markup($"[blue]You have:[/] [red]{Bulls}B, {Cows}C[/]"));
                Console.WriteLine();
            }

            AnsiConsole.Write(new Markup("[yellow]Number was: [/]"));
            correctCombination.PrintValue();
            AnsiConsole.Write(new Markup("[yellow]You guessed![/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]You tryed: {Tryes} times.[/]"));
        }

        private void ReadPossibleCombination()
        {
            string num = Console.ReadLine();
            foreach (char item in num)
            {
                possibleCombination.Add(item - '0');
            }
        }

        private void CheckForCows()
        {
            Cows = 0;
            foreach (var number in possibleCombination)
            {
                if (correctCombination.GeneratedCombination.Contains(number) 
                    && correctCombination.GeneratedCombination[possibleCombination.IndexOf(number)] != number)
                {
                    Cows++;
                }
            }
        }

        private void CheckForBulls()
        {
            Bulls = 0;
            for (int i = 0; i < possibleCombination.Count; i++)
            {
                if (possibleCombination[i] == correctCombination.GeneratedCombination[i])
                {
                    Bulls++;
                }
            }
        }
    }
}
