using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace GameFiesta.AllGames.HangmanGame
{
    public class Hangman
    {
        private List<string> words = new List<string>();
        private List<char> alreadyUsedLetters;
        private string[] hangmanPhases;
        private string Word;
        private string field;
        private int Misstakes;

        public Hangman()
        {
            alreadyUsedLetters = new List<char>();

            words = new List<string>
            {
                "Programmer",
                "School",
                "History",
                "Plane",
                "GitHub",
                "Computer",
                "Elephant",
                "Girlfriend",
                "Microphone",
                "City",
                "Capybara",
                "Platypus",
                "Football",
                "PingPong",
                "Volleyball",
                "Chess",
                "Book",
                "Empire",
                "Dumbbell",
                "Ship",
                "House",
                "Monkey",
                "Principle",
                "Pattern",
                "Stone",
                "Scissors",
                "Pistol",
                "Snake",
                "Browser",
                "Competition",
                "Fish",
                "Country",
                "Continent",
                "Town",
                "Cowboy",
                "Chicken",
                "Restaurant",
                "Highway",
                "Night",
                "Wizzard",
                "Lizard",
                "Sparrow",
                "Chameleon",
                "Fly",
                "Giraffe",
                "Rhinoceros",
                "Truck",
                "Police",
                "Fire",
                "Grave"
            };

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

        public void Run()
        {
            GenerateWord();
            InitializeField();

            List<int> indexesOfCorrectLetters = new List<int>();
            while (true)
            {
                Console.Clear();
                AnsiConsole.Write(new FigletText("Hangman").Centered().Color(Color.DarkCyan));
                AnsiConsole.Write(new Markup("[lime]The discovered letters are:[/]"));
                Console.WriteLine();
                AnsiConsole.Write(new Markup($"[springgreen2]{field}[/]"));
                if (Misstakes > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    AnsiConsole.Write(new Markup($"[seagreen1_1]{hangmanPhases[Misstakes - 1]}[/]"));
                }

                Console.WriteLine();
                Console.WriteLine();
                AnsiConsole.Write(new Markup($"[green]You already used these wrong letters:[/] [lime]{string.Join(", ", alreadyUsedLetters)}[/]"));
                Console.WriteLine();
                Console.WriteLine();
                AnsiConsole.Write(new Markup("[palegreen3_1]Write possible letter: [/]"));
                char letter = char.Parse(Console.ReadLine());
                indexesOfCorrectLetters = CheckForCorrectLetter(letter);
                
                if (indexesOfCorrectLetters.Count == 0)
                {
                    if (!alreadyUsedLetters.Contains(letter))
                    {
                        alreadyUsedLetters.Add(letter);
                    }
                    Misstakes++;
                    if (Misstakes > 8)
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
                Console.Clear();
                AnsiConsole.Write(new Markup("[yellow]CONGRATULATIONS, You completed the word![/]"));
                Console.WriteLine();
                AnsiConsole.Write(new Markup($"[yellow]The word was {Word}[/]"));
            }
            else
            {
                Console.Clear();
                AnsiConsole.Write(new Markup($"[yellow]{hangmanPhases[Misstakes - 1]}[/]"));
                Console.WriteLine();
                AnsiConsole.Write(new Markup("[yellow]Oh no, you did not guess the word![/]"));
                Console.WriteLine();
                AnsiConsole.Write(new Markup($"[yellow]The word was {Word}[/]"));
            }

            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]You made: {Misstakes} Misstakes[/]"));
        }

        private void GenerateWord()
        {
            Random rnd = new Random();
            Word = words[rnd.Next(0, words.Count - 1)];
        }

        private void InitializeField()
        {
            for (int i = 0; i < Word.Length; i++)
            {
                field += "_ ";
            }
        }

        private List<int> CheckForCorrectLetter(char letter)
        {
            List<int> indexesOfCorrectLetters = new List<int>();

            for (int i = 0; i < Word.Length; i++)
            {
                if (char.ToLower(letter) == Word[i] ||
                    char.ToUpper(letter) == Word[i])
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
                field = field.Insert(index * 2, Word[index].ToString());
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
