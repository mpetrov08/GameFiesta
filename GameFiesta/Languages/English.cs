using GameFiesta.Languages.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using GameFiesta.Managers;
using GameFiesta.StartScreen.Components;

namespace GameFiesta.Languages
{
    public class English : ILanguage
    {
        public List<string> HangmanWords => new List<string>()
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

        //Messages used in SetUp class

        public void PrintBackMessage()
        {
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[underline red]Press delete if you want to go back to the SetUp options[/]"));
            Console.WriteLine();
        }

        public void PrintContinueMessage()
        {
            AnsiConsole.Write(new Markup("[underline blue]Press enter if you want to continue[/]"));
            Console.WriteLine();
        }

        public void PrintLanguageChooseMessage()
        {
            AnsiConsole.Write(new Markup("[red]Press the button which is equal to number before the language you want to change.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/] [white]Bul[/][green]gar[/][red]ian[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/] [red]Eng[/][white]li[/][blue]sh[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/] [grey19]Ge[/][red]rm[/][yellow]an[/]"));
            Console.WriteLine();
        }

        public void PrintSetUpMessage()
        {
            AnsiConsole.Write(new Markup("[underline deeppink4]If you want to change something click the button of your keyboard which is equal to the number before the setting.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/][hotpink2]Choose language[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/][violet]Read Rules[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/][mediumorchid1]Continue[/]"));
            Console.WriteLine();
        }

        //End of messages used in SetUp class
        
        //Messages used in Header class
        public void PrintGameMenu()
        {
            AnsiConsole.Write(new Markup("[cornflowerblue]Click the button of your keyboard which is the same in front of the game you want to play[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[seagreen2]Choose game:[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/] [blue]Cows[/] And [red]Bulls[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/] [gray]Hangman[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/] [khaki1]TikTakToe[/]"));
            Console.WriteLine();
        }

        public void PrintCowsAndBullsHeader()
        {
            AnsiConsole.Write(new FigletText("Cows And Bulls").Centered().Color(Color.Cyan1));
        }

        public void PrintCowsAndBullsInputMessage()
        {
            AnsiConsole.Write(new Markup("[blue]Write possible combination of numbers: [/]"));
        }

        public void PrintCowsAndBullsOutputMessage(int bulls, int cows)
        {
            AnsiConsole.Write(new Markup($"[blue]You have:[/] [red]{bulls}B, {cows}C[/]"));
        }

        public void PrintCowsAndBullsWinningMessage(int tryes, string correctCombination)
        {
            AnsiConsole.Write(new Markup($"[yellow]Number was: {correctCombination}[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]You guessed![/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]You tryed: {tryes} times.[/]"));
            Console.WriteLine();
        }

        public void PrintHangmanHeader()
        {
            AnsiConsole.Write(new FigletText("Hangman").Centered().Color(Color.DarkCyan));
        }

        public void PrintHangmanDiscoveredMessage()
        {
            AnsiConsole.Write(new Markup("[lime]The discovered letters are:[/]"));
        }

        public void PrintHangmanWrongLettersMessage(List<char> alreadyUsedLetters)
        {
            Console.WriteLine();
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[green]You already used these wrong letters:[/] [lime]{string.Join(", ", alreadyUsedLetters)}[/]"));
        }

        public void PrintHangmanInputMessage()
        {
            Console.WriteLine();
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[palegreen3_1]Write possible letter: [/]"));
        }

        public void PrintHangmanWinningMessage(string word)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("[yellow]CONGRATULATIONS, You completed the word![/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]The word was {word}[/]"));
        }

        public void PrintHangmanLoseMessage(string hangman, string word)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup($"[yellow]{hangman}[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]Oh no, you did not guess the word![/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]The word was {word}[/]"));
        }

        public void PrintHangmanMisstakesMessage(int misstakes)
        {
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]You made: {misstakes} Misstakes[/]"));
            Console.WriteLine();
        }

        public void PrintTikTakToeHeader()
        {
            AnsiConsole.Write(new FigletText("Tic Tac Toe").Centered().Color(Color.Gold3));
        }

        public void PrintTikTakToePlayer1Message()
        {
            AnsiConsole.Write(new Markup("[yellow3]The name of Player 1 is: [/]"));
        }

        public void PrintTikTakToePlayer2Message()
        {
            AnsiConsole.Write(new Markup("[yellow3]The name of Player 1 is: [/]"));
        }

        public void PrintTikTakToeInputMessage(string playerName)
        {
            AnsiConsole.Write(new Markup($"[greenyellow]{playerName}, Type coordinates of your next move(format: row, col): [/]"));
        }

        public void PrintTikTakToeWrongCoordinatesMessage()
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("[red]Wrong coordinates[/]"));
        }

        public void PrintTikTakToeDrawMessage()
        {
            AnsiConsole.Write(new Markup("[yellow]We have a draw![/]"));
        }

        public void PrintTikTakToeWinningMessage(string winner)
        {
            AnsiConsole.Write(new Markup($"[yellow2]{winner} won!!![/]"));
        }

        public void PrintErrorMessage()
        {
            AnsiConsole.Write(new Markup("[red]Wrong key![/]"));
            Console.WriteLine();
        }

        public void PrintRules()
        {
            AnsiConsole.Write(new Markup("[bold yellow3]Bulls and Cows[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[darkolivegreen3_2]The computer generates a random combination of four numbers (the numbers are guaranteed not to repeat) " +
                Environment.NewLine +
                "and your goal is to guess the combination. You have an unlimited number of attempts. If you have a number in your combination that also occurs in the computer's, " +
                Environment.NewLine +
                "but it is not in the correct position, then you have a Cow, and if you have a number that is in the correct position, you have a Bull.[/]"));
            Console.WriteLine();
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[bold darkviolet_1]Hangman[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[purple_2]The computer generates a random word and your goal is to guess it. With every mistake, the computer draws your gallows " +
                Environment.NewLine +
                "and on your last 9 mistake, you lose. How to guess the word? This is done by writing a given letter and the computer will accordingly show you whether this letter is in the word or not " +
                Environment.NewLine +
                "and so you have to guess the word letter by letter.[/]"));
            Console.WriteLine();
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[bold gold3]Tik Tak Toe[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow3_1]This is a game for two players. One plays with X and the other with O. The goal is for one of the two to have three identical pieces in a row, column or diagonal.\r\n[/]"));
            Console.WriteLine();
        }
        //End of messages used in Header class


    }
}
