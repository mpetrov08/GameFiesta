using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFiesta.AllGames.Contracts;
using GameFiesta.Languages.Contracts;
using Spectre.Console;

namespace GameFiesta.AllGames.HangmanGame
{
    public class Hangman : Game
    {
        private List<string> words = new List<string>();
        private List<char> alreadyUsedLetters;
        private string[] hangmanPhases;
        private string word;
        private string field;
        private int misstakes;

        public Hangman(ILanguage language) : base(language)
        {
            alreadyUsedLetters = new List<char>();

            words = Language.HangmanWords;

            hangmanPhases = new string[9]
            {
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}",

                $"|-------{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}",

                $"|-------|{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}",

                $"|-------|{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|       O{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}",

                $"|-------|{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|       O{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}",

                $"|-------|{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|       O{Environment.NewLine}" +
                $"|      /|{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}",

                $"|-------|{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|       O{Environment.NewLine}" +
                $"|      /|\\{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}",

               $"|-------|{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|       O{Environment.NewLine}" +
                $"|      /|\\{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|      /{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}",

                $"|-------|{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|       O{Environment.NewLine}" +
                $"|      /|\\{Environment.NewLine}" +
                $"|       |{Environment.NewLine}" +
                $"|      / \\{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}" +
                $"|{Environment.NewLine}",
            };
        }

        public override void Run()
        {
            GenerateWord();
            InitializeField();

            List<int> indexesOfCorrectLetters = new List<int>();
            while (true)
            {
                Console.Clear();
                Language.PrintHangmanHeader();
                Language.PrintHangmanDiscoveredMessage();
                Console.WriteLine();
                AnsiConsole.Write(new Markup($"[springgreen2]{field}[/]"));
                if (misstakes > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    AnsiConsole.Write(new Markup($"[seagreen1_1]{hangmanPhases[misstakes - 1]}[/]"));
                }

                Language.PrintHangmanWrongLettersMessage(alreadyUsedLetters);
                Language.PrintHangmanInputMessage();
                char letter = char.Parse(Console.ReadLine());
                indexesOfCorrectLetters = CheckForCorrectLetter(letter);
                
                if (indexesOfCorrectLetters.Count == 0)
                {
                    if (!alreadyUsedLetters.Contains(char.ToUpper(letter)))
                    {
                        alreadyUsedLetters.Add(char.ToUpper(letter));
                    }

                    misstakes++;
                    if (misstakes > 8)
                    {
                        break;
                    }

                    continue;
                }

                RefactorTheField(indexesOfCorrectLetters);

                if (IsWordCompleted())
                {
                    break;
                }
            }

            if (IsWordCompleted())
            {
                Language.PrintHangmanWinningMessage(word);
            }
            else
            {
                Language.PrintHangmanLoseMessage(hangmanPhases[misstakes - 1], word);
            }

            Language.PrintHangmanMisstakesMessage(misstakes);

            base.ContinueOption();
        }

        private void GenerateWord()
        {
            Random rnd = new Random();
            word = words[rnd.Next(0, words.Count - 1)];
        }

        private void InitializeField()
        {
            for (int i = 0; i < word.Length; i++)
            {
                field += "_ ";
            }
        }

        private List<int> CheckForCorrectLetter(char letter)
        {
            List<int> indexesOfCorrectLetters = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.ToUpper(letter) == char.ToUpper(word[i]))
                {
                    indexesOfCorrectLetters.Add(i);
                }
            }

            return indexesOfCorrectLetters;
        }

        private void RefactorTheField(List<int> indexesOfCorrectLetters)
        {
            foreach (int index in indexesOfCorrectLetters)
            {
                field = field.Remove(index * 2, 1);
                field = field.Insert(index * 2, word[index].ToString());
            }
        }


        private bool IsWordCompleted()
        {
            if (!field.Contains("_"))
            {
                return true;
            }

            return false;
        }
    }
}
