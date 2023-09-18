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
        public void PrintBackMessage()
        {
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[underline red]Drücken Sie die Entf-Taste, wenn Sie zu den Setup-Optionen zurückkehren möchten.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[underline blue]Drücken Sie die Eingabetaste, wenn Sie fortfahren möchten.[/]"));
            Console.WriteLine();
            Footer.PrintFooter();
        }

        public void PrintLanguageChooseMessage()
        {
            Logo.PrintLogo();
            AnsiConsole.Write(new Markup("[red]Drücken Sie die Taste mit der Nummer vor der Sprache, die Sie ändern möchten.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/] [white]Bul[/][green]gar[/][red]isch[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/] [red]Eng[/][white]li[/][blue]sch[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/] [grey19]De[/][red]ut[/][yellow]sch[/]"));
            Console.WriteLine();
            Footer.PrintFooter();
        }

        public void PrintSetUpMessage()
        {
            Logo.PrintLogo();
            AnsiConsole.Write(new Markup("[underline deeppink4]Wenn Sie etwas ändern möchten, klicken Sie auf die Schaltfläche Ihrer Tastatur, die der Zahl vor der Einstellung entspricht.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/][hotpink2]Wähle ihre Sprache[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/][violet]Lesen Sie die Regeln[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/][mediumorchid1]Forsetzen[/]"));
            Console.WriteLine();
            Footer.PrintFooter();
        }

        public void PrintGameMenu()
        {
            Logo.PrintLogo();
            AnsiConsole.Write(new Markup("[seagreen2]Wählen Sie ein Spiel:[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/] [blue]Kuh[/] Und [red]Bulle[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/] [gray]Galgenmännchen[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/] [darkgreen]Labyrinthe[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]4.[/] [lime]Schlange[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]5.[/] [khaki1]Drei Gewinnt[/]"));
            Console.WriteLine();
            Footer.PrintFooter();
        }
    }
}
