using GameFiesta.AllGames.Contracts;
using GameFiesta.Languages.Contracts;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFiesta.AllGames.CowsAndBullsGame
{
    public class CowsAndBulls : Game
    {
        private List<int> possibleCombination;
        private Combination correctCombination;
        private int cows;
        private int bulls;
        private int tryes;

        public CowsAndBulls(ILanguage language) : base(language)
        {
            possibleCombination = new List<int>();
            correctCombination = new Combination();
            correctCombination.GenerateCombination();
        }

        public override void Run()
        {
            Language.PrintCowsAndBullsHeader();

            while (true)
            {
                Language.PrintCowsAndBullsInputMessage();
                ReadPossibleCombination();
                tryes++;
                CheckForBulls();
                CheckForCows();

                if (bulls == possibleCombination.Count)
                {
                    break;
                }

                possibleCombination.Clear();
                Language.PrintCowsAndBullsOutputMessage(bulls, cows);
                Console.WriteLine();
            }

            Language.PrintCowsAndBullsWinningMessage(tryes, correctCombination.GetValue());
            ContinueOption();
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
            cows = 0;
            foreach (var number in possibleCombination)
            {
                if (correctCombination.GeneratedCombination.Contains(number) 
                    && correctCombination.GeneratedCombination[possibleCombination.IndexOf(number)] != number)
                {
                    cows++;
                }
            }
        }

        private void CheckForBulls()
        {
            bulls = 0;
            for (int i = 0; i < possibleCombination.Count; i++)
            {
                if (possibleCombination[i] == correctCombination.GeneratedCombination[i])
                {
                    bulls++;
                }
            }
        }
    }
}
