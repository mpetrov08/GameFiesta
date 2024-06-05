using GameFiesta.Languages.Contracts;
using GameFiesta.Managers;
using GameFiesta.StartScreen.Components;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFiesta.Languages
{
    public class German : ILanguage
    {
        public List<string> HangmanWords => new List<string>()
        {
            "Programmierer",
            "Schule",
            "Geschichte",
            "Flugzeug",
            "GitHub",
            "Computer",
            "Elefant",
            "Freundin",
            "Mikrofon",
            "Stadt",
            "Capybara",
            "Schnabeltier",
            "Fußball",
            "Tischtennis",
            "Volleyball",
            "Schach",
            "Buch",
            "Reich",
            "Hantel",
            "Schiff",
            "Haus",
            "Affe",
            "Prinzip",
            "Muster",
            "Stein",
            "Schere",
            "Pistole",
            "Schlange",
            "Browser",
            "Wettbewerb",
            "Fisch",
            "Land",
            "Kontinent",
            "Stadt",
            "Cowboy",
            "Huhn",
            "Restaurant",
            "Autobahn",
            "Nacht",
            "Zauberer",
            "Eidechse",
            "Spatz",
            "Chamäleon",
            "Fliege",
            "Giraffe",
            "Nashorn",
            "LKW",
            "Polizei",
            "Feuer",
            "Grab"
        };

        public void PrintBackMessage()
        {
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[underline red]Drücken Sie die Entf-Taste, wenn Sie zu den Setup-Optionen zurückkehren möchten.[/]"));
            Console.WriteLine();
        }

        public void PrintContinueMessage()
        {
            AnsiConsole.Write(new Markup("[underline blue]Drücken Sie die Eingabetaste, wenn Sie fortfahren möchten.[/]"));
            Console.WriteLine();
        }

        public void PrintLanguageChooseMessage()
        {
            AnsiConsole.Write(new Markup("[red]Drücken Sie die Taste mit der Nummer vor der Sprache, die Sie ändern möchten.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/] [white]Bul[/][green]gar[/][red]isch[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/] [red]Eng[/][white]li[/][blue]sch[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/] [grey19]De[/][red]ut[/][yellow]sch[/]"));
            Console.WriteLine();
        }

        public void PrintSetUpMessage()
        {
            AnsiConsole.Write(new Markup("[underline deeppink4]Wenn Sie etwas ändern möchten, klicken Sie auf die Schaltfläche Ihrer Tastatur, die der Zahl vor der Einstellung entspricht.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/][hotpink2]Wähle ihre Sprache[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/][violet]Lesen Sie die Regeln[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/][mediumorchid1]Forsetzen[/]"));
            Console.WriteLine();
        }

        public void PrintGameMenu()
        {
            AnsiConsole.Write(new Markup("[cornflowerblue]Klicken Sie auf die entsprechende Schaltfläche auf Ihrer Tastatur vor dem Spiel, das Sie spielen möchten\r\n[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[seagreen2]Wählen Sie ein Spiel:[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/] [blue]Kuh[/] Und [red]Bulle[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/] [gray]Galgenmännchen[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/] [khaki1]Drei Gewinnt[/]"));
            Console.WriteLine();
        }

        public void PrintCowsAndBullsHeader()
        {
            AnsiConsole.Write(new FigletText("Kuh und Bulle").Centered().Color(Color.Cyan1));
        }

        public void PrintCowsAndBullsInputMessage()
        {
            AnsiConsole.Write(new Markup("[blue]Schreiben Sie die mögliche Zahlenkombination auf: [/]"));
        }

        public void PrintCowsAndBullsOutputMessage(int bulls, int cows)
        {
            AnsiConsole.Write(new Markup($"[blue]Sie haben:[/] [red]{bulls}B, {cows}K[/]"));
        }

        public void PrintCowsAndBullsWinningMessage(int tryes, string correctCombination)
        {
            AnsiConsole.Write(new Markup($"[yellow]Die Zahle war: {correctCombination}[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]Sie haben geraten![/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]Du hast es versuht: {tryes} mal.[/]"));
            Console.WriteLine();
        }

        public void PrintHangmanHeader()
        {
            AnsiConsole.Write(new FigletText("Galgenmännchen").Centered().Color(Color.DarkCyan));
        }

        public void PrintHangmanDiscoveredMessage()
        {
            AnsiConsole.Write(new Markup("[lime]Die entdeckten Buchstaben sind:[/]"));
        }

        public void PrintHangmanWrongLettersMessage(List<char> alreadyUsedLetters)
        {
            Console.WriteLine();
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[green]Sie haben bereits diese falschen Buchstaben verwendet:[/] [lime]{string.Join(", ", alreadyUsedLetters)}[/]"));
        }

        public void PrintHangmanInputMessage()
        {
            Console.WriteLine();
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[palegreen3_1]Schreiben Sie mögliche Buchstaben: [/]"));
        }

        public void PrintHangmanWinningMessage(string word)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("[yellow]HERZLICHEN GLÜCKWUNSCH, Sie haben das Wort vervollständigt![/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]Das Wort war: {word}[/]"));
        }

        public void PrintHangmanLoseMessage(string hangman, string word)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup($"[yellow]{hangman}[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]Oh nein, du hast das Wort nicht erraten![/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]Das Wort war {word}[/]"));
        }

        public void PrintHangmanMisstakesMessage(int misstakes)
        {
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]Du hast: {misstakes} Fehler gemacht[/]"));
            Console.WriteLine();
        }

        public void PrintTikTakToeHeader()
        {
            AnsiConsole.Write(new FigletText("Drei Gewinnt").Centered().Color(Color.Gold3));
        }

        public void PrintTikTakToePlayer1Message()
        {
            AnsiConsole.Write(new Markup("[yellow3]Der Name von Spieler1 ist: [/]"));
        }

        public void PrintTikTakToePlayer2Message()
        {
            AnsiConsole.Write(new Markup("[yellow3]Der Name von Spieler2 ist: [/]"));
        }

        public void PrintTikTakToeInputMessage(string playerName)
        {
            AnsiConsole.Write(new Markup($"[greenyellow]{playerName}, Geben Sie die Koordinaten Ihres nächsten Zuges ein (Format: Zeile, Spalte): [/]"));
        }

        public void PrintTikTakToeWrongCoordinatesMessage()
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("[red]Falschen Koordinaten[/]"));
        }

        public void PrintTikTakToeDrawMessage()
        {
            AnsiConsole.Write(new Markup("[yellow]Wir haben ein Unentschieden![/]"));
        }

        public void PrintTikTakToeWinningMessage(string winner)
        {
            AnsiConsole.Write(new Markup($"[yellow2]{winner} hat gewinnt!!![/]"));
        }

        public void PrintErrorMessage()
        {
            AnsiConsole.Write(new Markup("[red]Falscher Tastaturschlüssel![/]"));
            Console.WriteLine();
        }

        public void PrintRules()
        {
            AnsiConsole.Write(new Markup("[bold yellow3]Bullen und Kühe[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[darkolivegreen3_2]Der Computer generiert eine zufällige Kombination aus vier Zahlen (die Zahlen wiederholen sich garantiert nicht) " +
                Environment.NewLine +
                "und es gibt eine Zelle für die nächste Kombination. Sie haben eine unbegrenzte Anzahl an Versuchen. Wie bei beiden Combos bedeutet dies, dass es auch auf dem PC verfügbar ist. " +
                Environment.NewLine +
                "aber es ist nicht an der richtigen Position, dann haben Sie eine Kuh, und wenn Sie eine Zahl haben, die an der richtigen Position ist, haben Sie einen Bullen.[/]"));
            Console.WriteLine();
            Console.WriteLine();    
            AnsiConsole.Write(new Markup("[bold darkviolet_1]Galgenmännchen[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[purple_2]Der Computer generiert ein zufälliges Wort und Ihr Ziel ist es, es zu erraten. Mit jedem Fehler zieht der Computer deinen Galgen " +
                Environment.NewLine +
                "und bei deinen letzten 9 Fehlern verlierst du. Wie errät man das Wort? Dazu schreiben Sie einen bestimmten Buchstaben und der Computer zeigt Ihnen entsprechend an, ob dieser Buchstabe im Wort vorkommt oder nicht " +
                Environment.NewLine +
                "und so muss man das Wort Buchstabe für Buchstabe erraten.[/]"));
            Console.WriteLine();
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[bold gold3]Drei Gewinnt[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow3_1]Dies ist ein Spiel für zwei Spieler. Einer spielt mit X und der andere mit O. Ziel ist es, dass einer der beiden drei gleiche Spielsteine ​​in einer Reihe, Spalte oder Diagonale hat.[/]"));
            Console.WriteLine();
        }
    }
}
