using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace GameFiesta.AllGames.CowsAndBullsGame.IDK
{
    public class Combination
    {
        private int number;

        public Combination() 
        { 
            GeneratedCombination  = new List<int>();
        }

        public List<int> GeneratedCombination { get; set; }

        public void GenerateCombination()
        {
            for (int i = 0; i < 4; i++)
            {
                GeneratedCombination.Add(GenerateDigit(GeneratedCombination));
            }
        }

        private int GenerateDigit(List<int> numbers)
        {
            while (true)
            {
                number = SetValue();
                if (numbers.Contains(number))
                {
                    continue;
                }

                break;
            }

            return number;
        }

        public void PrintValue()
        {
            AnsiConsole.Write(new Markup($"[yellow]{string.Join("", GeneratedCombination)}[/]"));
            Console.WriteLine();
        }

        private int SetValue() 
        { 
            Random rnd = new Random();
            return rnd.Next(0, 9);
        }
    }
}
